// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxValidateCertificatesRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [Guid(2840410417, 57626, 20375, 184, 26, 24, 122, 112, 168, 244, 26)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (EmailMailboxValidateCertificatesRequest))]
  internal interface IEmailMailboxValidateCertificatesRequest
  {
    string EmailMailboxId { get; }

    IVectorView<Certificate> Certificates { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync(
      IIterable<EmailCertificateValidationStatus> validationStatuses);

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
