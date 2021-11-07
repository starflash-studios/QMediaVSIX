// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFi.WiFiAdapter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;
using Windows.Security.Credentials;

namespace Windows.Devices.WiFi
{
  /// <summary>Use this class to enumerate local Wi-Fi adapters, initiate Wi-Fi scans, enumerate scan results, and to connect or disconnect individual adapters.</summary>
  [Static(typeof (IWiFiAdapterStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WiFiAdapter : IWiFiAdapter, IWiFiAdapter2
  {
    /// <summary>Gets information about a Wi-Fi adapter.</summary>
    /// <returns>An instance of Windows.Networking.Connectivity.NetworkAdapter representing this adapter.</returns>
    public extern NetworkAdapter NetworkAdapter { [MethodImpl] get; }

    /// <summary>Directs this adapter to initiate an asynchronous network scan.</summary>
    /// <returns>An asynchronous scan operation. On successful completion, returns a list of networks scanned by this adapter.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ScanAsync();

    /// <summary>Gets a list of available networks populated by the last Wi-Fi scan on this WiFiNetworkAdapter.</summary>
    /// <returns>A list of available networks.</returns>
    public extern WiFiNetworkReport NetworkReport { [MethodImpl] get; }

    /// <summary>Event raised when a scan completes on this Wi-Fi adapter. This event cannot be raised from a background task.</summary>
    public extern event TypedEventHandler<WiFiAdapter, object> AvailableNetworksChanged;

    /// <summary>Connect this Wi-Fi device to the specified network, with the specified reconnection policy.</summary>
    /// <param name="availableNetwork">Describes the Wi-Fi network to be connected.</param>
    /// <param name="reconnectionKind">Specifies how to reconnect if the connection is lost.</param>
    /// <returns>An asynchronous connect operation. On successful conclusion of the operation, returns an object that describes the result of the connect operation.</returns>
    [RemoteAsync]
    [Overload("ConnectAsync")]
    [MethodImpl]
    public extern IAsyncOperation<WiFiConnectionResult> ConnectAsync(
      WiFiAvailableNetwork availableNetwork,
      WiFiReconnectionKind reconnectionKind);

    /// <summary>Connect this Wi-Fi device to the specified network, with the specified passphrase and reconnection policy.</summary>
    /// <param name="availableNetwork">Specifies the Wi-Fi network to connect to.</param>
    /// <param name="reconnectionKind">Describes how to reconnect to the network if connection is lost.</param>
    /// <param name="passwordCredential">The passphrase to be used to connect to the access point.</param>
    /// <returns>An asynchronous connect operation. On successful conclusion of the operation, returns an object that describes the result of the connect operation.</returns>
    [Overload("ConnectWithPasswordCredentialAsync")]
    [MethodImpl]
    public extern IAsyncOperation<WiFiConnectionResult> ConnectAsync(
      WiFiAvailableNetwork availableNetwork,
      WiFiReconnectionKind reconnectionKind,
      PasswordCredential passwordCredential);

    /// <summary>Connect this Wi-Fi device to a hidden network, with the given passphrase and reconnection policy.</summary>
    /// <param name="availableNetwork">Describes the Wi-Fi network to connect to.</param>
    /// <param name="reconnectionKind">Describes how to reconnect to the network if connection is lost.</param>
    /// <param name="passwordCredential">Password or other credential to use to connect to the network.</param>
    /// <param name="ssid">When the network SSID is hidden, use this parameter to provide the SSID.</param>
    /// <returns>An asynchronous connect operation. On successful conclusion of the operation, returns an object that describes the result of the connect operation.</returns>
    [Overload("ConnectWithPasswordCredentialAndSsidAsync")]
    [MethodImpl]
    public extern IAsyncOperation<WiFiConnectionResult> ConnectAsync(
      WiFiAvailableNetwork availableNetwork,
      WiFiReconnectionKind reconnectionKind,
      PasswordCredential passwordCredential,
      string ssid);

    /// <summary>Disconnects any active Wi-Fi connection through this adapter.</summary>
    [MethodImpl]
    public extern void Disconnect();

    /// <summary>Performs WPS discovery to query the WPS methods supported by the network.</summary>
    /// <param name="availableNetwork">An available Wi-Fi network. See WiFiAvailableNetwork class.</param>
    /// <returns>On successful completion, returns a WiFiWpsConfigurationResult.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<WiFiWpsConfigurationResult> GetWpsConfigurationAsync(
      WiFiAvailableNetwork availableNetwork);

    /// <summary>Connect this Wi-Fi device to a hidden network, with the given passphrase, connection method, and reconnection policy.</summary>
    /// <param name="availableNetwork">Specifies the Wi-Fi network to connect to.</param>
    /// <param name="reconnectionKind">Specifies how to reconnect if the connection is lost.</param>
    /// <param name="passwordCredential">The passphrase to be used to connect to the access point.</param>
    /// <param name="ssid">When the network SSID is hidden, use this parameter to provide the SSID.</param>
    /// <param name="connectionMethod">A WiFiConnectionMethod enumeration member indicating the connection method.</param>
    /// <returns>An asynchronous connect operation. On successful conclusion of the operation, returns an object that describes the result of the connect operation.</returns>
    [Overload("ConnectWithPasswordCredentialAndSsidAndConnectionMethodAsync")]
    [MethodImpl]
    public extern IAsyncOperation<WiFiConnectionResult> ConnectAsync(
      WiFiAvailableNetwork availableNetwork,
      WiFiReconnectionKind reconnectionKind,
      PasswordCredential passwordCredential,
      string ssid,
      WiFiConnectionMethod connectionMethod);

    /// <summary>A static method that initiates an asynchronous operation to enumerate all Wi-Fi adapters in the system.</summary>
    /// <returns>An asynchronous enumeration operation. On successful completion, returns a list of available Wi-Fi adapters.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<WiFiAdapter>> FindAllAdaptersAsync();

    /// <summary>A static method that returns an Advanced Query Syntax (AQS) string to be used to enumerate Wi-Fi adapters using Windows.Devices.Enumeration.DeviceInformation.FindAllAsync and related methods.</summary>
    /// <returns>An identifier to be used to enumerate Wi-Fi devices.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>A static method that initiates an asynchronous operation to get a WiFiAdapter object.</summary>
    /// <param name="deviceId">The Device ID of the Wi-Fi adapter to be retrieved. Obtain a Device ID through the Windows.Devices.Enumeration namespace.</param>
    /// <returns>An asynchronous get operation. On successful completion, returns a WiFiAdapter object specific to the requested Device ID.</returns>
    [Overload("FromIdAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WiFiAdapter> FromIdAsync(
      string deviceId);

    /// <summary>A static method for determining whether the current user can access any of the Wi-Fi adapters on this device.</summary>
    /// <returns>An asynchronous access operation. On successful completion, returns a status enumeration value describing whether the current user can access any Wi-Fi adapter.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WiFiAccessStatus> RequestAccessAsync();
  }
}
