// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.WiFiDirectConnectionRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  /// <summary>A Wi-Fi Direct connection request received by a WiFiDirectConnectionListener.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WiFiDirectConnectionRequest : IWiFiDirectConnectionRequest, IClosable
  {
    /// <summary>Gets device information for the endpoint making the Wi-Fi Direct connection request.</summary>
    /// <returns>Device information for the endpoint making the Wi-Fi Direct connection request.</returns>
    public extern DeviceInformation DeviceInformation { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
