// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFi.WiFiNetworkReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFi
{
  /// <summary>Contains the result of a network scan operation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class WiFiNetworkReport : IWiFiNetworkReport
  {
    /// <summary>Contains the result of a network scan operation.</summary>
    /// <returns>The date and time that the scan operation finished.</returns>
    public extern DateTime Timestamp { [MethodImpl] get; }

    /// <summary>A list of available networks.</summary>
    /// <returns>A list of available networks.</returns>
    public extern IVectorView<WiFiAvailableNetwork> AvailableNetworks { [MethodImpl] get; }
  }
}
