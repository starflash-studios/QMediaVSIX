// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IListViewItemPresenterStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [Guid(3285438750, 64038, 19687, 164, 237, 255, 148, 143, 1, 183, 192)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (ListViewItemPresenter))]
  internal interface IListViewItemPresenterStatics3
  {
    DependencyProperty RevealBackgroundProperty { get; }

    DependencyProperty RevealBorderBrushProperty { get; }

    DependencyProperty RevealBorderThicknessProperty { get; }

    DependencyProperty RevealBackgroundShowsAboveContentProperty { get; }
  }
}
