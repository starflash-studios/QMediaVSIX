// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxUpdateMeetingResponseRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ExclusiveTo(typeof (EmailMailboxUpdateMeetingResponseRequest))]
  [Guid(1536797843, 45775, 18568, 186, 79, 48, 107, 107, 102, 223, 48)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEmailMailboxUpdateMeetingResponseRequest
  {
    string EmailMailboxId { get; }

    string EmailMessageId { get; }

    EmailMeetingResponseType Response { get; }

    string Subject { get; }

    string Comment { get; }

    bool SendUpdate { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
