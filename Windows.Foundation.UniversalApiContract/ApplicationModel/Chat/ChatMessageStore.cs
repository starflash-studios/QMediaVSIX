// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Provides the methods and properties to read, manage and send messages. An application gets access to the message store using the static ChatMessageManager class.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class ChatMessageStore : IChatMessageStore, IChatMessageStore2, IChatMessageStore3
  {
    /// <summary>Gets a ChatMessageChangeTracker class object for the message store. A message change tracker allows an application to monitor changes to messages in the message store.</summary>
    /// <returns>The chat message change tracker for the store.</returns>
    public extern ChatMessageChangeTracker ChangeTracker { [MethodImpl] get; }

    /// <summary>Deletes a message from the chat message store.</summary>
    /// <param name="localMessageId">The local ID of the message to be deleted.</param>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteMessageAsync(string localMessageId);

    /// <summary>Downloads a message specified by the identifier to the message store.</summary>
    /// <param name="localChatMessageId">The local ID of the message to be downloaded.</param>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DownloadMessageAsync(string localChatMessageId);

    /// <summary>Retrieves a message specified by an identifier from the message store.</summary>
    /// <param name="localChatMessageId">The local ID of the chat message to be retrieved.</param>
    /// <returns>An asynchronous operation that returns a chat message upon successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ChatMessage> GetMessageAsync(
      string localChatMessageId);

    /// <summary>Gets a ChatMessageReader class object which provides a message collection from the message store.</summary>
    /// <returns>The chat message reader.</returns>
    [Overload("GetMessageReader1")]
    [MethodImpl]
    public extern ChatMessageReader GetMessageReader();

    [Overload("GetMessageReader2")]
    [MethodImpl]
    public extern ChatMessageReader GetMessageReader(TimeSpan recentTimeLimit);

    /// <summary>Marks a specified message in the store as already read.</summary>
    /// <param name="localChatMessageId">The local ID of the message to be marked as read.</param>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MarkMessageReadAsync(string localChatMessageId);

    /// <summary>Attempts a retry of sending a specified message from the message store.</summary>
    /// <param name="localChatMessageId">The local ID of the message to be retried.</param>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RetrySendMessageAsync(string localChatMessageId);

    /// <summary>Attempts to send a chat message. The message is saved to the message store as part of the send operation.</summary>
    /// <param name="chatMessage">The chat message to be sent.</param>
    /// <returns>An asynchronous action.</returns>
    [MethodImpl]
    public extern IAsyncAction SendMessageAsync(ChatMessage chatMessage);

    /// <summary>Checks if a chat message is valid and returns the validation result.</summary>
    /// <param name="chatMessage">The chat message to validate.</param>
    /// <returns>The validation result.</returns>
    [MethodImpl]
    public extern ChatMessageValidationResult ValidateMessage(
      ChatMessage chatMessage);

    /// <summary>An event that occurs when a message in the message store is changed.</summary>
    public extern event TypedEventHandler<ChatMessageStore, ChatMessageChangedEventArgs> MessageChanged;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ChatMessage> ForwardMessageAsync(
      string localChatMessageId,
      IIterable<string> addresses);

    /// <summary>Asynchronously gets a ChatConversation by ID.</summary>
    /// <param name="conversationId">The ID of the conversation to retrieve.</param>
    /// <returns>The ChatConversation specified by the *conversationId* parameter.</returns>
    [RemoteAsync]
    [Overload("GetConversationAsync")]
    [MethodImpl]
    public extern IAsyncOperation<ChatConversation> GetConversationAsync(
      string conversationId);

    [Overload("GetConversationForTransportsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ChatConversation> GetConversationAsync(
      string conversationId,
      IIterable<string> transportIds);

    /// <summary>Asynchronously gets a conversation based on a threading info object.</summary>
    /// <param name="threadingInfo">The threading info that identifies the conversation.</param>
    /// <returns>The conversation identified by the *threadingInfo* parameter.</returns>
    [MethodImpl]
    public extern IAsyncOperation<ChatConversation> GetConversationFromThreadingInfoAsync(
      ChatConversationThreadingInfo threadingInfo);

    /// <summary>Gets a new or existing ChatConversationReader for the message store.</summary>
    /// <returns>The new or existing ChatConversationReader.</returns>
    [Overload("GetConversationReader")]
    [MethodImpl]
    public extern ChatConversationReader GetConversationReader();

    [Overload("GetConversationForTransportsReader")]
    [MethodImpl]
    public extern ChatConversationReader GetConversationReader(
      IIterable<string> transportIds);

    /// <summary>Gets a message by its remote ID.</summary>
    /// <param name="transportId">The TransportId to use to get the ChatMessage.</param>
    /// <param name="remoteId">The RemoteId of the ChatMessage to retrieve.</param>
    /// <returns>The message.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ChatMessage> GetMessageByRemoteIdAsync(
      string transportId,
      string remoteId);

    /// <summary>Asynchronously gets the number of unread chat messages.</summary>
    /// <returns>The number of unread chat messages.</returns>
    [RemoteAsync]
    [Overload("GetUnseenCountAsync")]
    [MethodImpl]
    public extern IAsyncOperation<int> GetUnseenCountAsync();

    [Overload("GetUnseenCountForTransportsReaderAsync")]
    [MethodImpl]
    public extern IAsyncOperation<int> GetUnseenCountAsync(
      IIterable<string> transportIds);

    /// <summary>Asynchronously marks all transport messages as seen.</summary>
    /// <returns>An async action indicating that the operation has finished.</returns>
    [Overload("MarkAsSeenAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MarkAsSeenAsync();

    [Overload("MarkAsSeenForTransportsAsync")]
    [MethodImpl]
    public extern IAsyncAction MarkAsSeenAsync(IIterable<string> transportIds);

    /// <summary>Gets a new or existing ChatSearchReader to be used to search for messages.</summary>
    /// <param name="value">The query options that the search reader will use when looking for matching messages.</param>
    /// <returns>The new or existing search reader.</returns>
    [MethodImpl]
    public extern ChatSearchReader GetSearchReader(ChatQueryOptions value);

    /// <summary>Asynchronously saves a message to the ChatMessageStore.</summary>
    /// <param name="chatMessage">The message to save.</param>
    /// <returns>An async action indicating that the operation has finished.</returns>
    [MethodImpl]
    public extern IAsyncAction SaveMessageAsync(ChatMessage chatMessage);

    /// <summary>Asynchronously attempts to cancel downloading the specified message.</summary>
    /// <param name="localChatMessageId">The ID of the message to stop downloading.</param>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryCancelDownloadMessageAsync(
      string localChatMessageId);

    /// <summary>Asynchronously attempts to cancel sending the specified message.</summary>
    /// <param name="localChatMessageId">The ID of the message to stop sending.</param>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryCancelSendMessageAsync(
      string localChatMessageId);

    /// <summary>Occurs when something in the ChatMessageStore has changed.</summary>
    public extern event TypedEventHandler<ChatMessageStore, ChatMessageStoreChangedEventArgs> StoreChanged;

    /// <summary>Gets a message by the sync ID.</summary>
    /// <param name="syncId">The sync ID of the message.</param>
    /// <returns>When the asynchronous operation completes, a ChatMessage object is returned.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ChatMessage> GetMessageBySyncIdAsync(
      string syncId);
  }
}
