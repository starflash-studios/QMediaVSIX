// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSessionRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect.Services
{
  /// <summary>Describes a Wi-Fi Direct Service session request.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class WiFiDirectServiceSessionRequest : IWiFiDirectServiceSessionRequest, IClosable
  {
    /// <summary>Gets device information for the requesting device.</summary>
    /// <returns>Describes the requesting device.</returns>
    public extern DeviceInformation DeviceInformation { [MethodImpl] get; }

    /// <summary>Gets information about how provisioning should be performed if the session is established.</summary>
    /// <returns>Provisioning information.</returns>
    public extern WiFiDirectServiceProvisioningInfo ProvisioningInfo { [MethodImpl] get; }

    /// <summary>Gets the session information blob associated with this request.</summary>
    /// <returns>A byte sequence, up to 144 bytes. The format is defined by the service.</returns>
    public extern IBuffer SessionInfo { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
