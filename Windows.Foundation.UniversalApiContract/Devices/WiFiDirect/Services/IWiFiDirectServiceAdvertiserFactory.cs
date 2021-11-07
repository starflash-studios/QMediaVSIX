// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.IWiFiDirectServiceAdvertiserFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect.Services
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(822520845, 46150, 20243, 159, 154, 138, 233, 37, 254, 186, 43)]
  [ExclusiveTo(typeof (WiFiDirectServiceAdvertiser))]
  internal interface IWiFiDirectServiceAdvertiserFactory
  {
    WiFiDirectServiceAdvertiser CreateWiFiDirectServiceAdvertiser(
      string serviceName);
  }
}
