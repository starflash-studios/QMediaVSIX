// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnChannel4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnChannel))]
  [Guid(3609620190, 10551, 16797, 149, 112, 72, 106, 235, 184, 24, 3)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IVpnChannel4
  {
    void AddAndAssociateTransport(object transport, object context);

    [Overload("StartWithMultipleTransports")]
    void StartWithTrafficFilter(
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

    void ReplaceAndAssociateTransport(object transport, object context);

    void StartReconnectingTransport(object transport, object context);

    ControlChannelTriggerStatus GetSlotTypeForTransportContext(
      object context);

    object CurrentRequestTransportContext { get; }
  }
}
