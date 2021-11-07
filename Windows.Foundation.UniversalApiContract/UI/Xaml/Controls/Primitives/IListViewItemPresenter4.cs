// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IListViewItemPresenter4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ListViewItemPresenter))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(3663727297, 44522, 22848, 161, 143, 87, 88, 47, 150, 217, 154)]
  internal interface IListViewItemPresenter4
  {
    Brush SelectedDisabledBackground { get; set; }

    Brush CheckPressedBrush { get; set; }

    Brush CheckDisabledBrush { get; set; }

    Brush CheckBoxPointerOverBrush { get; set; }

    Brush CheckBoxPressedBrush { get; set; }

    Brush CheckBoxDisabledBrush { get; set; }

    Brush CheckBoxSelectedBrush { get; set; }

    Brush CheckBoxSelectedPointerOverBrush { get; set; }

    Brush CheckBoxSelectedPressedBrush { get; set; }

    Brush CheckBoxSelectedDisabledBrush { get; set; }

    Brush CheckBoxBorderBrush { get; set; }

    Brush CheckBoxPointerOverBorderBrush { get; set; }

    Brush CheckBoxPressedBorderBrush { get; set; }

    Brush CheckBoxDisabledBorderBrush { get; set; }

    CornerRadius CheckBoxCornerRadius { get; set; }

    CornerRadius SelectionIndicatorCornerRadius { get; set; }

    bool SelectionIndicatorVisualEnabled { get; set; }

    ListViewItemPresenterSelectionIndicatorMode SelectionIndicatorMode { get; set; }

    Brush SelectionIndicatorBrush { get; set; }

    Brush SelectionIndicatorPointerOverBrush { get; set; }

    Brush SelectionIndicatorPressedBrush { get; set; }

    Brush SelectionIndicatorDisabledBrush { get; set; }

    Brush SelectedBorderBrush { get; set; }

    Brush SelectedPressedBorderBrush { get; set; }

    Brush SelectedDisabledBorderBrush { get; set; }

    Brush SelectedInnerBorderBrush { get; set; }

    Brush PointerOverBorderBrush { get; set; }
  }
}
