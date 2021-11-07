// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(4111631956, 21957, 18576, 168, 36, 33, 108, 38, 24, 206, 127)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EmailManager))]
  internal interface IEmailManagerStatics
  {
    [RemoteAsync]
    IAsyncAction ShowComposeNewEmailAsync(EmailMessage message);
  }
}
