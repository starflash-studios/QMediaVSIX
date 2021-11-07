// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailFolder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Represents an email folder.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EmailFolder : IEmailFolder
  {
    /// <summary>Gets the ID of the email folder.</summary>
    /// <returns>The ID of the email folder.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets or sets the remote ID of the corresponding folder on the server.</summary>
    /// <returns>The remote ID of the corresponding folder on the server.</returns>
    public extern string RemoteId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the ID of the mailbox that contains this folder.</summary>
    /// <returns>The ID of the mailbox that contains this folder.</returns>
    public extern string MailboxId { [MethodImpl] get; }

    /// <summary>Gets the ID of this folder's parent folder.</summary>
    /// <returns>The ID of this folder's parent folder.</returns>
    public extern string ParentFolderId { [MethodImpl] get; }

    /// <summary>Gets or sets the display name for the folder.</summary>
    /// <returns>The display name for the folder.</returns>
    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating if the folder is sync enabled.</summary>
    /// <returns>A Boolean value indicating if the folder is sync enabled.</returns>
    public extern bool IsSyncEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the last time the folder was successfully synced with the server.</summary>
    /// <returns>The last time the folder was successfully synced with the server.</returns>
    public extern DateTime LastSuccessfulSyncTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the type of the folder such as inbox, outbox, drafts, sent, and so on.</summary>
    /// <returns>The type of the folder such as inbox, outbox, drafts, sent, and so on.</returns>
    public extern EmailSpecialFolderKind Kind { [MethodImpl] get; }

    /// <summary>Asynchronously creates a new folder.</summary>
    /// <param name="name">The name for the new folder.</param>
    /// <returns>Returns the newly created folder.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailFolder> CreateFolderAsync(
      string name);

    /// <summary>Asynchronously deletes this folder.</summary>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    /// <summary>Asynchronously finds the child folders of this folder.</summary>
    /// <returns>The list of child folders.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<EmailFolder>> FindChildFoldersAsync();

    /// <summary>Gets an instance of the EmailConversationReader class.</summary>
    /// <returns>The conversation reader.</returns>
    [Overload("GetConversationReader")]
    [MethodImpl]
    public extern EmailConversationReader GetConversationReader();

    /// <summary>Gets an instance of the EmailConversationReader class using the specified query options.</summary>
    /// <param name="options">The query options to use when finding the conversation reader.</param>
    /// <returns>The conversation reader that matches the query options.</returns>
    [Overload("GetConversationReaderWithOptions")]
    [MethodImpl]
    public extern EmailConversationReader GetConversationReader(
      EmailQueryOptions options);

    /// <summary>Asynchronously gets the specified message from the folder.</summary>
    /// <param name="id">The ID of the message to retrieve.</param>
    /// <returns>The message specified in the *id* parameter.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailMessage> GetMessageAsync(string id);

    /// <summary>Gets an instance of the EmailMessageReader class.</summary>
    /// <returns>The message reader.</returns>
    [Overload("GetMessageReader")]
    [MethodImpl]
    public extern EmailMessageReader GetMessageReader();

    /// <summary>Gets an instance of the EmailMessageReader class using the specified query options.</summary>
    /// <param name="options">The query options to use when finding the message reader.</param>
    /// <returns>The message reader that matches the query options.</returns>
    [Overload("GetMessageReaderWithOptions")]
    [MethodImpl]
    public extern EmailMessageReader GetMessageReader(EmailQueryOptions options);

    /// <summary>Asynchronously gets the counts of email items such as flagged emails, important emails, unread emails, total emails, and so on.</summary>
    /// <returns>An EmailItemCounts object containing the counts of email items such as flagged emails, important emails, unread emails, total emails, and so on.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailItemCounts> GetMessageCountsAsync();

    /// <summary>Asynchronously attempts to move this folder to the specified folder.</summary>
    /// <param name="newParentFolder">The new location for this folder.</param>
    /// <returns>A Boolean value indicating if the move was successful.</returns>
    [Overload("TryMoveAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryMoveAsync(EmailFolder newParentFolder);

    /// <summary>Asynchronously attempts to move this folder to the specified folder and rename it in the process.</summary>
    /// <param name="newParentFolder">The new location for this folder.</param>
    /// <param name="newFolderName">The name for the folder in the new location.</param>
    /// <returns>A Boolean value indicating if the move was successful.</returns>
    [Overload("TryMoveWithNewNameAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryMoveAsync(
      EmailFolder newParentFolder,
      string newFolderName);

    /// <summary>Asynchronously attempts to save changes to the folder.</summary>
    /// <returns>A Boolean value indicating if the save was successful.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySaveAsync();

    /// <summary>Asynchronously saves the specified email message to the folder.</summary>
    /// <param name="message">The email message to save.</param>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [MethodImpl]
    public extern IAsyncAction SaveMessageAsync(EmailMessage message);
  }
}
