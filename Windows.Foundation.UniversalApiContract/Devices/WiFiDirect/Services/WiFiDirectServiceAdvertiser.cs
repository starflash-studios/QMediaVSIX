// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.WiFiDirectServiceAdvertiser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect.Services
{
  /// <summary>Represents a Service Advertiser. This class is used by code on a device that advertises Wi-Fi Direct Services, to advertise the service.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Activatable(typeof (IWiFiDirectServiceAdvertiserFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WiFiDirectServiceAdvertiser : IWiFiDirectServiceAdvertiser
  {
    /// <summary>Creates an instance of the WiFiDirectServiceAdvertiser class. To start advertising a Wi-Fi Direct Service, create an instance of this class, set its properties appropriately for your service, and then call its Start method.</summary>
    /// <param name="serviceName">The name of the service to be advertised. Service names are UTF-8 strings no more than 255 characters long. It is recommended that names use reverse domain name notation, where the service owner's DNS name (such as "contoso.com") is reversed and used as the beginning of the service name (such as "com.contoso.serviceX"). This convention is intended to make it easy to choose unique service names.</param>
    [MethodImpl]
    public extern WiFiDirectServiceAdvertiser(string serviceName);

    /// <summary>Gets the service name.</summary>
    /// <returns>The service name.</returns>
    public extern string ServiceName { [MethodImpl] get; }

    /// <summary>Gets a list of service name prefixes that should match this service when a seeker is using prefix searching. Your code uses IVector methods to add or remove elements from the list.</summary>
    /// <returns>The list of prefixes. Prefix values</returns>
    public extern IVector<string> ServiceNamePrefixes { [MethodImpl] get; }

    /// <summary>Gets or sets the service information blob. The format and contents of the blob are determined by the individual service, and are intended to be used by Seekers during service discovery.</summary>
    /// <returns>The service information blob.</returns>
    public extern IBuffer ServiceInfo { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Auto Accept property for this service advertisement.</summary>
    /// <returns>When true, then the service automatically accepts all requests from service seekers to establish a session. If this value is false, then the service must actively accept a session request when the SessionRequested event is raised.</returns>
    public extern bool AutoAcceptSession { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating whether the service requires that it be the Wi-Fi Direct Peer to Peer (P2P) Group Owner.</summary>
    /// <returns>If true, the service must be the Group Owner (GO) of the Peer to Peer (P2P) connection between seeker and service. If false, the service will accept connections whether it is the GO or not.</returns>
    public extern bool PreferGroupOwnerMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a list (that implements the IVector interface) of preferred session configuration methods. Your code uses IVector operations on the list to add or remove elements from the list.</summary>
    /// <returns>An ordered list of enumeration values indicating preferred configuration methods. The earlier a configuration method appears in the list, the higher the preference for using that method when configuring sessions with this advertiser.</returns>
    public extern IVector<WiFiDirectServiceConfigurationMethod> PreferredConfigurationMethods { [MethodImpl] get; }

    /// <summary>Gets or sets the service status.</summary>
    /// <returns>An enumeration value that corresponds to the service status. Note that if this value is **Custom**, then the CustomServiceStatusCode property gives the actual custom status code value.</returns>
    public extern WiFiDirectServiceStatus ServiceStatus { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a custom service status code. Only valid if the ServiceStatus property value is **Custom**.</summary>
    /// <returns>If ServiceStatus is set to **Custom**, this property is the custom status value. Custom values must be in the range 2 - 255.</returns>
    public extern uint CustomServiceStatusCode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the service-specific information that is passed to a session requester when establishing a session will not be completed immediately, as when, for example, the service is waiting for user input to complete the request. A requester should implement a 120 second timeout when its request is deferred.</summary>
    /// <returns>The information to be sent to the session requester. Format is service-specific, and total size cannot exceed 144 bytes.</returns>
    public extern IBuffer DeferredSessionInfo { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that describes the current status of the advertisement.</summary>
    /// <returns>An enumeration value that describes current status.</returns>
    public extern WiFiDirectServiceAdvertisementStatus AdvertisementStatus { [MethodImpl] get; }

    /// <summary>Gets a specific error code when AdvertisementStatus is **Aborted**.</summary>
    /// <returns>An enumeration value that gives a more specific cause for AdvertisementStatus being **Aborted**.</returns>
    public extern WiFiDirectServiceError ServiceError { [MethodImpl] get; }

    /// <summary>Event raised when a Seeker has requested that a session be established with the service associated with this WiFiDirectServiceAdvertiser instance. To accept the request, call WiFiDirectServiceAdvertiser.ConnectAsync in your event handler.</summary>
    public extern event TypedEventHandler<WiFiDirectServiceAdvertiser, WiFiDirectServiceSessionRequestedEventArgs> SessionRequested;

    /// <summary>Event raised when the service has automatically accepted a session request. Your event handler should establish socket connections for the endpoint pairs listed in the event arguments object.</summary>
    public extern event TypedEventHandler<WiFiDirectServiceAdvertiser, WiFiDirectServiceAutoAcceptSessionConnectedEventArgs> AutoAcceptSessionConnected;

    /// <summary>Event raised when the AdvertisementStatus property value changes.</summary>
    public extern event TypedEventHandler<WiFiDirectServiceAdvertiser, object> AdvertisementStatusChanged;

    /// <summary>Accepts a session request without requiring a PIN.</summary>
    /// <param name="deviceInfo">Describes the device to be connected. Pass in the WiFiDirectServiceSessionRequestedEventArgs.DeviceInformation property value.</param>
    /// <returns>An asynchronous connection operation. On successful completion, returns an object that describes the session that has been created.</returns>
    [Overload("ConnectAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<WiFiDirectServiceSession> ConnectAsync(
      DeviceInformation deviceInfo);

    /// <summary>Accepts a session request by connecting with the given PIN.</summary>
    /// <param name="deviceInfo">Describes the device to be connected. Pass in the WiFiDirectServiceSessionRequestedEventArgs.DeviceInformation property value.</param>
    /// <param name="pin">The PIN to be used to configure the session.</param>
    /// <returns>An asynchronous connection operation. On successful completion, returns an object that describes the session that has been created.</returns>
    [RemoteAsync]
    [Overload("ConnectAsyncWithPin")]
    [MethodImpl]
    public extern IAsyncOperation<WiFiDirectServiceSession> ConnectAsync(
      DeviceInformation deviceInfo,
      string pin);

    /// <summary>Starts advertising the service, using current property values to set the parameters of the advertisement.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops advertising the service. This does not affect existing sessions that are connected to the service.</summary>
    [MethodImpl]
    public extern void Stop();
  }
}
