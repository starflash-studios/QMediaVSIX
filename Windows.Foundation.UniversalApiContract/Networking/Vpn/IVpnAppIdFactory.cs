// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnAppIdFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1185807658, 2731, 20443, 130, 29, 211, 221, 201, 25, 120, 139)]
  [ExclusiveTo(typeof (VpnAppId))]
  internal interface IVpnAppIdFactory
  {
    VpnAppId Create(VpnAppIdType type, string value);
  }
}
