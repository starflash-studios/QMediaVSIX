// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.WiFiDirectService
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect.Services
{
  /// <summary>Represents a Wi-Fi Direct service. This class is used by code on a device that seeks to use a Wi-Fi Direct Service, to establish a Wi-Fi Direct Service session with the service provider.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IWiFiDirectServiceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WiFiDirectService : IWiFiDirectService
  {
    /// <summary>Gets the service information blob from this service instance.</summary>
    /// <returns>A buffer of up to 255 bytes with information from the server. The format of this blob is determined by the individual service.</returns>
    public extern IBuffer RemoteServiceInfo { [MethodImpl] get; }

    /// <summary>Gets a list of supported configuration methods, ordered by preference. Your code uses IVector operations to modify the contents of the list.</summary>
    /// <returns>Ordered list of configuration method enumeration values.</returns>
    public extern IVectorView<WiFiDirectServiceConfigurationMethod> SupportedConfigurationMethods { [MethodImpl] get; }

    /// <summary>Gets or sets a value specifying whether the service instance should choose Wi-Fi Direct Point to Point (P2P) Group Owner (GO) mode.</summary>
    /// <returns>When true, prefer GO mode.</returns>
    public extern bool PreferGroupOwnerMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets app-specific session information passed to the server when initiating a session.</summary>
    /// <returns>Session information. Format is determined by the individual service. Set this property before calling ConnectAsync.</returns>
    public extern IBuffer SessionInfo { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Error information about the latest attempt to connect to the service.</summary>
    /// <returns>An enumeration value specifying the detailed reason for the failure.</returns>
    public extern WiFiDirectServiceError ServiceError { [MethodImpl] get; }

    /// <summary>Event raised when a session request has been deferred. Note that this does not mean that the request has failed or been denied. It is a notification that the server is performing a long operation, such as waiting for a user to enter a PIN. The seeker that receives this message should begin a 120-second wait before it times out the session request, to give the server time to complete its operation.</summary>
    public extern event TypedEventHandler<WiFiDirectService, WiFiDirectServiceSessionDeferredEventArgs> SessionDeferred;

    /// <summary>Asynchronously retrieves Wi-Fi Direct Service session provisioning information.</summary>
    /// <param name="selectedConfigurationMethod">The preferred method of configuring the session.</param>
    /// <returns>An asynchronous retrieval operation. On successful completion, returns provisioning information.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<WiFiDirectServiceProvisioningInfo> GetProvisioningInfoAsync(
      WiFiDirectServiceConfigurationMethod selectedConfigurationMethod);

    /// <summary>Initiates the establishment of a service session with the Wi-Fi Direct Service represented by this instance.</summary>
    /// <returns>An asynchronous connection operation. When successfully completed, returns an object that represents the session that has been established.</returns>
    [Overload("ConnectAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<WiFiDirectServiceSession> ConnectAsync();

    /// <summary>Initiates the establishment of a service session with the Wi-Fi Direct Service represented by this instance, using a PIN to configure the session.</summary>
    /// <param name="pin">The PIN to be used to configure the connection.</param>
    /// <returns>An asynchronous connection operation. When successfully completed, returns an object that represents the session that has been established.</returns>
    [Overload("ConnectAsyncWithPin")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<WiFiDirectServiceSession> ConnectAsync(
      string pin);

    /// <summary>Gets an Advanced Query Syntax (AQS) string to be used to find Wi-Fi Direct Service advertisers for a particular service.</summary>
    /// <param name="serviceName">The service name to be found.</param>
    /// <returns>The AQS string for the requested advertiser query.</returns>
    [Overload("GetSelector")]
    [MethodImpl]
    public static extern string GetSelector(string serviceName);

    /// <summary>Gets an Advanced Query Syntax (AQS) string to be used to find Wi-Fi Direct Service advertisers for a particular service, where a given byte sequence appears in the advertiser's service information blob.</summary>
    /// <param name="serviceName">The service name to be found.</param>
    /// <param name="serviceInfoFilter">A byte sequence that must be found in the advertiser's service information blob.</param>
    /// <returns>The AQS string for the requested advertiser query.</returns>
    [Overload("GetSelectorWithFilter")]
    [MethodImpl]
    public static extern string GetSelector(string serviceName, IBuffer serviceInfoFilter);

    /// <summary>Static method that retrieves a WiFiDirectService instance for a Wi-Fi Direct Service offered by the device with a given device ID.</summary>
    /// <param name="deviceId">Device ID of the device that advertises the desired Wi-Fi Direct Service.</param>
    /// <returns>An asynchronous retrieval operation. On successful completion, returns an instance of WiFiDirectService specific to the desired service instance, advertised by the indicated device.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WiFiDirectService> FromIdAsync(
      string deviceId);
  }
}
