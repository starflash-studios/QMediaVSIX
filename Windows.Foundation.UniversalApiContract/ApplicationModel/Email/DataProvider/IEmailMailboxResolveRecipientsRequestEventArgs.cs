// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxResolveRecipientsRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [Guid(638557698, 45775, 16632, 140, 40, 227, 237, 67, 177, 232, 154)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (EmailMailboxResolveRecipientsRequestEventArgs))]
  internal interface IEmailMailboxResolveRecipientsRequestEventArgs
  {
    EmailMailboxResolveRecipientsRequest Request { get; }

    Deferral GetDeferral();
  }
}
