// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnPlugInProfile2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnPlugInProfile))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1629243538, 53140, 19158, 186, 153, 0, 244, 255, 52, 86, 94)]
  internal interface IVpnPlugInProfile2 : IVpnProfile
  {
    bool RequireVpnClientAppUI { get; set; }

    VpnManagementConnectionStatus ConnectionStatus { get; }
  }
}
