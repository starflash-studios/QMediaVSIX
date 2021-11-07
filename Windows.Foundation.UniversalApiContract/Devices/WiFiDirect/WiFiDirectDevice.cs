// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.WiFiDirectDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.Devices.WiFiDirect
{
  /// <summary>Manages connections to associated Wi-Fi Direct devices.</summary>
  [DualApiPartition(version = 100859904)]
  [Static(typeof (IWiFiDirectDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IWiFiDirectDeviceStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WiFiDirectDevice : IWiFiDirectDevice, IClosable
  {
    /// <summary>Gets the connection status for the WiFi-Direct device.</summary>
    /// <returns>The connection status for the WiFi-Direct device.</returns>
    public extern WiFiDirectConnectionStatus ConnectionStatus { [MethodImpl] get; }

    /// <summary>Gets the DeviceInformation Id for the Wi-Fi Direct device.</summary>
    /// <returns>The DeviceInformation Id for the Wi-Fi Direct device.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Occurs when a Wi-Fi Direct device connection is connected or disconnected.</summary>
    public extern event TypedEventHandler<WiFiDirectDevice, object> ConnectionStatusChanged;

    /// <summary>Gets a collection of network addresses for the Wi-Fi Direct device as endpoint pairs.</summary>
    /// <returns>A collection of network addresses for the Wi-Fi Direct device as endpoint pairs.</returns>
    [MethodImpl]
    public extern IVectorView<EndpointPair> GetConnectionEndpointPairs();

    [MethodImpl]
    public extern void Close();

    /// <summary>Returns the class selection string that you can use to enumerate Wi-Fi Direct devices for a specific Wi-Fi Direct device selector type.</summary>
    /// <param name="type">A specific Wi-Fi Direct device selector type.</param>
    /// <returns>The class selection string that you can use to enumerate Wi-Fi Direct devices.</returns>
    [Overload("GetDeviceSelector")]
    [MethodImpl]
    public static extern string GetDeviceSelector(WiFiDirectDeviceSelectorType type);

    /// <summary>Creates an instance of the WiFiDirectDevice class for the specified device interface id with specific connection parameters.</summary>
    /// <param name="deviceId">The DeviceInformation Id of a Wi-Fi Direct device.</param>
    /// <param name="connectionParameters">Connection parameters for a Wi-Fi Direct connect/pairing operation.</param>
    /// <returns>An asynchronous operation to retrieve the WiFiDirectDevice that was created.</returns>
    [Overload("FromIdAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WiFiDirectDevice> FromIdAsync(
      string deviceId,
      WiFiDirectConnectionParameters connectionParameters);

    /// <summary>Returns the class selection string that you can use to enumerate Wi-Fi Direct devices.</summary>
    /// <returns>The class selection string that you can use to enumerate Wi-Fi Direct devices.</returns>
    [Overload("GetDeviceSelector")]
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Creates an instance of the WiFiDirectDevice class for the specified device interface id.</summary>
    /// <param name="deviceId">The DeviceInformation Id of a Wi-Fi Direct device.</param>
    /// <returns>An asynchronous operation to retrieve the WiFiDirectDevice that was created.</returns>
    [Overload("FromIdAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WiFiDirectDevice> FromIdAsync(
      string deviceId);
  }
}
