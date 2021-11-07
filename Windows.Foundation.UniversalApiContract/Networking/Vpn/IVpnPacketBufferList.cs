// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnPacketBufferList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VpnPacketBufferList))]
  [Guid(3271070204, 19804, 19043, 183, 13, 78, 48, 126, 172, 206, 119)]
  internal interface IVpnPacketBufferList : IIterable<VpnPacketBuffer>
  {
    void Append(VpnPacketBuffer nextVpnPacketBuffer);

    void AddAtBegin(VpnPacketBuffer nextVpnPacketBuffer);

    VpnPacketBuffer RemoveAtEnd();

    VpnPacketBuffer RemoveAtBegin();

    void Clear();

    VpnPacketBufferStatus Status { set; get; }

    uint Size { get; }
  }
}
