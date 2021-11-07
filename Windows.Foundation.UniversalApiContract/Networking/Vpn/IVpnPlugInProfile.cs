// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnPlugInProfile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Guid(249499044, 20224, 17801, 141, 123, 75, 249, 136, 246, 84, 44)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VpnPlugInProfile))]
  internal interface IVpnPlugInProfile : IVpnProfile
  {
    IVector<Uri> ServerUris { get; }

    string CustomConfiguration { get; set; }

    string VpnPluginPackageFamilyName { get; set; }
  }
}
