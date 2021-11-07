// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnChannel2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnChannel))]
  [Guid(576049509, 39227, 17961, 173, 96, 241, 195, 243, 83, 127, 80)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVpnChannel2
  {
    void StartWithMainTransport(
      IVectorView<HostName> assignedClientIPv4list,
      IVectorView<HostName> assignedClientIPv6list,
      VpnInterfaceId vpnInterfaceId,
      VpnRouteAssignment assignedRoutes,
      VpnDomainNameAssignment assignedDomainName,
      uint mtuSize,
      uint maxFrameSize,
      bool Reserved,
      object mainOuterTunnelTransport);

    void StartExistingTransports(
      IVectorView<HostName> assignedClientIPv4list,
      IVectorView<HostName> assignedClientIPv6list,
      VpnInterfaceId vpnInterfaceId,
      VpnRouteAssignment assignedRoutes,
      VpnDomainNameAssignment assignedDomainName,
      uint mtuSize,
      uint maxFrameSize,
      bool Reserved);

    event TypedEventHandler<VpnChannel, VpnChannelActivityStateChangedArgs> ActivityStateChange;

    VpnPacketBuffer GetVpnSendPacketBuffer();

    VpnPacketBuffer GetVpnReceivePacketBuffer();

    [RemoteAsync]
    IAsyncAction RequestCustomPromptAsync(
      IVectorView<IVpnCustomPromptElement> customPromptElement);

    [RemoteAsync]
    [Overload("RequestCredentialsWithCertificateAsync")]
    IAsyncOperation<VpnCredential> RequestCredentialsAsync(
      VpnCredentialType credType,
      uint credOptions,
      Certificate certificate);

    [RemoteAsync]
    [Overload("RequestCredentialsWithOptionsAsync")]
    IAsyncOperation<VpnCredential> RequestCredentialsAsync(
      VpnCredentialType credType,
      uint credOptions);

    [Overload("RequestCredentialsSimpleAsync")]
    [RemoteAsync]
    IAsyncOperation<VpnCredential> RequestCredentialsAsync(
      VpnCredentialType credType);

    void TerminateConnection(string message);

    [Overload("StartWithTrafficFilter")]
    void StartWithTrafficFilter(
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
  }
}
