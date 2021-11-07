// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnPacketBufferFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>This interface is reserved for system use.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2653805730, 5906, 19684, 177, 121, 140, 101, 44, 109, 153, 153)]
  public interface IVpnPacketBufferFactory
  {
    /// <summary>Reserved.</summary>
    /// <param name="parentBuffer">Reserved.</param>
    /// <param name="offset">Reserved.</param>
    /// <param name="length">Not used.</param>
    /// <returns>Reserved.</returns>
    VpnPacketBuffer CreateVpnPacketBuffer(
      VpnPacketBuffer parentBuffer,
      uint offset,
      uint length);
  }
}
