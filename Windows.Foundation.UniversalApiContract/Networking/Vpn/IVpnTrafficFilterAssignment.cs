// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnTrafficFilterAssignment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnTrafficFilterAssignment))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1456264284, 58980, 18206, 137, 205, 96, 22, 3, 185, 224, 243)]
  internal interface IVpnTrafficFilterAssignment
  {
    IVector<VpnTrafficFilter> TrafficFilterList { get; }

    bool AllowOutbound { get; set; }

    bool AllowInbound { get; set; }
  }
}
