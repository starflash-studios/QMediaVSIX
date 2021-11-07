// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnNativeProfile2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnNativeProfile))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(267134055, 52661, 19143, 181, 163, 10, 251, 94, 196, 118, 130)]
  internal interface IVpnNativeProfile2
  {
    bool RequireVpnClientAppUI { get; set; }

    VpnManagementConnectionStatus ConnectionStatus { get; }
  }
}
