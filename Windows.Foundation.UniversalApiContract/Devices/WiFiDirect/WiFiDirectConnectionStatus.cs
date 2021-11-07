// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.WiFiDirectConnectionStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  /// <summary>Describes the connection status of a WiFiDirectDevice object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WiFiDirectConnectionStatus
  {
    /// <summary>The device is not connected.</summary>
    Disconnected,
    /// <summary>The device is connected to an associated Wi-Fi Direct device.</summary>
    Connected,
  }
}
