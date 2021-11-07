// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IComboBox3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ComboBox))]
  [WebHostHidden]
  [Guid(1379928675, 18284, 19382, 183, 129, 1, 147, 36, 211, 254, 217)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IComboBox3
  {
    LightDismissOverlayMode LightDismissOverlayMode { get; set; }

    bool IsTextSearchEnabled { get; set; }
  }
}
