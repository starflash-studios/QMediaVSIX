// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnChannelActivityEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>**VpnChannelActivityEventArgs** is not supported and may be altered or unavailable in the future. Instead, use VpnChannelActivityStateChangedArgs.</summary>
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VpnChannelActivityEventArgs : IVpnChannelActivityEventArgs
  {
    /// <summary>**VpnChannelActivityEventArgs** is not supported and may be altered or unavailable in the future. Instead, use VpnChannelActivityStateChangedArgs.</summary>
    /// <returns>Not supported.</returns>
    public extern VpnChannelActivityEventType Type { [MethodImpl] get; }
  }
}
