// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPivot
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Pivot))]
  [Guid(272538387, 13312, 18966, 144, 185, 105, 18, 191, 6, 151, 78)]
  internal interface IPivot
  {
    object Title { get; set; }

    DataTemplate TitleTemplate { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    int SelectedIndex { get; set; }

    object SelectedItem { get; set; }

    bool IsLocked { get; set; }

    event SelectionChangedEventHandler SelectionChanged;

    event TypedEventHandler<Pivot, PivotItemEventArgs> PivotItemLoading;

    event TypedEventHandler<Pivot, PivotItemEventArgs> PivotItemLoaded;

    event TypedEventHandler<Pivot, PivotItemEventArgs> PivotItemUnloading;

    event TypedEventHandler<Pivot, PivotItemEventArgs> PivotItemUnloaded;
  }
}
