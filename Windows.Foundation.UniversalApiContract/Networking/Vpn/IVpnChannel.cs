// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnChannel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Vpn
{
  [Guid(1254591751, 53672, 17155, 160, 145, 200, 210, 224, 145, 91, 195)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VpnChannel))]
  internal interface IVpnChannel
  {
    void AssociateTransport(object mainOuterTunnelTransport, object optionalOuterTunnelTransport);

    [Overload("Start")]
    void Start(
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

    void Stop();

    VpnPickedCredential RequestCredentials(
      VpnCredentialType credType,
      bool isRetry,
      bool isSingleSignOnCredential,
      Certificate certificate);

    void RequestVpnPacketBuffer(VpnDataPathType type, out VpnPacketBuffer vpnPacketBuffer);

    void LogDiagnosticMessage(string message);

    uint Id { get; }

    VpnChannelConfiguration Configuration { get; }

    event TypedEventHandler<VpnChannel, VpnChannelActivityEventArgs> ActivityChange;

    object PlugInContext { set; get; }

    VpnSystemHealth SystemHealth { get; }

    void RequestCustomPrompt(IVectorView<IVpnCustomPrompt> customPrompt);

    void SetErrorMessage(string message);

    void SetAllowedSslTlsVersions(object tunnelTransport, bool useTls12);
  }
}
