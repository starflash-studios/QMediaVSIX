// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailbox3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (EmailMailbox))]
  [Guid(1034258811, 17803, 16522, 142, 55, 172, 139, 5, 216, 175, 86)]
  internal interface IEmailMailbox3 : IEmailMailbox2, IEmailMailbox
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<EmailRecipientResolutionResult>> ResolveRecipientsAsync(
      IIterable<string> recipients);

    [RemoteAsync]
    IAsyncOperation<IVectorView<EmailCertificateValidationStatus>> ValidateCertificatesAsync(
      IIterable<Certificate> certificates);

    [RemoteAsync]
    IAsyncOperation<EmailMailboxEmptyFolderStatus> TryEmptyFolderAsync(
      string folderId);

    [RemoteAsync]
    IAsyncOperation<EmailMailboxCreateFolderResult> TryCreateFolderAsync(
      string parentFolderId,
      string name);

    [RemoteAsync]
    IAsyncOperation<EmailMailboxDeleteFolderStatus> TryDeleteFolderAsync(
      string folderId);
  }
}
