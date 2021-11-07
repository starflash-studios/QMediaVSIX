// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnTrafficFilterAssignment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Allows the specification of a set of traffic filters as policy to a VPN channel.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VpnTrafficFilterAssignment : IVpnTrafficFilterAssignment
  {
    /// <summary>Allows a VPN plug-in to create a traffic filter policy assignment for the VPN channel.</summary>
    [MethodImpl]
    public extern VpnTrafficFilterAssignment();

    /// <summary>Gets a list of traffic filters composing the traffic filter policy to assign to a VPN channel.</summary>
    /// <returns>The list of traffic filters composing the traffic filter policy to assign to a VPN channel.</returns>
    public extern IVector<VpnTrafficFilter> TrafficFilterList { [MethodImpl] get; }

    /// <summary>Gets or sets whether outbound traffic is allowed or not.</summary>
    /// <returns>If outbound traffic is allowed, it is **TRUE**; otherwise , it is **FALSE**.</returns>
    public extern bool AllowOutbound { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether inbound traffic is allowed or not.</summary>
    /// <returns>If inbound traffic is allowed, it is **TRUE**; otherwise , it is **FALSE**.</returns>
    public extern bool AllowInbound { [MethodImpl] get; [MethodImpl] set; }
  }
}
