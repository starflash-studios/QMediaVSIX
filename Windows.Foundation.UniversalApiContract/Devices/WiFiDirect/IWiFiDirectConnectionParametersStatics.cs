// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectConnectionParametersStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(1502278803, 30274, 17775, 185, 216, 232, 169, 235, 31, 64, 26)]
  [ExclusiveTo(typeof (WiFiDirectConnectionParameters))]
  internal interface IWiFiDirectConnectionParametersStatics
  {
    DevicePairingKinds GetDevicePairingKinds(
      WiFiDirectConfigurationMethod configurationMethod);
  }
}
