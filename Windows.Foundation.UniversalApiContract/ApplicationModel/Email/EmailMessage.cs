// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Represents an email message.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class EmailMessage : IEmailMessage, IEmailMessage2, IEmailMessage3, IEmailMessage4
  {
    /// <summary>Creates an instance of the EmailMessage class.</summary>
    [MethodImpl]
    public extern EmailMessage();

    /// <summary>Gets or sets the subject of the email message.</summary>
    /// <returns>The subject of the email.</returns>
    public extern string Subject { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the body of the email message.</summary>
    /// <returns>The body of the email message.</returns>
    public extern string Body { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the direct recipients of the email message.</summary>
    /// <returns>The recipients of the email message.</returns>
    public extern IVector<EmailRecipient> To { [MethodImpl] get; }

    /// <summary>Gets the recipients CC'd to the email message.</summary>
    /// <returns>The recipients CC'd to the email message.</returns>
    public extern IVector<EmailRecipient> CC { [MethodImpl] get; }

    /// <summary>Gets the recipients BCC'd to the email message.</summary>
    /// <returns>The recipients BCC'd to the email message.</returns>
    public extern IVector<EmailRecipient> Bcc { [MethodImpl] get; }

    /// <summary>Gets the attachments of the email message.</summary>
    /// <returns>The attachments to the email message.</returns>
    public extern IVector<EmailAttachment> Attachments { [MethodImpl] get; }

    /// <summary>Gets the identifier of an email message.</summary>
    /// <returns>The identifier of an email message.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets or sets the identifier that can be used by a service provider to access the email message on the client machine.</summary>
    /// <returns>The identifier that can be used by a service provider to access the email message on the client machine.</returns>
    public extern string RemoteId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the identifier of the mailbox.</summary>
    /// <returns>The identifier of the mailbox.</returns>
    public extern string MailboxId { [MethodImpl] get; }

    /// <summary>Gets the identifier for a conversation.</summary>
    /// <returns>The identifier for a conversation.</returns>
    public extern string ConversationId { [MethodImpl] get; }

    /// <summary>Gets the identifier of a folder in the inbox.</summary>
    /// <returns>The identifier of a folder in the inbox.</returns>
    public extern string FolderId { [MethodImpl] get; }

    /// <summary>Gets or sets a Boolean value indicating whether images may be embedded in the html encoded email message.</summary>
    /// <returns>A Boolean value indicating whether images may be embedded in the html encoded email message.</returns>
    public extern bool AllowInternetImages { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the current change number which is incremented for each change made to an email message.</summary>
    /// <returns>The current change number .</returns>
    public extern ulong ChangeNumber { [MethodImpl] get; }

    /// <summary>Gets or sets the download status of an email message.</summary>
    /// <returns>The download status of an email message.</returns>
    public extern EmailMessageDownloadState DownloadState { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the estimated size, in bytes, of an email message download.</summary>
    /// <returns>The estimated size, in bytes, of an email message download.</returns>
    public extern uint EstimatedDownloadSizeInBytes { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Represents the flag status of an email message.</summary>
    /// <returns>The flag status of an email message.</returns>
    public extern EmailFlagState FlagState { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a Boolean value indicating whether this email message contains partial bodies.</summary>
    /// <returns>The Boolean value indicating whether this email message contains partial bodies.</returns>
    public extern bool HasPartialBodies { [MethodImpl] get; }

    /// <summary>Gets the importance of an email message.</summary>
    /// <returns>The importance of an email message.</returns>
    public extern EmailImportance Importance { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the identifier for the email message to which this message is a response.</summary>
    /// <returns>The identifier for the email message to which this message is a response.</returns>
    public extern string InResponseToMessageId { [MethodImpl] get; }

    /// <summary>Gets or sets the Information Rights Management (IRM) information for this email message.</summary>
    /// <returns>The Information Rights Management (IRM) information for this email message.</returns>
    public extern EmailIrmInfo IrmInfo { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a Boolean value indicating whether this message is a draft.</summary>
    /// <returns>A Boolean value indicating whether this message is a draft.</returns>
    public extern bool IsDraftMessage { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating whether the email message has been read.</summary>
    /// <returns>A Boolean value indicating whether the email message has been read.</returns>
    public extern bool IsRead { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a Boolean value indicating whether the email message has been seen.</summary>
    /// <returns>A Boolean value indicating whether the email message has been seen.</returns>
    public extern bool IsSeen { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a Boolean value indicating whether the email message is a temporary server search message.</summary>
    /// <returns>The Boolean value indicating whether the email message is a temporary server search message.</returns>
    public extern bool IsServerSearchMessage { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating whether the response email message is allowed to attempt a smart send, only sending that portion of the email message that has changed.</summary>
    /// <returns>A Boolean value indicating whether the response email message is allowed to attempt a smart send.</returns>
    public extern bool IsSmartSendable { [MethodImpl] get; }

    /// <summary>Gets or sets a string that indicates the class of the message.</summary>
    /// <returns>The string that indicates the class of the message.</returns>
    public extern string MessageClass { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the subject line of an email message stripped of additional prefixes such as fwd: and re:</summary>
    /// <returns>The subject line of an email message stripped of additional prefixes such as fwd: and re:</returns>
    public extern string NormalizedSubject { [MethodImpl] get; }

    /// <summary>Gets or sets the integer that identifies the original flavor of the character set used so that when the email message is condensed from wide character format (16-bit) to ASCII or other 8-bit encoding, in cases of later encoding questions, this integer can be used to recreate the original character set.</summary>
    /// <returns>The integer that identifies the original flavor of the character set used</returns>
    public extern int OriginalCodePage { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the short preview string that represents the longer email message in the list view of emails.</summary>
    /// <returns>The short preview string that represents the longer email message in the list view of emails.</returns>
    public extern string Preview { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the last kind of response sent in reference to this email message.</summary>
    /// <returns>The last kind of response sent in reference to this email message.</returns>
    public extern EmailMessageResponseKind LastResponseKind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the mailbox from which the email message was sent.</summary>
    /// <returns>The mailbox from which the email message was sent.</returns>
    public extern EmailRecipient Sender { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time an email was sent.</summary>
    /// <returns>The time an email was sent.</returns>
    public extern IReference<DateTime> SentTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the information associated with this meeting.</summary>
    /// <returns>The information associated with this meeting.</returns>
    public extern EmailMeetingInfo MeetingInfo { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the requested email stream such as plain text or HTML.</summary>
    /// <param name="type">The kind of message body; plain text or HTML.</param>
    /// <returns>The selected body stream.</returns>
    [MethodImpl]
    public extern IRandomAccessStreamReference GetBodyStream(
      EmailMessageBodyKind type);

    /// <summary>Sets the value of the specified body stream in an email message.</summary>
    /// <param name="type">Indicates which body stream, plain text or HTML.</param>
    /// <param name="stream">The message for the specified body stream.</param>
    [MethodImpl]
    public extern void SetBodyStream(EmailMessageBodyKind type, IRandomAccessStreamReference stream);

    /// <summary>Gets or sets the S/MIME data associated with an email message. For more information, see the Certificate class.</summary>
    /// <returns>The MIME data associated with an email message.</returns>
    public extern IRandomAccessStreamReference SmimeData { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the type of S/MIME encryption/signature for the email message.</summary>
    /// <returns>The type of S/MIME encryption/signature for the email message.</returns>
    public extern EmailMessageSmimeKind SmimeKind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the recipients that are configured to receive a reply to the email message.</summary>
    /// <returns>The recipients that are configured to receive a reply to the email message.</returns>
    public extern IVector<EmailRecipient> ReplyTo { [MethodImpl] get; }

    /// <summary>Gets or sets an object that identifies the name and address of the person sending the message.</summary>
    /// <returns>An object that identifies the name and address of the person sending the message.</returns>
    public extern EmailRecipient SentRepresenting { [MethodImpl] get; [MethodImpl] set; }
  }
}
