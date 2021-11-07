// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxGetAutoReplySettingsRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2604140425, 7816, 19969, 132, 204, 19, 134, 173, 154, 44, 47)]
  [ExclusiveTo(typeof (EmailMailboxGetAutoReplySettingsRequest))]
  internal interface IEmailMailboxGetAutoReplySettingsRequest
  {
    string EmailMailboxId { get; }

    EmailMailboxAutoReplyMessageResponseKind RequestedFormat { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync(EmailMailboxAutoReplySettings autoReplySettings);

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
