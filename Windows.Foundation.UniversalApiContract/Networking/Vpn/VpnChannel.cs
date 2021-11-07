// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnChannel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Vpn
{
  /// <summary>Provides methods to create and destroy a VPN channel, and methods to perform buffer management. A VPN channel is the object in the system that links the network traffic data flow between the VPN plug-in's VPN server socket and the client machine network stack.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.MTA)]
  [Static(typeof (IVpnChannelStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VpnChannel : 
    IVpnChannel,
    IVpnChannel2,
    IVpnChannel4,
    IVpnChannel5,
    IVpnChannel6
  {
    /// <summary>Prepares and marks the transport for use by the VPN framework as a transport link communicating the VPN plug-in to the VPN server. This call must be performed before any other operations related to the VPN framework APIs.</summary>
    /// <param name="mainOuterTunnelTransport">An **IInspectable** object for socket transport. This object can be a Windows.Networking.StreamSocket, a Windows.Networking.StreamWebSocket, or a Windows.Networking.DatagramSocket. This socket will control the connection to the VPN server and will be used to send encapsulated IP packets and receive encapsulated data. The socket must be unconnected at the point of the call.</param>
    /// <param name="optionalOuterTunnelTransport">An optional **IInspectable** object for socket transport. This object can be a Windows.Networking.StreamSocket, a Windows.Networking.StreamWebSocket, or a Windows.Networking.DatagramSocket. This socket will control the connection to the VPN server and will be used to send encapsulated IP packets and receive encapsulated data.</param>
    [MethodImpl]
    public extern void AssociateTransport(
      object mainOuterTunnelTransport,
      object optionalOuterTunnelTransport);

    [Overload("Start")]
    [MethodImpl]
    public extern void Start(
      IVectorView<HostName> assignedClientIPv4list,
      IVectorView<HostName> assignedClientIPv6list,
      VpnInterfaceId vpnInterfaceId,
      VpnRouteAssignment routeScope,
      VpnNamespaceAssignment namespaceScope,
      uint mtuSize,
      uint maxFrameSize,
      bool optimizeForLowCostNetwork,
      object mainOuterTunnelTransport,
      object optionalOuterTunnelTransport);

    /// <summary>Destroys a previously established VPN channel object. Disassociates and closes the *outerTunnelTransport* connection to the VPN server.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>Request the VPN platform to collect credentials from the user. The plug-in can specify the type and form of credentials to collect. The result is an object containing the main credentials depending on the type and the secondary credentials for change and expiration cases.</summary>
    /// <param name="credType">An enum value indicating type of credential to collect.</param>
    /// <param name="isRetry">If the request is a retry from as previous failed attempt, it is TRUE; otherwise, it is FALSE.</param>
    /// <param name="isSingleSignOnCredential">If the credential should be used by all applications operating over the VPN tunnel and authenticating to resources on the VPN, it is TRUE; otherwise, it is FALSE. This provides a single sign on experience over the VPN.</param>
    /// <param name="certificate">The certificate that can be optionally passed to indicate the platform its intention of use and obtain consent and unlock its protection.</param>
    /// <returns>An object containing the main credentials and any other transitional credentials filled by the user.</returns>
    [MethodImpl]
    public extern VpnPickedCredential RequestCredentials(
      VpnCredentialType credType,
      bool isRetry,
      bool isSingleSignOnCredential,
      Certificate certificate);

    /// <summary>Not supported. Requests a **IVpnPacketBuffer** from the specified pool. There is one **IVpnPacketBuffer** for the send path and another **IVpnPacketBuffer** for the receive path</summary>
    /// <param name="type">An enum value indicating which buffer pool to pick a buffer from. If the buffer requested for the packet to be sent to the VPN server, pick the Send enum type. If the buffer requested is for a received L3 decapsulated packet ready to be injected into the client network stack, pick the Receive enum type.</param>
    /// <param name="vpnPacketBuffer">A **IVpnPacketBuffer** object returned from the specified buffer pool.</param>
    [MethodImpl]
    public extern void RequestVpnPacketBuffer(
      VpnDataPathType type,
      out VpnPacketBuffer vpnPacketBuffer);

    /// <summary>Writes a diagnostic message to the system log.</summary>
    /// <param name="message">The text of the diagnostic message.</param>
    [MethodImpl]
    public extern void LogDiagnosticMessage(string message);

    /// <summary>Gets the unique instance ID of a VPN channel. This can be used to simplify demuxing operations between two VPN connection instances.</summary>
    /// <returns>A number representing the unique ID of the VPN channel.</returns>
    public extern uint Id { [MethodImpl] get; }

    /// <summary>Gets or sets a **VpnChannelConfiguration** object corresponding to the configuration of the VpnChannel and which dictates how to establish the communication with the VPN server.</summary>
    /// <returns>A **VpnChannelConfiguration** object containing the configuration pertaining the VpnChannel object.</returns>
    public extern VpnChannelConfiguration Configuration { [MethodImpl] get; }

    /// <summary>Not supported.</summary>
    public extern event TypedEventHandler<VpnChannel, VpnChannelActivityEventArgs> ActivityChange;

    /// <summary>Gets or sets a context object that VPN plug-ins can use to associate their internal state with a VpnChannel object for later use while the session is in progress.</summary>
    /// <returns>The contents of the Object are defined by the individual plug-in, based on the needs of the plug-in.</returns>
    public extern object PlugInContext { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the statement of health of the client machine.</summary>
    /// <returns>A pointer to the VpnSystemHealth class that provides access to the statement of health for the client machine.</returns>
    public extern VpnSystemHealth SystemHealth { [MethodImpl] get; }

    [MethodImpl]
    public extern void RequestCustomPrompt(IVectorView<IVpnCustomPrompt> customPrompt);

    /// <summary>Not supported.</summary>
    /// <param name="message">The text of the error message.</param>
    [MethodImpl]
    public extern void SetErrorMessage(string message);

    /// <summary>Not supported.</summary>
    /// <param name="tunnelTransport">An optional **IInspectable** object for socket transport. The object can be a **Windows.Networking.StreamSocket**, **Windows.Networking.WebStreamSocket** or **Windows.Networking.DatagramSocket**. This socket controls the connection to the VPN server and will be used to send encapsulated IP packets and receive encapsulated data.</param>
    /// <param name="useTls12">If Transport Security Layer 1.2 should be used, it is TRUE; otherwise, it is FALSE.</param>
    [MethodImpl]
    public extern void SetAllowedSslTlsVersions(object tunnelTransport, bool useTls12);

    [MethodImpl]
    public extern void StartWithMainTransport(
      IVectorView<HostName> assignedClientIPv4list,
      IVectorView<HostName> assignedClientIPv6list,
      VpnInterfaceId vpnInterfaceId,
      VpnRouteAssignment assignedRoutes,
      VpnDomainNameAssignment assignedDomainName,
      uint mtuSize,
      uint maxFrameSize,
      bool Reserved,
      object mainOuterTunnelTransport);

    [MethodImpl]
    public extern void StartExistingTransports(
      IVectorView<HostName> assignedClientIPv4list,
      IVectorView<HostName> assignedClientIPv6list,
      VpnInterfaceId vpnInterfaceId,
      VpnRouteAssignment assignedRoutes,
      VpnDomainNameAssignment assignedDomainName,
      uint mtuSize,
      uint maxFrameSize,
      bool Reserved);

    /// <summary>Event raised when the channel's activity state has changed. Used by VPN plug-ins to determine whether the channel is active with traffic or idle.</summary>
    public extern event TypedEventHandler<VpnChannel, VpnChannelActivityStateChangedArgs> ActivityStateChange;

    /// <summary>Retrieves a VpnPacketBuffer object from the send packet buffer pool to use in encapsulation and transmission of a data packet from the client network stack to the VPN server.</summary>
    /// <returns>The requested packet buffer object.</returns>
    [MethodImpl]
    public extern VpnPacketBuffer GetVpnSendPacketBuffer();

    /// <summary>Requests a VpnPacketBuffer object from the receive packet buffer pool to be used in the decapsulation or injection of a received packet from the VPN server into the local network stack</summary>
    /// <returns>The requested packet buffer object.</returns>
    [MethodImpl]
    public extern VpnPacketBuffer GetVpnReceivePacketBuffer();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RequestCustomPromptAsync(
      IVectorView<IVpnCustomPromptElement> customPromptElement);

    /// <summary>VPN platform to collect credentials from the user. If user interaction is required to obtain a credential or consent, the platform provides the necessary user interaction. A VPN plug-in must request credentials before using any type of credential, even if the intent is not to invoke user interaction for it.</summary>
    /// <param name="credType">An enum value indicating the type of credential to collect.</param>
    /// <param name="credOptions">Specifies the values defining whether a requested credential is a retry case, or should be used for single sign on.</param>
    /// <param name="certificate">A certificate to be used in validating the credential.</param>
    /// <returns>An asynchronous retrieval operation on a VpnCredential object containing the main credentials of the requested type, and secondary credentials for change and expiration cases.</returns>
    [RemoteAsync]
    [Overload("RequestCredentialsWithCertificateAsync")]
    [MethodImpl]
    public extern IAsyncOperation<VpnCredential> RequestCredentialsAsync(
      VpnCredentialType credType,
      uint credOptions,
      Certificate certificate);

    /// <summary>Requests the VPN platform to collect credentials from the user. The plug-in can specify the type and form of credentials to collect. The result is an object containing the main credentials depending on the type, and the secondary credentials for change and expiration cases.</summary>
    /// <param name="credType">An enum value indicating the type of credential to collect.</param>
    /// <param name="credOptions">Specifies the values defining whether a requested credential is a retry case, or should be used for single sign on.</param>
    /// <returns>An asynchronous retrieval operation on a VpnCredential object containing the main credentials of the requested type, and secondary credentials for change and expiration cases.</returns>
    [Overload("RequestCredentialsWithOptionsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VpnCredential> RequestCredentialsAsync(
      VpnCredentialType credType,
      uint credOptions);

    /// <summary>Requests the VPN platform to collect credentials of a given credential type from the user.</summary>
    /// <param name="credType">An enum value indicating the type of credential to collect.</param>
    /// <returns>An asynchronous retrieval operation on a VpnCredential object containing the main credentials of the requested type, and secondary credentials for change and expiration cases.</returns>
    [Overload("RequestCredentialsSimpleAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VpnCredential> RequestCredentialsAsync(
      VpnCredentialType credType);

    /// <summary>Allows a VPN plugin to indicate an error message and terminate the connection attempt performed inside the IVpnPlugin.Connect method. Should not be called on reconnect cases.</summary>
    /// <param name="message">The text of the error message.</param>
    [MethodImpl]
    public extern void TerminateConnection(string message);

    [Overload("StartWithTrafficFilter")]
    [MethodImpl]
    public extern void StartWithTrafficFilter(
      IVectorView<HostName> assignedClientIpv4List,
      IVectorView<HostName> assignedClientIpv6List,
      VpnInterfaceId vpnInterfaceId,
      VpnRouteAssignment assignedRoutes,
      VpnDomainNameAssignment assignedNamespace,
      uint mtuSize,
      uint maxFrameSize,
      bool reserved,
      object mainOuterTunnelTransport,
      object optionalOuterTunnelTransport,
      VpnTrafficFilterAssignment assignedTrafficFilters);

    /// <summary>Prepares, marks, and creates the transport for use by the VPN framework as a transport link communicating the VPN plug-in to the VPN server. This call must be performed before any other operations related to the VPN framework APIs.</summary>
    /// <param name="transport">An **IInspectable** object for socket transport. This object can be a Windows.Networking.StreamSocket, a Windows.Networking.StreamWebSocket, or a Windows.Networking.DatagramSocket. This socket will control the connection to the VPN server and will be used to send encapsulated IP packets and receive encapsulated data. The socket must be unconnected at the point of the call.</param>
    /// <param name="context">The transport context object to use, for example the name of a host or server.</param>
    [MethodImpl]
    public extern void AddAndAssociateTransport(object transport, object context);

    [Overload("StartWithMultipleTransports")]
    [MethodImpl]
    public extern void StartWithTrafficFilter(
      IIterable<HostName> assignedClientIpv4Addresses,
      IIterable<HostName> assignedClientIpv6Addresses,
      VpnInterfaceId vpninterfaceId,
      VpnRouteAssignment assignedRoutes,
      VpnDomainNameAssignment assignedNamespace,
      uint mtuSize,
      uint maxFrameSize,
      bool reserved,
      IIterable<object> transports,
      VpnTrafficFilterAssignment assignedTrafficFilters);

    /// <summary>Replaces an existing transport with a new one for use by the VPN framework as a transport link communicating the VPN plug-in to the VPN server.</summary>
    /// <param name="transport">An **IInspectable** object for socket transport. This object can be a Windows.Networking.StreamSocket, a Windows.Networking.StreamWebSocket, or a Windows.Networking.DatagramSocket. This socket will control the connection to the VPN server and will be used to send encapsulated IP packets and receive encapsulated data. The socket must be unconnected at the point of the call.</param>
    /// <param name="context">The transport context object to use, for example the name of a host or server.</param>
    [MethodImpl]
    public extern void ReplaceAndAssociateTransport(object transport, object context);

    /// <summary>Reconnect the socket transport. Transport and transport context are the only parameters that can be changed on a socket transport reconnection.</summary>
    /// <param name="transport">An **IInspectable** object for socket transport. This object can be a Windows.Networking.StreamSocket, a Windows.Networking.StreamWebSocket, or a Windows.Networking.DatagramSocket. This socket will control the connection to the VPN server and will be used to send encapsulated IP packets and receive encapsulated data. The socket must be unconnected at the point of the call.</param>
    /// <param name="context">The transport context object to use, for example the name of a host or server.</param>
    [MethodImpl]
    public extern void StartReconnectingTransport(object transport, object context);

    /// <summary>Retrieves the slot type (hardware or software) for the specified transport context object.</summary>
    /// <param name="context">A transport context object, for example the name of a host or server.</param>
    /// <returns>A value that indicates a slot type (hardware or software).</returns>
    [MethodImpl]
    public extern ControlChannelTriggerStatus GetSlotTypeForTransportContext(
      object context);

    /// <summary>Gets the transport context object in use, for example the name of a host or server.</summary>
    /// <returns>The transport context object in use, for example the name of a host or server. The value is `null` if the property is accessed outside of a callback (for example, in the case of a reconnection).</returns>
    public extern object CurrentRequestTransportContext { [MethodImpl] get; }

    [MethodImpl]
    public extern void AppendVpnReceivePacketBuffer(VpnPacketBuffer decapsulatedPacketBuffer);

    [MethodImpl]
    public extern void AppendVpnSendPacketBuffer(VpnPacketBuffer encapsulatedPacketBuffer);

    [MethodImpl]
    public extern void FlushVpnReceivePacketBuffers();

    [MethodImpl]
    public extern void FlushVpnSendPacketBuffers();

    [MethodImpl]
    public extern ValueSet ActivateForeground(
      string packageRelativeAppId,
      ValueSet sharedContext);

    /// <summary>Processes any pending VpnChannel events.</summary>
    /// <param name="thirdPartyPlugIn">The plug-in to be processed.</param>
    /// <param name="@event">
    /// </param>
    [MethodImpl]
    public static extern void ProcessEventAsync(object thirdPartyPlugIn, object @event);
  }
}
