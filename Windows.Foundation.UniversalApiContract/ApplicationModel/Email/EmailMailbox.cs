// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailbox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Represents an email mailbox located on a remote email server.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class EmailMailbox : 
    IEmailMailbox,
    IEmailMailbox2,
    IEmailMailbox3,
    IEmailMailbox4,
    IEmailMailbox5
  {
    /// <summary>Gets the capabilities associated with the mailbox.</summary>
    /// <returns>The capabilities associated with the mailbox.</returns>
    public extern EmailMailboxCapabilities Capabilities { [MethodImpl] get; }

    /// <summary>Gets the EmailMailboxChangeTracker for this mailbox.</summary>
    /// <returns>The change tracker for this mailbox.</returns>
    public extern EmailMailboxChangeTracker ChangeTracker { [MethodImpl] get; }

    /// <summary>Gets or sets the name for this mailbox that is suitable for displaying.</summary>
    /// <returns>The name for this mailbox that is suitable for displaying.</returns>
    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the ID for this mailbox.</summary>
    /// <returns>The ID for this mailbox.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets a Boolean value that indicates if this mailbox is owned by the current app.</summary>
    /// <returns>Boolean value that indicates if this mailbox is owned by the current app.</returns>
    public extern bool IsOwnedByCurrentApp { [MethodImpl] get; }

    /// <summary>Gets a Boolean value that indicates if email data is encrypted when the device is locked.</summary>
    /// <returns>Boolean value that indicates if email data is encrypted when the device is locked.</returns>
    public extern bool IsDataEncryptedUnderLock { [MethodImpl] get; }

    /// <summary>Gets or sets the email address for the mailbox.</summary>
    /// <returns>The email address for the mailbox.</returns>
    public extern string MailAddress { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the list of email aliases associated with this mailbox.</summary>
    /// <returns>The list of email aliases associated with this mailbox.</returns>
    public extern IVector<string> MailAddressAliases { [MethodImpl] get; }

    /// <summary>Gets or sets the read access level to this mailbox for other apps.</summary>
    /// <returns>The read access level to this mailbox for other apps.</returns>
    public extern EmailMailboxOtherAppReadAccess OtherAppReadAccess { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the write access level to this mailbox for other apps.</summary>
    /// <returns>The write access level to this mailbox for other apps.</returns>
    public extern EmailMailboxOtherAppWriteAccess OtherAppWriteAccess { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the security policies for attachments in this mailbox.</summary>
    /// <returns>The security policies for attachments in this mailbox.</returns>
    public extern EmailMailboxPolicies Policies { [MethodImpl] get; }

    /// <summary>Gets the display name of the source mailbox.</summary>
    /// <returns>The display name of the source mailbox.</returns>
    public extern string SourceDisplayName { [MethodImpl] get; }

    /// <summary>Gets the sync manager for the mailbox.</summary>
    /// <returns>The sync manager for the mailbox.</returns>
    public extern EmailMailboxSyncManager SyncManager { [MethodImpl] get; }

    /// <summary>Gets the ID of the user data account for the mailbox.</summary>
    /// <returns>The ID of the user data account for the mailbox.</returns>
    public extern string UserDataAccountId { [MethodImpl] get; }

    /// <summary>Gets or creates an email conversation reader for this mailbox if one does not already exist.</summary>
    /// <returns>The email conversation reader.</returns>
    [Overload("GetConversationReader")]
    [MethodImpl]
    public extern EmailConversationReader GetConversationReader();

    /// <summary>Gets or creates an email conversation reader for this mailbox using the specified query options.</summary>
    /// <param name="options">The email query options to use when creating the conversation reader.</param>
    /// <returns>The new or existing conversation reader.</returns>
    [Overload("GetConversationReaderWithOptions")]
    [MethodImpl]
    public extern EmailConversationReader GetConversationReader(
      EmailQueryOptions options);

    /// <summary>Gets or creates an email message reader for this mailbox if one does not already exist.</summary>
    /// <returns>The new or existing email message reader.</returns>
    [Overload("GetMessageReader")]
    [MethodImpl]
    public extern EmailMessageReader GetMessageReader();

    /// <summary>Gets or creates an email conversation reader for this mailbox using the specified query options.</summary>
    /// <param name="options">The email query options to use when creating the message reader.</param>
    /// <returns>The new or existing email message reader.</returns>
    [Overload("GetMessageReaderWithOptions")]
    [MethodImpl]
    public extern EmailMessageReader GetMessageReader(EmailQueryOptions options);

    /// <summary>Asynchronously deletes the mailbox.</summary>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    /// <summary>Asynchronously gets the specified email conversation.</summary>
    /// <param name="id">The ID of the email conversation to retrieve.</param>
    /// <returns>Returns the email conversation specified by the *id* parameter.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailConversation> GetConversationAsync(
      string id);

    /// <summary>Asynchronously gets the specified email folder.</summary>
    /// <param name="id">The ID of the folder to retrieve.</param>
    /// <returns>The email folder specified in the *id* parameter.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailFolder> GetFolderAsync(string id);

    /// <summary>Asynchronously gets the specified email message.</summary>
    /// <param name="id">The ID of the message to retrieve.</param>
    /// <returns>The email message specified in the *id* parameter.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailMessage> GetMessageAsync(string id);

    /// <summary>Asynchronously get a special email folder such as Inbox, Outbox, Drafts and so on.</summary>
    /// <param name="folderType">The type of folder to retrieve.</param>
    /// <returns>The matching special email folder in this mailbox.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailFolder> GetSpecialFolderAsync(
      EmailSpecialFolderKind folderType);

    /// <summary>Asynchronously saves the mailbox to the email store.</summary>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveAsync();

    /// <summary>Asynchronously marks an email message as seen.</summary>
    /// <param name="messageId">The ID of the message to mark as seen.</param>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MarkMessageAsSeenAsync(string messageId);

    /// <summary>Asynchronously marks all the messages in a folder as seen.</summary>
    /// <param name="folderId">The ID of the folder to mark as seen.</param>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MarkFolderAsSeenAsync(string folderId);

    /// <summary>Asynchronously marks an email message as read or unread.</summary>
    /// <param name="messageId">The ID of the message to mark.</param>
    /// <param name="isRead">True to mark the message as read, false to mark it as unread.</param>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MarkMessageReadAsync(string messageId, bool isRead);

    /// <summary>Asynchronously changes the flag state of an email message.</summary>
    /// <param name="messageId">The ID of the email message to change.</param>
    /// <param name="flagState">The new email flag state.</param>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ChangeMessageFlagStateAsync(
      string messageId,
      EmailFlagState flagState);

    /// <summary>Asynchronously attempts to move the specified email message.</summary>
    /// <param name="messageId">The ID of the email message to move.</param>
    /// <param name="newParentFolderId">The ID of the new folder where the email message should reside.</param>
    /// <returns>A Boolean value indicating if the move was successful.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryMoveMessageAsync(
      string messageId,
      string newParentFolderId);

    /// <summary>Asynchronously attempts to move the specified email folder.</summary>
    /// <param name="folderId">The folder to move.</param>
    /// <param name="newParentFolderId">The new parent for the folder specified in the *folderId* parameter.</param>
    /// <returns>A Boolean value indicating if the move was successful.</returns>
    [RemoteAsync]
    [Overload("TryMoveFolderAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryMoveFolderAsync(
      string folderId,
      string newParentFolderId);

    /// <summary>Asynchronously attempts to move the specified email folder and rename it in the process.</summary>
    /// <param name="folderId">The folder to move.</param>
    /// <param name="newParentFolderId">The new parent for the folder specified in the *folderId* parameter.</param>
    /// <param name="newFolderName">The name for the folder in the new location.</param>
    /// <returns>A Boolean value indicating if the move was successful.</returns>
    [RemoteAsync]
    [Overload("TryMoveFolderWithNewNameAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryMoveFolderAsync(
      string folderId,
      string newParentFolderId,
      string newFolderName);

    /// <summary>Asynchronously deletes an email message from the mailbox.</summary>
    /// <param name="messageId">The ID of the email message to delete.</param>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteMessageAsync(string messageId);

    /// <summary>Asynchronously marks a folder as sync enabled or disabled.</summary>
    /// <param name="folderId">The ID of the folder to mark.</param>
    /// <param name="isSyncEnabled">True to enable to syncing with the server, false to disable syncing.</param>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MarkFolderSyncEnabledAsync(
      string folderId,
      bool isSyncEnabled);

    /// <summary>Asynchronously sends the specified email message.</summary>
    /// <param name="message">The email message to send.</param>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [Overload("SendMessageAsync")]
    [MethodImpl]
    public extern IAsyncAction SendMessageAsync(EmailMessage message);

    /// <summary>Asynchronously saves a draft email message.</summary>
    /// <param name="message">The draft email message to save.</param>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [MethodImpl]
    public extern IAsyncAction SaveDraftAsync(EmailMessage message);

    /// <summary>Asynchronously downloads the specified email message.</summary>
    /// <param name="messageId">The ID of the message to download.</param>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DownloadMessageAsync(string messageId);

    /// <summary>Asynchronously downloads an email attachment.</summary>
    /// <param name="attachmentId">The ID of the attachment to download.</param>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DownloadAttachmentAsync(string attachmentId);

    /// <summary>Creates a new response email such as Reply, Reply All, Forward, and so on.</summary>
    /// <param name="messageId">The ID of the message to which to respond.</param>
    /// <param name="responseType">The type of response such as Reply, Reply All, Forward, and so on.</param>
    /// <param name="subject">The subject for the response message.</param>
    /// <param name="responseHeaderType">The format of the email body such as plain text or HTML.</param>
    /// <param name="responseHeader">The header for the response message.</param>
    /// <returns>The newly created response email message.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailMessage> CreateResponseMessageAsync(
      string messageId,
      EmailMessageResponseKind responseType,
      string subject,
      EmailMessageBodyKind responseHeaderType,
      string responseHeader);

    /// <summary>Asynchronously attempts to respond to a meeting request.</summary>
    /// <param name="meeting">The meeting request.</param>
    /// <param name="response">The response to the meeting request, accept, decline, or tentative.</param>
    /// <param name="subject">The subject of the response email message.</param>
    /// <param name="comment">The body of the response email message.</param>
    /// <param name="sendUpdate">A Boolean indicating whether or not to send a response to the meeting originator.</param>
    /// <returns>A Boolean value indicating if the response was sent successfully.</returns>
    [MethodImpl]
    public extern IAsyncOperation<bool> TryUpdateMeetingResponseAsync(
      EmailMessage meeting,
      EmailMeetingResponseType response,
      string subject,
      string comment,
      bool sendUpdate);

    [MethodImpl]
    public extern IAsyncOperation<bool> TryForwardMeetingAsync(
      EmailMessage meeting,
      IIterable<EmailRecipient> recipients,
      string subject,
      EmailMessageBodyKind forwardHeaderType,
      string forwardHeader,
      string comment);

    [MethodImpl]
    public extern IAsyncOperation<bool> TryProposeNewTimeForMeetingAsync(
      EmailMessage meeting,
      DateTime newStartTime,
      TimeSpan newDuration,
      string subject,
      string comment);

    /// <summary>Occurs when the mailbox has changed.</summary>
    public extern event TypedEventHandler<EmailMailbox, EmailMailboxChangedEventArgs> MailboxChanged;

    /// <summary>Asynchronously sends the specified email message.</summary>
    /// <param name="message">The email message to send.</param>
    /// <param name="smartSend">True to send only the updated text, false to include the full message thread.</param>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [Overload("SmartSendMessageAsync")]
    [MethodImpl]
    public extern IAsyncAction SendMessageAsync(EmailMessage message, bool smartSend);

    /// <summary>Asynchronously attempts to set the auto-reply settings for the mailbox.</summary>
    /// <param name="autoReplySettings">The new auto-reply settings.</param>
    /// <returns>A Boolean value indicating if the operation was successful.</returns>
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetAutoReplySettingsAsync(
      EmailMailboxAutoReplySettings autoReplySettings);

    /// <summary>Asynchronously attempts to get the auto-reply settings for the mailbox.</summary>
    /// <param name="requestedFormat">The requested text format of the auto-reply message, HTML or plain text.</param>
    /// <returns>The auto-reply settings.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailMailboxAutoReplySettings> TryGetAutoReplySettingsAsync(
      EmailMailboxAutoReplyMessageResponseKind requestedFormat);

    /// <summary>Gets the identifier for a mailbox linked to this one.</summary>
    /// <returns>The identifier for a mailbox linked to this one.</returns>
    public extern string LinkedMailboxId { [MethodImpl] get; }

    /// <summary>Gets the identifier of the email mailbox account within its network.</summary>
    /// <returns>The identifier of the email mailbox account within its network.</returns>
    public extern string NetworkAccountId { [MethodImpl] get; }

    /// <summary>Gets the identifier of the network associated with this email mailbox.</summary>
    /// <returns>The identifier of the network associated with this email mailbox.</returns>
    public extern string NetworkId { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<EmailRecipientResolutionResult>> ResolveRecipientsAsync(
      IIterable<string> recipients);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<EmailCertificateValidationStatus>> ValidateCertificatesAsync(
      IIterable<Certificate> certificates);

    /// <summary>Asynchronously attempt to delete the contents of an email folder.</summary>
    /// <param name="folderId">The Id of the folder to empty.</param>
    /// <returns>An async operation with an EmailMailboxEmptyFolderStatus value representing the status of the delete operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailMailboxEmptyFolderStatus> TryEmptyFolderAsync(
      string folderId);

    /// <summary>Asynchronously attempts to create a new email folder.</summary>
    /// <param name="parentFolderId">The Id of the parent email folder.</param>
    /// <param name="name">The name for the new folder.</param>
    /// <returns>An async operation with an EmailMailboxCreateFolderResult containing the newly created folder and the status of the create operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailMailboxCreateFolderResult> TryCreateFolderAsync(
      string parentFolderId,
      string name);

    /// <summary>Asynchronously attempts to delete an email folder.</summary>
    /// <param name="folderId">The Id of the folder to delete.</param>
    /// <returns>An async operation with an EmailMailboxDeleteFolderStatus value representing the status of the delete operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailMailboxDeleteFolderStatus> TryDeleteFolderAsync(
      string folderId);

    /// <summary>Asynchronously registers this mailbox as a sync provider.</summary>
    /// <returns>An asynchronous registration operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RegisterSyncManagerAsync();

    /// <summary>Gets a EmailMailboxChangeTracker that provides functionality for monitoring changes to items in the EmailMailbox.</summary>
    /// <param name="identity">A string that identifies the EmailMailboxChangeTracker instance in the EmailMailbox.</param>
    /// <returns>A EmailMailboxChangeTracker that provides functionality for monitoring changes to items in the EmailMailbox.</returns>
    [MethodImpl]
    public extern EmailMailboxChangeTracker GetChangeTracker(
      string identity);
  }
}
