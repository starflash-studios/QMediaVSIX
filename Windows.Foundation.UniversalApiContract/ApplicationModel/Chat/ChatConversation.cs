// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatConversation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Represents a conversation in a chat client.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class ChatConversation : IChatConversation, IChatConversation2, IChatItem
  {
    /// <summary>Gets a Boolean value indicating if there are unread messages in the ChatConversation.</summary>
    /// <returns>A Boolean value indicating if there are unread messages in the ChatConversation.</returns>
    public extern bool HasUnreadMessages { [MethodImpl] get; }

    /// <summary>Gets the unique identifier for the ChatConversation.</summary>
    /// <returns>The unique identifier for the ChatConversation.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets or sets the subject of a group conversation.</summary>
    /// <returns>The subject of a group conversation.</returns>
    public extern string Subject { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating if the ChatConversation is muted.</summary>
    /// <returns>A Boolean value indicating if the ChatConversation is muted.</returns>
    public extern bool IsConversationMuted { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the ID of the most recent message in the conversation.</summary>
    /// <returns>The ID of the most recent message in the conversation.</returns>
    public extern string MostRecentMessageId { [MethodImpl] get; }

    /// <summary>Gets a list of all the participants in the conversation.</summary>
    /// <returns>A list of all the participants in the conversation.</returns>
    public extern IVector<string> Participants { [MethodImpl] get; }

    /// <summary>Gets the threading info for the ChatConversation.</summary>
    /// <returns>The threading info for the ChatConversation.</returns>
    public extern ChatConversationThreadingInfo ThreadingInfo { [MethodImpl] get; }

    /// <summary>Asynchronously deletes all of the messages in the ChatConversation and the conversation itself.</summary>
    /// <returns>An async action that indicates when the delete has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    /// <summary>Gets the ChatMessageReader for this ChatConversation.</summary>
    /// <returns>The ChatMessageReader for this ChatConversation.</returns>
    [MethodImpl]
    public extern ChatMessageReader GetMessageReader();

    /// <summary>Asynchronously marks all the messages in the conversation as read.</summary>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [Overload("MarkAllMessagesAsReadAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MarkMessagesAsReadAsync();

    [Overload("MarkMessagesAsReadAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MarkMessagesAsReadAsync(DateTime value);

    /// <summary>Asynchronously saves the ChatConversation.</summary>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveAsync();

    /// <summary>Call this to indicate that the local participant has started or has completed typing.</summary>
    /// <param name="transportId">Specifies the ChatMessageTransport to use.</param>
    /// <param name="participantAddress">The address of the remote participant.</param>
    /// <param name="isComposing">TRUE if the local participant is typing, otherwise FALSE.</param>
    [MethodImpl]
    public extern void NotifyLocalParticipantComposing(
      string transportId,
      string participantAddress,
      bool isComposing);

    /// <summary>Locally triggers the event that indicates that a remote participant is typing.</summary>
    /// <param name="transportId">Specifies the ChatMessageTransport to use.</param>
    /// <param name="participantAddress">The address of the remote participant.</param>
    /// <param name="isComposing">TRUE if the remote participant is typing, otherwise FALSE.</param>
    [MethodImpl]
    public extern void NotifyRemoteParticipantComposing(
      string transportId,
      string participantAddress,
      bool isComposing);

    /// <summary>Occurs when the remote user has started or finished typing.</summary>
    public extern event TypedEventHandler<ChatConversation, RemoteParticipantComposingChangedEventArgs> RemoteParticipantComposingChanged;

    /// <summary>Gets or sets a boolean that indicates whether participants can be modified or not.</summary>
    /// <returns>A boolean that indicates whether participants can be modified or not.</returns>
    public extern bool CanModifyParticipants { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the item kind.</summary>
    /// <returns>The item kind.</returns>
    public extern ChatItemKind ItemKind { [MethodImpl] get; }
  }
}
