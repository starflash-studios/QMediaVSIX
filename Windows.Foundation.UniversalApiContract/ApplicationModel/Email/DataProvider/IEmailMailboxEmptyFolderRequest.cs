// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxEmptyFolderRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ExclusiveTo(typeof (EmailMailboxEmptyFolderRequest))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4266329003, 63597, 18137, 180, 206, 188, 138, 109, 158, 146, 104)]
  internal interface IEmailMailboxEmptyFolderRequest
  {
    string EmailMailboxId { get; }

    string EmailFolderId { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync(EmailMailboxEmptyFolderStatus status);
  }
}
