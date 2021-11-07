// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxForwardMeetingRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ExclusiveTo(typeof (EmailMailboxForwardMeetingRequest))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1634560753, 28884, 18482, 184, 105, 184, 5, 66, 174, 155, 232)]
  internal interface IEmailMailboxForwardMeetingRequest
  {
    string EmailMailboxId { get; }

    string EmailMessageId { get; }

    IVectorView<EmailRecipient> Recipients { get; }

    string Subject { get; }

    EmailMessageBodyKind ForwardHeaderType { get; }

    string ForwardHeader { get; }

    string Comment { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
