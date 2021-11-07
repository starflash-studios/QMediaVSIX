// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnTrafficFilterFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1208828373, 32665, 18252, 134, 238, 150, 223, 22, 131, 24, 241)]
  [ExclusiveTo(typeof (VpnTrafficFilter))]
  internal interface IVpnTrafficFilterFactory
  {
    VpnTrafficFilter Create(VpnAppId appId);
  }
}
