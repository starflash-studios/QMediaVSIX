// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnCustomComboBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2586056078, 56225, 19567, 130, 112, 220, 243, 201, 118, 28, 76)]
  [ExclusiveTo(typeof (VpnCustomComboBox))]
  internal interface IVpnCustomComboBox : IVpnCustomPrompt
  {
    IVectorView<string> OptionsText { set; get; }

    uint Selected { get; }
  }
}
