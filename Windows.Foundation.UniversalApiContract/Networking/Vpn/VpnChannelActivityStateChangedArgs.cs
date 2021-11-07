// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnChannelActivityStateChangedArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Represents the ActivityStateChanged event specifying the new VPN channel state (idle or active).</summary>
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VpnChannelActivityStateChangedArgs : IVpnChannelActivityStateChangedArgs
  {
    /// <summary>Gets a value identifying whether the VPN channel is idle or active.</summary>
    /// <returns>An enum value that indicates whether the VPN channel is idle or active.</returns>
    public extern VpnChannelActivityEventType ActivityState { [MethodImpl] get; }
  }
}
