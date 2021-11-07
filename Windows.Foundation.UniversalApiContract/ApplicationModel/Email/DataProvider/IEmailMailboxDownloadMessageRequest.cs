// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxDownloadMessageRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ExclusiveTo(typeof (EmailMailboxDownloadMessageRequest))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1232814471, 23373, 19235, 129, 108, 243, 132, 43, 235, 117, 62)]
  internal interface IEmailMailboxDownloadMessageRequest
  {
    string EmailMailboxId { get; }

    string EmailMessageId { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
