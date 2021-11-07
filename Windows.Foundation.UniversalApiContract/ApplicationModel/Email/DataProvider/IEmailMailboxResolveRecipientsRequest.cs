// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxResolveRecipientsRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (EmailMailboxResolveRecipientsRequest))]
  [Guid(4020555632, 31545, 19611, 129, 30, 65, 234, 244, 58, 51, 45)]
  internal interface IEmailMailboxResolveRecipientsRequest
  {
    string EmailMailboxId { get; }

    IVectorView<string> Recipients { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync(
      IIterable<EmailRecipientResolutionResult> resolutionResults);

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
