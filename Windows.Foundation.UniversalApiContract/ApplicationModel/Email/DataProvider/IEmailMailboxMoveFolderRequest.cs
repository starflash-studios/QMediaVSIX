// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxMoveFolderRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ExclusiveTo(typeof (EmailMailboxMoveFolderRequest))]
  [Guid(280635478, 19093, 16488, 145, 204, 103, 204, 122, 207, 69, 79)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEmailMailboxMoveFolderRequest
  {
    string EmailMailboxId { get; }

    string EmailFolderId { get; }

    string NewParentFolderId { get; }

    string NewFolderName { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
