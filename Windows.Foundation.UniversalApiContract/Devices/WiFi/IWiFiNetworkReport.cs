// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFi.IWiFiNetworkReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFi
{
  [ExclusiveTo(typeof (WiFiNetworkReport))]
  [Guid(2502221522, 22801, 17502, 129, 148, 190, 79, 26, 112, 72, 149)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWiFiNetworkReport
  {
    DateTime Timestamp { get; }

    IVectorView<WiFiAvailableNetwork> AvailableNetworks { get; }
  }
}
