// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnSystemHealth
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Vpn
{
  /// <summary>Allows access to the security health of the system device.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class VpnSystemHealth : IVpnSystemHealth
  {
    /// <summary>Gets the RFC compliant blob representing the Statement of Health. This can be used to send directly in any of the network protocols embedding a RFC compliant statement of health.</summary>
    /// <returns>The RFC compliant blob representing the Statement of Health.</returns>
    public extern Buffer StatementOfHealth { [MethodImpl] get; }
  }
}
