// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxDownloadMessageRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ExclusiveTo(typeof (EmailMailboxDownloadMessageRequestEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1191446957, 53408, 19035, 187, 42, 55, 98, 16, 57, 197, 62)]
  internal interface IEmailMailboxDownloadMessageRequestEventArgs
  {
    EmailMailboxDownloadMessageRequest Request { get; }

    Deferral GetDeferral();
  }
}
