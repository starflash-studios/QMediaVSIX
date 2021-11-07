// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Runtime.InteropServices.WindowsRuntime {
    // Helper functions to manually marshal data between .NET and WinRT
    public static class WindowsRuntimeMarshal {
        // Add an event handler to a Windows Runtime style event, such that it can be removed via a delegate
        // lookup at a later time.  This method adds the handler to the add method using the supplied
        // delegate.  It then stores the corresponding token in a dictionary for easy access by RemoveEventHandler
        // later.  Note that the dictionary is indexed by the remove method that will be used for RemoveEventHandler
        // so the removeMethod given here must match the remove method supplied there exactly.
        public static void AddEventHandler<T>( Func<T, EventRegistrationToken> AddMethod,
                                              Action<EventRegistrationToken> RemoveMethod,
                                              T Handler ) {
            if ( AddMethod == null )
                throw new ArgumentNullException(nameof(AddMethod));
            if ( RemoveMethod == null )
                throw new ArgumentNullException(nameof(RemoveMethod));

            // Managed code allows adding a null event handler, the effect is a no-op.  To match this behavior
            // for WinRT events, we simply ignore attempts to add null.
            if ( Handler == null ) {
                return;
            }

            // Delegate to managed event registration implementation or native event registration implementation
            // They have completely different implementation because native side has its own unique problem to solve -
            // there could be more than one RCW for the same COM object
            // it would be more confusing and less-performant if we were to merge them together
            object? Target = RemoveMethod.Target;
            if ( Target == null || Marshal.IsComObject(Target) )
                NativeOrStaticEventRegistrationImpl.AddEventHandler<T>(AddMethod, RemoveMethod, Handler);
            else
                ManagedEventRegistrationImpl.AddEventHandler<T>(AddMethod, RemoveMethod, Handler);
        }

        // Remove the delegate handler from the Windows Runtime style event registration by looking for
        // its token, previously stored via AddEventHandler<T>
        public static void RemoveEventHandler<T>( Action<EventRegistrationToken> RemoveMethod, T Handler ) {
            if ( RemoveMethod == null )
                throw new ArgumentNullException(nameof(RemoveMethod));

            // Managed code allows removing a null event handler, the effect is a no-op.  To match this behavior
            // for WinRT events, we simply ignore attempts to remove null.
            if ( Handler == null ) {
                return;
            }

            // Delegate to managed event registration implementation or native event registration implementation
            // They have completely different implementation because native side has its own unique problem to solve -
            // there could be more than one RCW for the same COM object
            // it would be more confusing and less-performant if we were to merge them together
            object? Target = RemoveMethod.Target;
            if ( Target == null || Marshal.IsComObject(Target) )
                NativeOrStaticEventRegistrationImpl.RemoveEventHandler<T>(RemoveMethod, Handler);
            else
                ManagedEventRegistrationImpl.RemoveEventHandler<T>(RemoveMethod, Handler);
        }

        public static void RemoveAllEventHandlers( Action<EventRegistrationToken> RemoveMethod ) {
            if ( RemoveMethod == null )
                throw new ArgumentNullException(nameof(RemoveMethod));

            // Delegate to managed event registration implementation or native event registration implementation
            // They have completely different implementation because native side has its own unique problem to solve -
            // there could be more than one RCW for the same COM object
            // it would be more confusing and less-performant if we were to merge them together
            object? Target = RemoveMethod.Target;
            if ( Target == null || Marshal.IsComObject(Target) )
                NativeOrStaticEventRegistrationImpl.RemoveAllEventHandlers(RemoveMethod);
            else
                ManagedEventRegistrationImpl.RemoveAllEventHandlers(RemoveMethod);
        }

        // Returns the total cache size
        // Used by test only to verify we don't leak event cache
        internal static int GetRegistrationTokenCacheSize() {
            int Count = 0;

            if ( ManagedEventRegistrationImpl.S_EVENTRegistrations != null ) {
                lock ( ManagedEventRegistrationImpl.S_EVENTRegistrations ) {
                    foreach ( var Item in ManagedEventRegistrationImpl.S_EVENTRegistrations )
                        Count++;
                }
            }

            if ( NativeOrStaticEventRegistrationImpl.S_EVENTRegistrations != null ) {
                lock ( NativeOrStaticEventRegistrationImpl.S_EVENTRegistrations ) {
                    Count += NativeOrStaticEventRegistrationImpl.S_EVENTRegistrations.Count;
                }
            }

            return Count;
        }

        //
        // Optimized version of List of EventRegistrationToken
        // It is made a struct to reduce overhead
        //
        internal struct EventRegistrationTokenList {
            private EventRegistrationToken _FirstToken;     // Optimization for common case where there is only one token
            private List<EventRegistrationToken>? _RestTokens;     // Rest of the tokens

            internal EventRegistrationTokenList( EventRegistrationToken Token ) {
                _FirstToken = Token;
                _RestTokens = null;
            }

            // Push a new token into this list
            // Returns true if you need to copy back this list into the dictionary (so that you
            // don't lose change outside the dictionary). false otherwise.
            public bool Push( EventRegistrationToken Token ) {
                bool NeedCopy = false;

                if ( _RestTokens == null ) {
                    _RestTokens = new List<EventRegistrationToken>();
                    NeedCopy = true;
                }

                _RestTokens.Add(Token);

                return NeedCopy;
            }

            // Pops the last token
            // Returns false if no more tokens left, true otherwise
            public bool Pop( out EventRegistrationToken Token ) {
                // Only 1 token in this list and we just removed the last token
                if ( _RestTokens == null || _RestTokens.Count == 0 ) {
                    Token = _FirstToken;
                    return false;
                }

                int Last = _RestTokens.Count - 1;
                Token = _RestTokens[Last];
                _RestTokens.RemoveAt(Last);

                return true;
            }

            public void CopyTo( List<EventRegistrationToken> Tokens ) {
                Tokens.Add(_FirstToken);
                if ( _RestTokens != null )
                    Tokens.AddRange(_RestTokens);
            }
        }

        //
        // Event registration support for managed objects events & static events
        //
        internal static class ManagedEventRegistrationImpl {
            // Mappings of delegates registered for events -> their registration tokens.
            // These mappings are stored indexed by the remove method which can be used to undo the registrations.
            //
            // The full structure of this table is:
            //   object the event is being registered on ->
            //      Table [RemoveMethod] ->
            //        Table [Handler] -> Token
            //
            // Note: There are a couple of optimizations I didn't do here because they don't make sense for managed events:
            // 1.  Flatten the event cache (see EventCacheKey in native WinRT event implementation below)
            //
            //     This is because managed events use ConditionalWeakTable to hold Objects->(Event->(Handler->Tokens)),
            //     and when object goes away everything else will be nicely cleaned up. If I flatten it like native WinRT events,
            //     I'll have to use Dictionary (as ConditionalWeakTable won't work - nobody will hold the new key alive anymore)
            //     instead, and that means I'll have to add more code from native WinRT events into managed WinRT event to support
            //     self-cleanup in the finalization, as well as reader/writer lock to protect against race conditions in the finalization,
            //     which adds a lot more complexity and doesn't really worth it.
            //
            // 2.  Use conditionalWeakTable to hold Handler->Tokens.
            //
            //     The reason is very simple - managed object use dictionary (see EventRegistrationTokenTable) to hold delegates alive.
            //     If the delegates aren't alive, it means either they have been unsubscribed, or the object itself is gone,
            //     and in either case, they've been already taken care of.
            //
            internal volatile static
                ConditionalWeakTable<object, Dictionary<MethodInfo, Dictionary<object, EventRegistrationTokenList>>> S_EVENTRegistrations =
                    new ConditionalWeakTable<object, Dictionary<MethodInfo, Dictionary<object, EventRegistrationTokenList>>>();

            internal static void AddEventHandler<T>( Func<T, EventRegistrationToken> AddMethod,
                                                  Action<EventRegistrationToken> RemoveMethod,
                                                  T Handler ) {
                Debug.Assert(AddMethod != null);
                Debug.Assert(RemoveMethod != null);
                Debug.Assert(RemoveMethod.Target != null);
                Debug.Assert(Handler != null);

                // Add the method, and make a note of the token -> delegate mapping.
                object Instance = RemoveMethod.Target;
                Dictionary<object, EventRegistrationTokenList> RegistrationTokens = GetEventRegistrationTokenTable(Instance, RemoveMethod);
                EventRegistrationToken Token = AddMethod(Handler);
                lock ( RegistrationTokens ) {
                    EventRegistrationTokenList Tokens;
                    if ( !RegistrationTokens.TryGetValue(Handler, out Tokens) ) {
                        Tokens = new EventRegistrationTokenList(Token);
                        RegistrationTokens[Handler] = Tokens;
                    } else {
                        bool NeedCopy = Tokens.Push(Token);

                        // You need to copy back this list into the dictionary (so that you don't lose change outside dictionary)
                        if ( NeedCopy )
                            RegistrationTokens[Handler] = Tokens;
                    }

                    Log("[WinRT_Eventing] Event subscribed for managed instance = " + Instance + ", handler = " + Handler + "\n");
                }
            }

            // Get the event registration token table for an event.  These are indexed by the remove method of the event.
            private static Dictionary<object, EventRegistrationTokenList> GetEventRegistrationTokenTable( object Instance, Action<EventRegistrationToken> RemoveMethod ) {
                Debug.Assert(Instance != null);
                Debug.Assert(RemoveMethod != null);
                Debug.Assert(S_EVENTRegistrations != null);

                lock ( S_EVENTRegistrations ) {
                    Dictionary<MethodInfo, Dictionary<object, EventRegistrationTokenList>>? InstanceMap = null;
                    if ( !S_EVENTRegistrations.TryGetValue(Instance, out InstanceMap) ) {
                        InstanceMap = new Dictionary<MethodInfo, Dictionary<object, EventRegistrationTokenList>>();
                        S_EVENTRegistrations.Add(Instance, InstanceMap);
                    }

                    Dictionary<object, EventRegistrationTokenList>? Tokens = null;
                    if ( !InstanceMap.TryGetValue(RemoveMethod.Method, out Tokens) ) {
                        Tokens = new Dictionary<object, EventRegistrationTokenList>();
                        InstanceMap.Add(RemoveMethod.Method, Tokens);
                    }

                    return Tokens;
                }
            }

            internal static void RemoveEventHandler<T>( Action<EventRegistrationToken> RemoveMethod, T Handler ) {
                Debug.Assert(RemoveMethod != null);
                Debug.Assert(RemoveMethod.Target != null);
                Debug.Assert(Handler != null);

                object Instance = RemoveMethod.Target;
                Dictionary<object, EventRegistrationTokenList> RegistrationTokens = GetEventRegistrationTokenTable(Instance, RemoveMethod);
                EventRegistrationToken Token;

                lock ( RegistrationTokens ) {
                    EventRegistrationTokenList Tokens;

                    // Failure to find a registration for a token is not an error - it's simply a no-op.
                    if ( !RegistrationTokens.TryGetValue(Handler, out Tokens) ) {
                        Log("[WinRT_Eventing] no registrationTokens found for instance=" + Instance + ", handler= " + Handler + "\n");

                        return;
                    }

                    // Select a registration token to unregister
                    // We don't care which one but I'm returning the last registered token to be consistent
                    // with native event registration implementation
                    bool MoreItems = Tokens.Pop(out Token);
                    if ( !MoreItems ) {
                        // Remove it from cache if this list become empty
                        // This must be done because EventRegistrationTokenList now becomes invalid
                        // (mostly because there is no safe default value for EventRegistrationToken to express 'no token')
                        // NOTE: We should try to remove registrationTokens itself from cache if it is empty, otherwise
                        // we could run into a race condition where one thread removes it from cache and another thread adds
                        // into the empty registrationToken table
                        RegistrationTokens.Remove(Handler);
                    }
                }

                RemoveMethod(Token);

                Log("[WinRT_Eventing] Event unsubscribed for managed instance = " + Instance + ", handler = " + Handler + ", token = " + Token.Value + "\n");
            }

            internal static void RemoveAllEventHandlers( Action<EventRegistrationToken> RemoveMethod ) {
                Debug.Assert(RemoveMethod != null);
                Debug.Assert(RemoveMethod.Target != null);

                object Instance = RemoveMethod.Target;
                Dictionary<object, EventRegistrationTokenList> RegistrationTokens = GetEventRegistrationTokenTable(Instance, RemoveMethod);

                List<EventRegistrationToken> TokensToRemove = new List<EventRegistrationToken>();

                lock ( RegistrationTokens ) {
                    // Copy all tokens to tokensToRemove array which later we'll call removeMethod on
                    // outside this lock
                    foreach ( EventRegistrationTokenList Tokens in RegistrationTokens.Values ) {
                        Tokens.CopyTo(TokensToRemove);
                    }

                    // Clear the dictionary - at this point all event handlers are no longer in the cache
                    // but they are not removed yet
                    RegistrationTokens.Clear();
                    Log("[WinRT_Eventing] Cache cleared for managed instance = " + Instance + "\n");
                }

                //
                // Remove all handlers outside the lock
                //
                Log("[WinRT_Eventing] Start removing all events for instance = " + Instance + "\n");
                CallRemoveMethods(RemoveMethod, TokensToRemove);
                Log("[WinRT_Eventing] Finished removing all events for instance = " + Instance + "\n");
            }
        }

        //
        // WinRT event registration implementation code
        //
        internal static class NativeOrStaticEventRegistrationImpl {
            //
            // Key = (target object, event)
            // We use a key of object+event to save an extra dictionary
            //
            internal struct EventCacheKey : IEquatable<EventCacheKey> {
                internal object Target;
                internal MethodInfo Method;

                public override string ToString() {
                    return "(" + Target + ", " + Method + ")";
                }

                public bool Equals( EventCacheKey Other ) {
                    return (object.Equals(Target, Other.Target) && object.Equals(Method, Other.Method));
                }

                public int GetHashCode( EventCacheKey Key ) {
                    return Key.Target.GetHashCode() ^ Key.Method.GetHashCode();
                }
            }

            //
            // EventRegistrationTokenListWithCount
            //
            // A list of EventRegistrationTokens that maintains a count
            //
            // The reason this needs to be a separate class is that we need a finalizer for this class
            // If the delegate is collected, it will take this list away with it (due to dependent handles),
            // and we need to remove the PerInstancEntry from cache
            // See ~EventRegistrationTokenListWithCount for more details
            //
            internal class EventRegistrationTokenListWithCount {
                private TokenListCount _TokenListCount;
                private EventRegistrationTokenList _TokenList;

                internal EventRegistrationTokenListWithCount( TokenListCount TokenListCount, EventRegistrationToken Token ) {
                    _TokenListCount = TokenListCount;
                    _TokenListCount.Inc();

                    _TokenList = new EventRegistrationTokenList(Token);
                }

                ~EventRegistrationTokenListWithCount() {
                    // Decrement token list count
                    // This is need to correctly keep trace of number of tokens for EventCacheKey
                    // and remove it from cache when the token count drop to 0
                    // we don't need to take locks for decrement the count - we only need to take a global
                    // lock when we decide to destroy cache for the IUnknown */type instance
                    Log("[WinRT_Eventing] Finalizing EventRegistrationTokenList for " + _TokenListCount.Key + "\n");
                    _TokenListCount.Dec();
                }

                public void Push( EventRegistrationToken Token ) {
                    // Since EventRegistrationTokenListWithCount is a reference type, there is no need
                    // to copy back. Ignore the return value
                    _TokenList.Push(Token);
                }

                public bool Pop( out EventRegistrationToken Token ) {
                    return _TokenList.Pop(out Token);
                }

                public void CopyTo( List<EventRegistrationToken> Tokens ) {
                    _TokenList.CopyTo(Tokens);
                }
            }

            //
            // Maintains the number of tokens for a particular EventCacheKey
            // TokenListCount is a class for two reasons:
            // 1. Efficient update in the Dictionary to avoid lookup twice to update the value
            // 2. Update token count without taking a global lock. Only takes a global lock when drop to 0
            //
            internal class TokenListCount {
                private int _Count;
                private EventCacheKey _Key;

                internal TokenListCount( EventCacheKey Key ) {
                    _Key = Key;
                }

                internal EventCacheKey Key {
                    get { return _Key; }
                }

                internal void Inc() {
                    int NewCount = Interlocked.Increment(ref _Count);
                    Log("[WinRT_Eventing] Incremented TokenListCount for " + _Key + ", Value = " + NewCount + "\n");
                }

                internal void Dec() {
                    // Avoid racing with Add/Remove event entries into the cache
                    // You don't want this removing the key in the middle of a Add/Remove
                    _S_EVENTCacheRWLock.AcquireWriterLock(Timeout.Infinite);
                    try {
                        int NewCount = Interlocked.Decrement(ref _Count);
                        Log("[WinRT_Eventing] Decremented TokenListCount for " + _Key + ", Value = " + NewCount + "\n");
                        if ( NewCount == 0 )
                            CleanupCache();
                    } finally {
                        _S_EVENTCacheRWLock.ReleaseWriterLock();
                    }
                }

                private void CleanupCache() {
                    // Time to destroy cache for this IUnknown */type instance
                    // because the total token list count has dropped to 0 and we don't have any events subscribed
                    Debug.Assert(S_EVENTRegistrations != null);

                    Log("[WinRT_Eventing] Removing " + _Key + " from cache" + "\n");
                    S_EVENTRegistrations.Remove(_Key);
                    Log("[WinRT_Eventing] s_eventRegistrations size = " + S_EVENTRegistrations.Count + "\n");
                }
            }

            internal struct EventCacheEntry {
                // [Handler] -> Token
                internal ConditionalWeakTable<object, EventRegistrationTokenListWithCount> RegistrationTable;

                // Maintains current total count for the EventRegistrationTokenListWithCount for this event cache key
                internal TokenListCount TokenListCount;
            }

            // Mappings of delegates registered for events -> their registration tokens.
            // These mappings are stored indexed by the remove method which can be used to undo the registrations.
            //
            // The full structure of this table is:
            //   EventCacheKey (instanceKey, eventMethod) -> EventCacheEntry (Handler->tokens)
            //
            // A InstanceKey is the IUnknown * or static type instance
            //
            // Couple of things to note:
            // 1. We need to use IUnknown* because we want to be able to unscribe to the event for another RCW
            // based on the same COM object. For example:
            //    m_canvas.GetAt(0).Event += Func;
            //    m_canvas.GetAt(0).Event -= Func;  // GetAt(0) might create a new RCW
            //
            // 2. Handler->Token is a ConditionalWeakTable because we don't want to keep the delegate alive
            // and we want EventRegistrationTokenListWithCount to be finalized after the delegate is no longer alive
            // 3. It is possible another COM object is created at the same address
            // before the entry in cache is destroyed. More specifically,
            //   a. The same delegate is being unsubscribed. In this case we'll give them a
            //   stale token - unlikely to be a problem
            //   b. The same delegate is subscribed then unsubscribed. We need to make sure give
            //   them the latest token in this case. This is guaranteed by always giving the last token and always use equality to
            //   add/remove event handlers
            internal volatile static Dictionary<EventCacheKey, EventCacheEntry> S_EVENTRegistrations =
                new Dictionary<EventCacheKey, EventCacheEntry>();

            // Prevent add/remove handler code to run at the same with with cache cleanup code
            private volatile static MyReaderWriterLock _S_EVENTCacheRWLock = new MyReaderWriterLock();

            // Get InstanceKey to use in the cache
            private static object GetInstanceKey( Action<EventRegistrationToken> RemoveMethod ) {
                object? Target = RemoveMethod.Target;
                Debug.Assert(Target == null || Marshal.IsComObject(Target), "Must be null or a RCW");
                if ( Target == null )
                    return RemoveMethod.Method.DeclaringType!;

                // Need the "Raw" IUnknown pointer for the RCW that is not bound to the current context
                return (object)Marshal.GetRawIUnknownForComObjectNoAddRef(Target);
            }

            private static object? FindEquivalentKeyUnsafe( ConditionalWeakTable<object, EventRegistrationTokenListWithCount> RegistrationTable, object Handler, out EventRegistrationTokenListWithCount? Tokens ) {
                foreach ( KeyValuePair<object, EventRegistrationTokenListWithCount> Item in RegistrationTable ) {
                    if ( object.Equals(Item.Key, Handler) ) {
                        Tokens = Item.Value;
                        return Item.Key;
                    }
                }
                Tokens = null;
                return null;
            }

            internal static void AddEventHandler<T>( Func<T, EventRegistrationToken> AddMethod,
                                                  Action<EventRegistrationToken> RemoveMethod,
                                                  T Handler ) {
                Debug.Assert(Handler != null);

                // The instanceKey will be IUnknown * of the target object
                object InstanceKey = GetInstanceKey(RemoveMethod);

                // Call addMethod outside of RW lock
                // At this point we don't need to worry about race conditions and we can avoid deadlocks
                // if addMethod waits on finalizer thread
                // If we later throw we need to remove the method
                EventRegistrationToken Token = AddMethod(Handler);

                bool TokenAdded = false;

                try {
                    EventRegistrationTokenListWithCount? Tokens;

                    //
                    // The whole add/remove code has to be protected by a reader/writer lock
                    // Add/Remove cannot run at the same time with cache cleanup but Add/Remove can run at the same time
                    //
                    _S_EVENTCacheRWLock.AcquireReaderLock(Timeout.Infinite);
                    try {
                        // Add the method, and make a note of the delegate -> token mapping.
                        TokenListCount? TokenListCount;
                        ConditionalWeakTable<object, EventRegistrationTokenListWithCount> RegistrationTokens = GetOrCreateEventRegistrationTokenTable(InstanceKey, RemoveMethod, out TokenListCount);
                        lock ( RegistrationTokens ) {
                            //
                            // We need to find the key that equals to this handler
                            // Suppose we have 3 handlers A, B, C that are equal (refer to the same object and method),
                            // the first handler (let's say A) will be used as the key and holds all the tokens.
                            // We don't need to hold onto B and C, because the COM object itself will keep them alive,
                            // and they won't die anyway unless the COM object dies or they get unsubscribed.
                            // It may appear that it is fine to hold A, B, C, and add them and their corresponding tokens
                            // into registrationTokens table. However, this is very dangerous, because this COM object
                            // may die, but A, B, C might not get collected yet, and another COM object comes into life
                            // with the same IUnknown address, and we subscribe event B. In this case, the right token
                            // will be added into B's token list, but once we unsubscribe B, we might end up removing
                            // the last token in C, and that may lead to crash.
                            //
                            object? Key = FindEquivalentKeyUnsafe(RegistrationTokens, Handler, out Tokens);
                            if ( Key == null ) {
                                Tokens = new EventRegistrationTokenListWithCount(TokenListCount, Token);
                                RegistrationTokens.Add(Handler, Tokens);
                            } else {
                                Tokens!.Push(Token);
                            }

                            TokenAdded = true;
                        }
                    } finally {
                        _S_EVENTCacheRWLock.ReleaseReaderLock();
                    }

                    Log("[WinRT_Eventing] Event subscribed for instance = " + InstanceKey + ", handler = " + Handler + "\n");
                } catch ( Exception ) {
                    // If we've already added the token and go there, we don't need to "UNDO" anything
                    if ( !TokenAdded ) {
                        // Otherwise, "Undo" addMethod if any exception occurs
                        // There is no need to cleanup our data structure as we haven't added the token yet
                        RemoveMethod(Token);
                    }


                    throw;
                }
            }

            private static ConditionalWeakTable<object, EventRegistrationTokenListWithCount>? GetEventRegistrationTokenTableNoCreate( object Instance, Action<EventRegistrationToken> RemoveMethod, out TokenListCount? TokenListCount ) {
                Debug.Assert(Instance != null);
                Debug.Assert(RemoveMethod != null);

                return GetEventRegistrationTokenTableInternal(Instance, RemoveMethod, out TokenListCount, /* createIfNotFound = */ false);
            }

            private static ConditionalWeakTable<object, EventRegistrationTokenListWithCount> GetOrCreateEventRegistrationTokenTable( object Instance, Action<EventRegistrationToken> RemoveMethod, out TokenListCount TokenListCount ) {
                Debug.Assert(Instance != null);
                Debug.Assert(RemoveMethod != null);

                return GetEventRegistrationTokenTableInternal(Instance, RemoveMethod, out TokenListCount!, /* createIfNotFound = */ true)!;
            }

            // Get the event registration token table for an event.  These are indexed by the remove method of the event.
            private static ConditionalWeakTable<object, EventRegistrationTokenListWithCount>? GetEventRegistrationTokenTableInternal( object Instance, Action<EventRegistrationToken> RemoveMethod, out TokenListCount? TokenListCount, bool CreateIfNotFound ) {
                Debug.Assert(Instance != null);
                Debug.Assert(RemoveMethod != null);
                Debug.Assert(S_EVENTRegistrations != null);

                EventCacheKey EVENTCacheKey;
                EVENTCacheKey.Target = Instance;
                EVENTCacheKey.Method = RemoveMethod.Method;

                lock ( S_EVENTRegistrations ) {
                    EventCacheEntry EVENTCacheEntry;
                    if ( !S_EVENTRegistrations.TryGetValue(EVENTCacheKey, out EVENTCacheEntry) ) {
                        if ( !CreateIfNotFound ) {
                            // No need to create an entry in this case
                            TokenListCount = null;
                            return null;
                        }

                        Log("[WinRT_Eventing] Adding (" + Instance + "," + RemoveMethod.Method + ") into cache" + "\n");

                        EVENTCacheEntry = new EventCacheEntry();
                        EVENTCacheEntry.RegistrationTable = new ConditionalWeakTable<object, EventRegistrationTokenListWithCount>();
                        EVENTCacheEntry.TokenListCount = new TokenListCount(EVENTCacheKey);

                        S_EVENTRegistrations.Add(EVENTCacheKey, EVENTCacheEntry);
                    }

                    TokenListCount = EVENTCacheEntry.TokenListCount;

                    return EVENTCacheEntry.RegistrationTable;
                }
            }

            internal static void RemoveEventHandler<T>( Action<EventRegistrationToken> RemoveMethod, T Handler ) {
                Debug.Assert(Handler != null);

                object InstanceKey = GetInstanceKey(RemoveMethod);

                EventRegistrationToken Token;

                //
                // The whole add/remove code has to be protected by a reader/writer lock
                // Add/Remove cannot run at the same time with cache cleanup but Add/Remove can run at the same time
                //
                _S_EVENTCacheRWLock.AcquireReaderLock(Timeout.Infinite);
                try {
                    TokenListCount? TokenListCount;
                    ConditionalWeakTable<object, EventRegistrationTokenListWithCount>? RegistrationTokens = GetEventRegistrationTokenTableNoCreate(InstanceKey, RemoveMethod, out TokenListCount);
                    if ( RegistrationTokens == null ) {
                        // We have no information regarding this particular instance (IUnknown*/type) - just return
                        // This is necessary to avoid leaking empty dictionary/conditionalWeakTables for this instance
                        Log("[WinRT_Eventing] no registrationTokens found for instance=" + InstanceKey + ", handler= " + Handler + "\n");
                        return;
                    }

                    lock ( RegistrationTokens ) {
                        EventRegistrationTokenListWithCount? Tokens;

                        // Note:
                        // When unsubscribing events, we allow subscribing the event using a different delegate
                        // (but with the same object/method), so we need to find the first delegate that matches
                        // and unsubscribe it
                        // It actually doesn't matter which delegate - as long as it matches
                        // Note that inside TryGetValueWithValueEquality we assumes that any delegate
                        // with the same value equality would have the same hash code
                        object? Key = FindEquivalentKeyUnsafe(RegistrationTokens, Handler, out Tokens);
                        Debug.Assert((Key != null && Tokens != null) || (Key == null && Tokens == null),
                                        "key and tokens must be both null or non-null");
                        if ( Tokens == null ) {
                            // Failure to find a registration for a token is not an error - it's simply a no-op.
                            Log("[WinRT_Eventing] no token list found for instance=" + InstanceKey + ", handler= " + Handler + "\n");
                            return;
                        }

                        // Select a registration token to unregister
                        // Note that we need to always get the last token just in case another COM object
                        // is created at the same address before the entry for the old one goes away.
                        // See comments above s_eventRegistrations for more details
                        bool MoreItems = Tokens.Pop(out Token);

                        // If the last token is removed from token list, we need to remove it from the cache
                        // otherwise FindEquivalentKeyUnsafe may found this empty token list even though there could be other
                        // equivalent keys in there with non-0 token list
                        if ( !MoreItems ) {
                            // Remove it from (handler)->(tokens)
                            // NOTE: We should not check whether registrationTokens has 0 entries and remove it from the cache
                            // (just like managed event implementation), because this might have raced with the finalizer of
                            // EventRegistrationTokenList
                            RegistrationTokens.Remove(Key!);
                        }

                        Log("[WinRT_Eventing] Event unsubscribed for managed instance = " + InstanceKey + ", handler = " + Handler + ", token = " + Token.Value + "\n");
                    }
                } finally {
                    _S_EVENTCacheRWLock.ReleaseReaderLock();
                }

                // Call removeMethod outside of RW lock
                // At this point we don't need to worry about race conditions and we can avoid deadlocks
                // if removeMethod waits on finalizer thread
                RemoveMethod(Token);
            }

            internal static void RemoveAllEventHandlers( Action<EventRegistrationToken> RemoveMethod ) {
                object InstanceKey = GetInstanceKey(RemoveMethod);

                List<EventRegistrationToken> TokensToRemove = new List<EventRegistrationToken>();

                //
                // The whole add/remove code has to be protected by a reader/writer lock
                // Add/Remove cannot run at the same time with cache cleanup but Add/Remove can run at the same time
                //
                _S_EVENTCacheRWLock.AcquireReaderLock(Timeout.Infinite);
                try {
                    ConditionalWeakTable<object, EventRegistrationTokenListWithCount>? RegistrationTokens = GetEventRegistrationTokenTableNoCreate(InstanceKey, RemoveMethod, out _);
                    if ( RegistrationTokens == null ) {
                        // We have no information regarding this particular instance (IUnknown*/type) - just return
                        // This is necessary to avoid leaking empty dictionary/conditionalWeakTables for this instance
                        return;
                    }

                    lock ( RegistrationTokens ) {
                        // Copy all tokens to tokensToRemove array which later we'll call removeMethod on
                        // outside this lock
                        foreach ( KeyValuePair<object, EventRegistrationTokenListWithCount> Item in RegistrationTokens ) {
                            Item.Value.CopyTo(TokensToRemove);
                        }

                        // Clear the table - at this point all event handlers are no longer in the cache
                        // but they are not removed yet
                        RegistrationTokens.Clear();
                        Log("[WinRT_Eventing] Cache cleared for managed instance = " + InstanceKey + "\n");
                    }
                } finally {
                    _S_EVENTCacheRWLock.ReleaseReaderLock();
                }

                //
                // Remove all handlers outside the lock
                //
                Log("[WinRT_Eventing] Start removing all events for instance = " + InstanceKey + "\n");
                CallRemoveMethods(RemoveMethod, TokensToRemove);
                Log("[WinRT_Eventing] Finished removing all events for instance = " + InstanceKey + "\n");
            }


            internal class ReaderWriterLockTimedOutException : ApplicationException {
            }

            /// Discussed @ https://blogs.msdn.microsoft.com/vancem/2006/03/29/analysis-of-reader-writer-lock/
            ///
            /// <summary>
            /// A reader-writer lock implementation that is intended to be simple, yet very
            /// efficient.  In particular only 1 interlocked operation is taken for any lock
            /// operation (we use spin locks to achieve this).  The spin lock is never held
            /// for more than a few instructions (in particular, we never call event APIs
            /// or in fact any non-trivial API while holding the spin lock).
            ///
            /// Currently this ReaderWriterLock does not support recursion, however it is
            /// not hard to add
            /// </summary>
            internal class MyReaderWriterLock {
                // Lock specifiation for myLock:  This lock protects exactly the local fields associted
                // instance of MyReaderWriterLock.  It does NOT protect the memory associted with the
                // the events that hang off this lock (eg writeEvent, readEvent upgradeEvent).
                private int _MyLock;

                // Who owns the lock owners > 0 => readers
                // owners = -1 means there is one writer.  Owners must be >= -1.
                private int _Owners;

                // These variables allow use to avoid Setting events (which is expensive) if we don't have to.
                private uint _NumWriteWaiters;        // maximum number of threads that can be doing a WaitOne on the writeEvent
                private uint _NumReadWaiters;         // maximum number of threads that can be doing a WaitOne on the readEvent

                // conditions we wait on.
                private EventWaitHandle? _WriteEvent;    // threads waiting to acquire a write lock go here.
                private EventWaitHandle? _ReadEvent;     // threads waiting to acquire a read lock go here (will be released in bulk)

                internal MyReaderWriterLock() {
                    // All state can start out zeroed.
                }

                internal void AcquireReaderLock( int MillisecondsTimeout ) {
                    EnterMyLock();
                    for (; ; )
                    {
                        // We can enter a read lock if there are only read-locks have been given out
                        // and a writer is not trying to get in.
                        if ( _Owners >= 0 && _NumWriteWaiters == 0 ) {
                            // Good case, there is no contention, we are basically done
                            _Owners++;       // Indicate we have another reader
                            break;
                        }

                        // Drat, we need to wait.  Mark that we have waiters and wait.
                        if ( _ReadEvent == null )      // Create the needed event
                        {
                            LazyCreateEvent(ref _ReadEvent, false);
                            continue;   // since we left the lock, start over.
                        }

                        WaitOnEvent(_ReadEvent, ref _NumReadWaiters, MillisecondsTimeout);
                    }
                    ExitMyLock();
                }

                internal void AcquireWriterLock( int MillisecondsTimeout ) {
                    EnterMyLock();
                    for (; ; )
                    {
                        if ( _Owners == 0 ) {
                            // Good case, there is no contention, we are basically done
                            _Owners = -1;    // indicate we have a writer.
                            break;
                        }

                        // Drat, we need to wait.  Mark that we have waiters and wait.
                        if ( _WriteEvent == null )     // create the needed event.
                        {
                            LazyCreateEvent(ref _WriteEvent, true);
                            continue;   // since we left the lock, start over.
                        }

                        WaitOnEvent(_WriteEvent, ref _NumWriteWaiters, MillisecondsTimeout);
                    }
                    ExitMyLock();
                }

                internal void ReleaseReaderLock() {
                    EnterMyLock();
                    Debug.Assert(_Owners > 0, "ReleasingReaderLock: releasing lock and no read lock taken");
                    --_Owners;
                    ExitAndWakeUpAppropriateWaiters();
                }

                internal void ReleaseWriterLock() {
                    EnterMyLock();
                    Debug.Assert(_Owners == -1, "Calling ReleaseWriterLock when no write lock is held");
                    _Owners++;
                    ExitAndWakeUpAppropriateWaiters();
                }

                /// <summary>
                /// A routine for lazily creating a event outside the lock (so if errors
                /// happen they are outside the lock and that we don't do much work
                /// while holding a spin lock).  If all goes well, reenter the lock and
                /// set 'waitEvent'
                /// </summary>
                private void LazyCreateEvent( ref EventWaitHandle? WaitEvent, bool MakeAutoResetEvent ) {
                    Debug.Assert(_MyLock != 0, "Lock must be held");
                    Debug.Assert(WaitEvent == null, "Wait event must be null");

                    ExitMyLock();
                    EventWaitHandle NewEvent;
                    if ( MakeAutoResetEvent )
                        NewEvent = new AutoResetEvent(false);
                    else
                        NewEvent = new ManualResetEvent(false);
                    EnterMyLock();
                    if ( WaitEvent == null )          // maybe someone snuck in.
                        WaitEvent = NewEvent;
                }

                /// <summary>
                /// Waits on 'waitEvent' with a timeout of 'millisceondsTimeout.
                /// Before the wait 'numWaiters' is incremented and is restored before leaving this routine.
                /// </summary>
                private void WaitOnEvent( EventWaitHandle WaitEvent, ref uint NumWaiters, int MillisecondsTimeout ) {
                    Debug.Assert(_MyLock != 0, "Lock must be held");

                    WaitEvent.Reset();
                    NumWaiters++;

                    bool WaitSuccessful = false;
                    ExitMyLock();      // Do the wait outside of any lock
                    try {
                        if ( !WaitEvent.WaitOne(MillisecondsTimeout, false) )
                            throw new ReaderWriterLockTimedOutException();

                        WaitSuccessful = true;
                    } finally {
                        EnterMyLock();
                        --NumWaiters;
                        if ( !WaitSuccessful )        // We are going to throw for some reason.  Exit myLock.
                            ExitMyLock();
                    }
                }

                /// <summary>
                /// Determines the appropriate events to set, leaves the locks, and sets the events.
                /// </summary>
                private void ExitAndWakeUpAppropriateWaiters() {
                    Debug.Assert(_MyLock != 0, "Lock must be held");

                    if ( _Owners == 0 && _NumWriteWaiters > 0 ) {
                        ExitMyLock();      // Exit before signaling to improve efficiency (wakee will need the lock)
                        _WriteEvent!.Set(); // release one writer.  Must be non-null if there were waiters.
                    } else if ( _Owners >= 0 && _NumReadWaiters != 0 ) {
                        ExitMyLock();    // Exit before signaling to improve efficiency (wakee will need the lock)
                        _ReadEvent!.Set();  // release all readers.  Must be non-null if there were waiters.
                    } else {
                        ExitMyLock();
                    }
                }

                private void EnterMyLock() {
                    if ( Interlocked.CompareExchange(ref _MyLock, 1, 0) != 0 )
                        EnterMyLockSpin();
                }

                private void EnterMyLockSpin() {
                    for ( int I = 0; ; I++ ) {
                        if ( I < 3 && Environment.ProcessorCount > 1 )
                            Thread.SpinWait(20);    // Wait a few dozen instructions to let another processor release lock.
                        else
                            Thread.Sleep(0);        // Give up my quantum.

                        if ( Interlocked.CompareExchange(ref _MyLock, 1, 0) == 0 )
                            return;
                    }
                }
                private void ExitMyLock() {
                    Debug.Assert(_MyLock != 0, "Exiting spin lock that is not held");
                    _MyLock = 0;
                }
            };
        }

        //
        // Call removeMethod on each token and aggregate all exceptions thrown from removeMethod into one in case of failure
        //
        internal static void CallRemoveMethods( Action<EventRegistrationToken> RemoveMethod, List<EventRegistrationToken> TokensToRemove ) {
            List<Exception> Exceptions = new List<Exception>();

            foreach ( EventRegistrationToken Token in TokensToRemove ) {
                try {
                    RemoveMethod(Token);
                } catch ( Exception Ex ) {
                    Exceptions.Add(Ex);
                }

                Log("[WinRT_Eventing] Event unsubscribed for token = " + Token.Value + "\n");
            }

            if ( Exceptions.Count > 0 )
                throw new AggregateException(Exceptions.ToArray());
        }

        internal static unsafe string HStringToString( IntPtr Hstring ) {
            Debug.Assert(Environment.IsWinRTSupported);

            // There is no difference between a null and empty HSTRING
            if ( Hstring == IntPtr.Zero ) {
                return string.Empty;
            }

            unsafe {
                uint Length;
                char* RawBuffer = UnsafeNativeMethods.WindowsGetStringRawBuffer(Hstring, &Length);
                return new string(RawBuffer, 0, checked((int)Length));
            }
        }

        internal static Exception GetExceptionForHR( int Hresult, Exception? InnerException, string? MessageResource ) {
            Exception? E = null;
            if ( InnerException != null ) {
                string? Message = InnerException.Message;
                if ( Message == null && MessageResource != null ) {
                    Message = SR.GetResourceString(MessageResource);
                }
                E = new Exception(Message, InnerException);
            } else {
                string? Message = (MessageResource != null ? SR.GetResourceString(MessageResource): null);
                E = new Exception(Message);
            }

            E.HResult = Hresult;
            return E;
        }

        internal static Exception GetExceptionForHR( int Hresult, Exception? InnerException ) {
            return GetExceptionForHR(Hresult, InnerException, null);
        }

        private static bool _S_HaveBlueErrorApis = true;

        private static bool RoOriginateLanguageException( int Error, string Message, IntPtr LanguageException ) {
            if ( _S_HaveBlueErrorApis ) {
                try {
                    return UnsafeNativeMethods.RoOriginateLanguageException(Error, Message, LanguageException);
                } catch ( EntryPointNotFoundException ) {
                    _S_HaveBlueErrorApis = false;
                }
            }

            return false;
        }

        private static void RoReportUnhandledError( IRestrictedErrorInfo Error ) {
            if ( _S_HaveBlueErrorApis ) {
                try {
                    UnsafeNativeMethods.RoReportUnhandledError(Error);
                } catch ( EntryPointNotFoundException ) {
                    _S_HaveBlueErrorApis = false;
                }
            }
        }

        private static Guid _S_IidIErrorInfo = new Guid(0x1CF2B120, 0x547D, 0x101B, 0x8E, 0x65, 0x08, 0x00, 0x2B, 0x2B, 0xD1, 0x19);

        /// <summary>
        /// Report that an exception has occurred which went user unhandled.  This allows the global error handler
        /// for the application to be invoked to process the error.
        /// </summary>
        /// <returns>true if the error was reported, false if not (ie running on Win8)</returns>
        internal static bool ReportUnhandledError( Exception? E ) {
            // Only report to the WinRT global exception handler in modern apps
            if ( !ApplicationModel.IsUap ) {
                return false;
            }

            // If we don't have the capability to report to the global error handler, early out
            if ( !_S_HaveBlueErrorApis ) {
                return false;
            }

            if ( E != null ) {
                IntPtr ExceptionIUnknown = IntPtr.Zero;
                IntPtr ExceptionIErrorInfo = IntPtr.Zero;
                try {
                    // Get an IErrorInfo for the current exception and originate it as a langauge error in order to have
                    // Windows generate an IRestrictedErrorInfo corresponding to the exception object.  We can then
                    // notify the global error handler that this IRestrictedErrorInfo instance represents an exception that
                    // went unhandled in managed code.
                    //
                    // Note that we need to get an IUnknown for the exception object and then QI for IErrorInfo since Exception
                    // doesn't implement IErrorInfo in managed code - only its CCW does.
                    ExceptionIUnknown = Marshal.GetIUnknownForObject(E);
                    if ( ExceptionIUnknown != IntPtr.Zero ) {
                        Marshal.QueryInterface(ExceptionIUnknown, ref _S_IidIErrorInfo, out ExceptionIErrorInfo);
                        if ( ExceptionIErrorInfo != IntPtr.Zero ) {
                            if ( RoOriginateLanguageException(Marshal.GetHRForException(E), E.Message, ExceptionIErrorInfo) ) {
                                IRestrictedErrorInfo RestrictedError = UnsafeNativeMethods.GetRestrictedErrorInfo();
                                if ( RestrictedError != null ) {
                                    RoReportUnhandledError(RestrictedError);
                                    return true;
                                }
                            }
                        }
                    }
                } finally {
                    if ( ExceptionIErrorInfo != IntPtr.Zero ) {
                        Marshal.Release(ExceptionIErrorInfo);
                    }

                    if ( ExceptionIUnknown != IntPtr.Zero ) {
                        Marshal.Release(ExceptionIUnknown);
                    }
                }
            }

            // If we got here, then some step of the marshaling failed, which means the GEH was not invoked
            return false;
        }

#if FEATURE_COMINTEROP_WINRT_MANAGED_ACTIVATION
        // Get an IActivationFactory * for a managed type
        internal static IntPtr GetActivationFactoryForType(Type type)
        {
            ManagedActivationFactory activationFactory = GetManagedActivationFactory(type);
            return Marshal.GetComInterfaceForObject(activationFactory, typeof(IActivationFactory));
        }

        internal static ManagedActivationFactory GetManagedActivationFactory(Type type)
        {
            ManagedActivationFactory activationFactory = new ManagedActivationFactory(type);

            // If the type has any associated factory interfaces (i.e. supports non-default activation
            // or has statics), the CCW for this instance of ManagedActivationFactory must support them.
            InitializeManagedWinRTFactoryObject(activationFactory, (RuntimeType)type);
            return activationFactory;
        }


#endif // FEATURE_COMINTEROP_WINRT_MANAGED_ACTIVATION

        //
        // Get activation factory object for a specified WinRT type
        // If the WinRT type is a native type, we'll always create a unique RCW for it,
        // This is necessary because WinRT factories are often implemented as a singleton,
        // and getting back a RCW for such WinRT factory would usually get back a RCW from
        // another apartment, even if the interface pointe returned from GetActivationFactory
        // is a raw pointer. As a result, user would randomly get back RCWs for activation
        // factories from other apartments and make transiton to those apartments and cause
        // deadlocks and create objects in incorrect apartments
        //
        public static IActivationFactory GetActivationFactory( Type Type ) {
            if ( Type == null )
                throw new ArgumentNullException(nameof(Type));

            if ( Type.IsWindowsRuntimeObject && Type.IsImport ) {
                return (IActivationFactory)GetNativeActivationFactory(Type);
            } else {
#if FEATURE_COMINTEROP_WINRT_MANAGED_ACTIVATION
                return GetManagedActivationFactory(type);
#else
                // Managed factories are not supported so as to minimize public surface (and test effort)
                throw new NotSupportedException();
#endif
            }
        }

        // HSTRING marshaling methods:

        public static IntPtr StringToHString( string S ) {
            if ( !Environment.IsWinRTSupported )
                throw new PlatformNotSupportedException(SR.PlatformNotSupported_WinRT);

            if ( S == null )
                throw new ArgumentNullException(nameof(S));

            unsafe {
                IntPtr Hstring;
                int HRCreate = UnsafeNativeMethods.WindowsCreateString(S, S.Length, &Hstring);
                Marshal.ThrowExceptionForHR(HRCreate, new IntPtr(-1));
                return Hstring;
            }
        }

        public static string PtrToStringHString( IntPtr Ptr ) {
            if ( !Environment.IsWinRTSupported ) {
                throw new PlatformNotSupportedException(SR.PlatformNotSupported_WinRT);
            }

            return HStringToString(Ptr);
        }

        public static void FreeHString( IntPtr Ptr ) {
            if ( !Environment.IsWinRTSupported )
                throw new PlatformNotSupportedException(SR.PlatformNotSupported_WinRT);

            if ( Ptr != IntPtr.Zero ) {
                UnsafeNativeMethods.WindowsDeleteString(Ptr);
            }
        }

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern object GetUniqueObjectForIUnknownWithoutUnboxing( IntPtr Unknown );

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void InitializeWrapper( object O, ref IntPtr PUnk );

        /// <summary>
        /// Converts the CLR exception to an HRESULT. This function also sets
        /// up an IErrorInfo for the exception.
        /// This function is only used in WinRT and converts ObjectDisposedException
        /// to RO_E_CLOSED
        /// </summary>
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int GetHRForException( Exception E );


#if FEATURE_COMINTEROP_WINRT_MANAGED_ACTIVATION
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void InitializeManagedWinRTFactoryObject(object o, RuntimeType runtimeClassType);
#endif

        /// <summary>
        /// Create activation factory and wraps it with a unique RCW.
        /// </summary>
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object GetNativeActivationFactory( Type Type );

        [Conditional("_LOGGING")]
        private static void Log( string S ) {
            // Internal.Console.WriteLine(s);
        }
    }
}
