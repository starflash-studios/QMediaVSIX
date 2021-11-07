// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatConversation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (ChatConversation))]
  [Guid(2777417741, 6767, 18140, 143, 61, 245, 2, 134, 96, 182, 238)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IChatConversation
  {
    bool HasUnreadMessages { get; }

    string Id { get; }

    string Subject { get; set; }

    bool IsConversationMuted { get; set; }

    string MostRecentMessageId { get; }

    IVector<string> Participants { get; }

    ChatConversationThreadingInfo ThreadingInfo { get; }

    [RemoteAsync]
    IAsyncAction DeleteAsync();

    ChatMessageReader GetMessageReader();

    [Overload("MarkAllMessagesAsReadAsync")]
    [RemoteAsync]
    IAsyncAction MarkMessagesAsReadAsync();

    [Overload("MarkMessagesAsReadAsync")]
    [RemoteAsync]
    IAsyncAction MarkMessagesAsReadAsync(DateTime value);

    [RemoteAsync]
    IAsyncAction SaveAsync();

    void NotifyLocalParticipantComposing(
      string transportId,
      string participantAddress,
      bool isComposing);

    void NotifyRemoteParticipantComposing(
      string transportId,
      string participantAddress,
      bool isComposing);

    event TypedEventHandler<ChatConversation, RemoteParticipantComposingChangedEventArgs> RemoteParticipantComposingChanged;
  }
}
