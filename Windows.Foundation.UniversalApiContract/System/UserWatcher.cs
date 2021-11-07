// Decompiled with JetBrains decompiler
// Type: Windows.System.UserWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Provides events that fire during enumeration of users, when the collection of users changes, or when a user's authentication status changes.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class UserWatcher : IUserWatcher
  {
    /// <summary>Gets the status of a user watcher.</summary>
    /// <returns>The status of the user watcher.</returns>
    public extern UserWatcherStatus Status { [MethodImpl] get; }

    /// <summary>Starts the user watcher.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops the user watcher.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>Fires when a user is added to the collection of users returned by User.FindAllAsync.</summary>
    public extern event TypedEventHandler<UserWatcher, UserChangedEventArgs> Added;

    /// <summary>Fires when a user is removed from the collection of users returned by User.FindAllAsync.</summary>
    public extern event TypedEventHandler<UserWatcher, UserChangedEventArgs> Removed;

    /// <summary>Fires when the data associated with a user has changed.</summary>
    public extern event TypedEventHandler<UserWatcher, UserChangedEventArgs> Updated;

    /// <summary>Fires when a user's authentication status has changed.</summary>
    public extern event TypedEventHandler<UserWatcher, UserChangedEventArgs> AuthenticationStatusChanged;

    /// <summary>Fires when a user's authentication status is about to change.</summary>
    public extern event TypedEventHandler<UserWatcher, UserAuthenticationStatusChangingEventArgs> AuthenticationStatusChanging;

    /// <summary>Fires when the initial pass of watcher events has been processed and the collection of users is complete.</summary>
    public extern event TypedEventHandler<UserWatcher, object> EnumerationCompleted;

    /// <summary>Fires when the user watcher has stopped.</summary>
    public extern event TypedEventHandler<UserWatcher, object> Stopped;
  }
}
