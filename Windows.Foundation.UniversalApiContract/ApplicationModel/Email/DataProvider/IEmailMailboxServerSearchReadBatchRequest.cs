// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxServerSearchReadBatchRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (EmailMailboxServerSearchReadBatchRequest))]
  [Guid(151972831, 23190, 16851, 138, 216, 52, 145, 47, 154, 166, 14)]
  internal interface IEmailMailboxServerSearchReadBatchRequest
  {
    string SessionId { get; }

    string EmailMailboxId { get; }

    string EmailFolderId { get; }

    EmailQueryOptions Options { get; }

    uint SuggestedBatchSize { get; }

    [RemoteAsync]
    IAsyncAction SaveMessageAsync(EmailMessage message);

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync(EmailBatchStatus batchStatus);
  }
}
