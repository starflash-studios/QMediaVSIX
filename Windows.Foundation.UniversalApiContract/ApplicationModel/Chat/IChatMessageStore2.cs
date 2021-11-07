// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageStore2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ChatMessageStore))]
  [Guid(2907555054, 15060, 18715, 179, 17, 171, 223, 155, 178, 39, 104)]
  internal interface IChatMessageStore2 : IChatMessageStore
  {
    [RemoteAsync]
    IAsyncOperation<ChatMessage> ForwardMessageAsync(
      string localChatMessageId,
      IIterable<string> addresses);

    [Overload("GetConversationAsync")]
    [RemoteAsync]
    IAsyncOperation<ChatConversation> GetConversationAsync(
      string conversationId);

    [RemoteAsync]
    [Overload("GetConversationForTransportsAsync")]
    IAsyncOperation<ChatConversation> GetConversationAsync(
      string conversationId,
      IIterable<string> transportIds);

    IAsyncOperation<ChatConversation> GetConversationFromThreadingInfoAsync(
      ChatConversationThreadingInfo threadingInfo);

    [Overload("GetConversationReader")]
    ChatConversationReader GetConversationReader();

    [Overload("GetConversationForTransportsReader")]
    ChatConversationReader GetConversationReader(
      IIterable<string> transportIds);

    [RemoteAsync]
    IAsyncOperation<ChatMessage> GetMessageByRemoteIdAsync(
      string transportId,
      string remoteId);

    [RemoteAsync]
    [Overload("GetUnseenCountAsync")]
    IAsyncOperation<int> GetUnseenCountAsync();

    [Overload("GetUnseenCountForTransportsReaderAsync")]
    IAsyncOperation<int> GetUnseenCountAsync(IIterable<string> transportIds);

    [Overload("MarkAsSeenAsync")]
    [RemoteAsync]
    IAsyncAction MarkAsSeenAsync();

    [Overload("MarkAsSeenForTransportsAsync")]
    IAsyncAction MarkAsSeenAsync(IIterable<string> transportIds);

    ChatSearchReader GetSearchReader(ChatQueryOptions value);

    IAsyncAction SaveMessageAsync(ChatMessage chatMessage);

    [RemoteAsync]
    IAsyncOperation<bool> TryCancelDownloadMessageAsync(string localChatMessageId);

    [RemoteAsync]
    IAsyncOperation<bool> TryCancelSendMessageAsync(string localChatMessageId);

    event TypedEventHandler<ChatMessageStore, ChatMessageStoreChangedEventArgs> StoreChanged;
  }
}
