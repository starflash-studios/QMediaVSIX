// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnRoute
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3044219779, 2409, 18073, 147, 142, 119, 118, 219, 41, 207, 179)]
  [ExclusiveTo(typeof (VpnRoute))]
  internal interface IVpnRoute
  {
    HostName Address { set; get; }

    byte PrefixSize { [param: Range(0, 128)] set; get; }
  }
}
