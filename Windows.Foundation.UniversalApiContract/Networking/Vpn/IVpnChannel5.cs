// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnChannel5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnChannel))]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [Guid(3732539794, 33668, 20412, 136, 44, 31, 210, 49, 36, 205, 59)]
  internal interface IVpnChannel5
  {
    void AppendVpnReceivePacketBuffer(VpnPacketBuffer decapsulatedPacketBuffer);

    void AppendVpnSendPacketBuffer(VpnPacketBuffer encapsulatedPacketBuffer);

    void FlushVpnReceivePacketBuffers();

    void FlushVpnSendPacketBuffers();
  }
}
