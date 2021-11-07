// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IPopup4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 917504)]
  [ExclusiveTo(typeof (Popup))]
  [Guid(410040374, 57135, 24518, 165, 242, 116, 142, 214, 206, 115, 33)]
  [WebHostHidden]
  internal interface IPopup4
  {
    FrameworkElement PlacementTarget { get; set; }

    PopupPlacementMode DesiredPlacement { get; set; }

    PopupPlacementMode ActualPlacement { get; }

    event EventHandler<object> ActualPlacementChanged;
  }
}
