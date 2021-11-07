// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IPopup2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(929729612, 43712, 19232, 150, 106, 11, 147, 100, 254, 180, 181)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Popup))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPopup2
  {
    LightDismissOverlayMode LightDismissOverlayMode { get; set; }
  }
}
