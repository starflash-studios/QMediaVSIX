// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Represents a chat message.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ChatMessage : 
    IChatMessage,
    IChatMessage2,
    IChatMessage3,
    IChatMessage4,
    IChatItem
  {
    /// <summary>Creates a new instance of the ChatMessage class.</summary>
    [MethodImpl]
    public extern ChatMessage();

    /// <summary>Gets a list of chat message attachments.</summary>
    /// <returns>A list of chat message attachments.</returns>
    public extern IVector<ChatMessageAttachment> Attachments { [MethodImpl] get; }

    /// <summary>Gets or sets the body of the chat message.</summary>
    /// <returns>The body of the chat message.</returns>
    public extern string Body { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the identifier or address of the sender of the message.</summary>
    /// <returns>The sender of the message.</returns>
    public extern string From { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the identifier of the message.</summary>
    /// <returns>The ID of the chat message.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating if forwarding is disabled.</summary>
    /// <returns>A Boolean value indicating if forwarding is disabled.</returns>
    public extern bool IsForwardingDisabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets Boolean a value indicating if the message is incoming or outgoing.</summary>
    /// <returns>A Boolean value indicating if the message is incoming or outgoing. TRUE indicates incoming, FALSE indicates outgoing.</returns>
    public extern bool IsIncoming { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a Boolean value indicating if the message has been read.</summary>
    /// <returns>A Boolean value indicating if the message has been read.</returns>
    public extern bool IsRead { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the local timestamp of the message.</summary>
    /// <returns>The local timestamp of the message.</returns>
    public extern DateTime LocalTimestamp { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the network timestamp of the message.</summary>
    /// <returns>The network timestamp of the message.</returns>
    public extern DateTime NetworkTimestamp { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the list of recipients of the message.</summary>
    /// <returns>The list of recipients of the message.</returns>
    public extern IVector<string> Recipients { [MethodImpl] get; }

    /// <summary>Gets the list of send statuses for the message.</summary>
    /// <returns>The recipient send statuses.</returns>
    public extern IMapView<string, ChatMessageStatus> RecipientSendStatuses { [MethodImpl] get; }

    /// <summary>Gets the status of the message. Typical states include draft, sent, received, deleted, etc.</summary>
    /// <returns>The status of the message.</returns>
    public extern ChatMessageStatus Status { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the subject of the message.</summary>
    /// <returns>The subject of the message.</returns>
    public extern string Subject { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the transport friendly name of the message.</summary>
    /// <returns>The transport friendly name of the message.</returns>
    public extern string TransportFriendlyName { [MethodImpl] get; }

    /// <summary>Gets or sets the transport ID of the message.</summary>
    /// <returns>The transport ID of the message.</returns>
    public extern string TransportId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the estimated size of a file to be sent or received.</summary>
    /// <returns>The estimated size of a file to be sent or received.</returns>
    public extern ulong EstimatedDownloadSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating if the message is an auto-reply.</summary>
    /// <returns>A Boolean value indicating if the message is an auto-reply.</returns>
    public extern bool IsAutoReply { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a Boolean value indicating if reply is disabled on the ChatMessage.</summary>
    /// <returns>A Boolean value indicating if reply is disabled on the ChatMessage.</returns>
    public extern bool IsReplyDisabled { [MethodImpl] get; }

    /// <summary>Gets or sets a Boolean value indicating if the message has been seen.</summary>
    /// <returns>A Boolean value indicating if the message has been seen.</returns>
    public extern bool IsSeen { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a Boolean value indicating if the message is stored on a SIM card.</summary>
    /// <returns>A Boolean value indicating if the message is stored on a SIM card.</returns>
    public extern bool IsSimMessage { [MethodImpl] get; }

    /// <summary>Gets or sets the type of the ChatMessage.</summary>
    /// <returns>The type of message.</returns>
    public extern ChatMessageKind MessageKind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating the type of message operator, such as SMS, MMS, or RCS.</summary>
    /// <returns>The type of message operator.</returns>
    public extern ChatMessageOperatorKind MessageOperatorKind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating if the message was received during user specified quiet hours.</summary>
    /// <returns>A Boolean value indicating if the message was received during user specified quiet hours.</returns>
    public extern bool IsReceivedDuringQuietHours { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the remote ID for the ChatMessage.</summary>
    /// <returns>The remote ID for the ChatMessage.</returns>
    public extern string RemoteId { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a Boolean value indicating if notification of receiving the ChatMessage should be suppressed.</summary>
    /// <returns>A Boolean value indicating if notification of receiving the ChatMessage should be suppressed.</returns>
    public extern bool ShouldSuppressNotification { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the conversation threading info for the ChatMessage.</summary>
    /// <returns>The conversation threading info for the ChatMessage.</returns>
    public extern ChatConversationThreadingInfo ThreadingInfo { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the delivery info for each of the recipients of the ChatMessage.</summary>
    /// <returns>The delivery info for the recipients of the ChatMessage.</returns>
    public extern IVector<ChatRecipientDeliveryInfo> RecipientsDeliveryInfos { [MethodImpl] get; }

    /// <summary>The ID used to identify a message across devices. This ID is generated on creation for all messages. Clients that copy messages between devices also need to copy this ID in order to uniquely identify the same message on different devices</summary>
    /// <returns>Gets and sets the sync ID.</returns>
    public extern string SyncId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the item kind.</summary>
    /// <returns>The item kind.</returns>
    public extern ChatItemKind ItemKind { [MethodImpl] get; }
  }
}
