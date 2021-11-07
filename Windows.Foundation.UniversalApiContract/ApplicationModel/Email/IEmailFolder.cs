// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailFolder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(2723116913, 39276, 18532, 177, 186, 237, 18, 64, 229, 125, 17)]
  [ExclusiveTo(typeof (EmailFolder))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailFolder
  {
    string Id { get; }

    string RemoteId { get; set; }

    string MailboxId { get; }

    string ParentFolderId { get; }

    string DisplayName { get; set; }

    bool IsSyncEnabled { get; set; }

    DateTime LastSuccessfulSyncTime { get; set; }

    EmailSpecialFolderKind Kind { get; }

    [RemoteAsync]
    IAsyncOperation<EmailFolder> CreateFolderAsync(string name);

    [RemoteAsync]
    IAsyncAction DeleteAsync();

    [RemoteAsync]
    IAsyncOperation<IVectorView<EmailFolder>> FindChildFoldersAsync();

    [Overload("GetConversationReader")]
    EmailConversationReader GetConversationReader();

    [Overload("GetConversationReaderWithOptions")]
    EmailConversationReader GetConversationReader(EmailQueryOptions options);

    [RemoteAsync]
    IAsyncOperation<EmailMessage> GetMessageAsync(string id);

    [Overload("GetMessageReader")]
    EmailMessageReader GetMessageReader();

    [Overload("GetMessageReaderWithOptions")]
    EmailMessageReader GetMessageReader(EmailQueryOptions options);

    [RemoteAsync]
    IAsyncOperation<EmailItemCounts> GetMessageCountsAsync();

    [Overload("TryMoveAsync")]
    IAsyncOperation<bool> TryMoveAsync(EmailFolder newParentFolder);

    [Overload("TryMoveWithNewNameAsync")]
    IAsyncOperation<bool> TryMoveAsync(
      EmailFolder newParentFolder,
      string newFolderName);

    [RemoteAsync]
    IAsyncOperation<bool> TrySaveAsync();

    IAsyncAction SaveMessageAsync(EmailMessage message);
  }
}
