// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnPacketBuffer2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnPacketBuffer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1717473776, 34821, 19445, 166, 25, 46, 132, 136, 46, 107, 79)]
  internal interface IVpnPacketBuffer2
  {
    VpnAppId AppId { get; }
  }
}
