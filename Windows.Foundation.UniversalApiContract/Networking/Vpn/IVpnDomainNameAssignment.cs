// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnDomainNameAssignment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnDomainNameAssignment))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1094037825, 52443, 18869, 148, 1, 3, 154, 138, 231, 103, 233)]
  internal interface IVpnDomainNameAssignment
  {
    IVector<VpnDomainNameInfo> DomainNameList { get; }

    Uri ProxyAutoConfigurationUri { set; get; }
  }
}
