// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IListViewItemPresenter3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (ListViewItemPresenter))]
  [Guid(912392211, 912, 20016, 173, 151, 135, 68, 64, 79, 112, 16)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  internal interface IListViewItemPresenter3
  {
    Brush RevealBackground { get; set; }

    Brush RevealBorderBrush { get; set; }

    Thickness RevealBorderThickness { get; set; }

    bool RevealBackgroundShowsAboveContent { get; set; }
  }
}
