// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnCustomCheckBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Guid(1132955475, 965, 20065, 147, 215, 169, 87, 113, 76, 66, 130)]
  [ExclusiveTo(typeof (VpnCustomCheckBox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVpnCustomCheckBox : IVpnCustomPrompt
  {
    bool InitialCheckState { set; get; }

    bool Checked { get; }
  }
}
