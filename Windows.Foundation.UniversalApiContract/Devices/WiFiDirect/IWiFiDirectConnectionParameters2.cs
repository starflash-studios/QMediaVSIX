// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectConnectionParameters2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2872774590, 43650, 17588, 136, 200, 227, 5, 107, 137, 128, 29)]
  [ExclusiveTo(typeof (WiFiDirectConnectionParameters))]
  internal interface IWiFiDirectConnectionParameters2
  {
    IVector<WiFiDirectConfigurationMethod> PreferenceOrderedConfigurationMethods { get; }

    WiFiDirectPairingProcedure PreferredPairingProcedure { get; set; }
  }
}
