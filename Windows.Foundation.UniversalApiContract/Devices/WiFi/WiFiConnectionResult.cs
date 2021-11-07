// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFi.WiFiConnectionResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFi
{
  /// <summary>Describes the results of an attempt to connect to a Wi-Fi network.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class WiFiConnectionResult : IWiFiConnectionResult
  {
    /// <summary>Gets the connection result value.</summary>
    /// <returns>Value describing the current status of the connection attempt.</returns>
    public extern WiFiConnectionStatus ConnectionStatus { [MethodImpl] get; }
  }
}
