// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.IWiFiDirectServiceSessionRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect.Services
{
  [ExclusiveTo(typeof (WiFiDirectServiceSessionRequestedEventArgs))]
  [Guid(1958595601, 21462, 18841, 180, 248, 108, 142, 204, 23, 113, 231)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWiFiDirectServiceSessionRequestedEventArgs
  {
    WiFiDirectServiceSessionRequest GetSessionRequest();
  }
}
