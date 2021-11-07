// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (ChatMessageStore))]
  [Guid(838008065, 52470, 22539, 73, 118, 10, 7, 221, 93, 59, 71)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IChatMessageStore
  {
    ChatMessageChangeTracker ChangeTracker { get; }

    [RemoteAsync]
    IAsyncAction DeleteMessageAsync(string localMessageId);

    [RemoteAsync]
    IAsyncAction DownloadMessageAsync(string localChatMessageId);

    [RemoteAsync]
    IAsyncOperation<ChatMessage> GetMessageAsync(string localChatMessageId);

    [Overload("GetMessageReader1")]
    ChatMessageReader GetMessageReader();

    [Overload("GetMessageReader2")]
    ChatMessageReader GetMessageReader(TimeSpan recentTimeLimit);

    [RemoteAsync]
    IAsyncAction MarkMessageReadAsync(string localChatMessageId);

    [RemoteAsync]
    IAsyncAction RetrySendMessageAsync(string localChatMessageId);

    IAsyncAction SendMessageAsync(ChatMessage chatMessage);

    ChatMessageValidationResult ValidateMessage(ChatMessage chatMessage);

    event TypedEventHandler<ChatMessageStore, ChatMessageChangedEventArgs> MessageChanged;
  }
}
