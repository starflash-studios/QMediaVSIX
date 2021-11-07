// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewBaseStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2234693879, 15894, 17755, 137, 168, 193, 52, 98, 35, 246, 211)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ListViewBase))]
  internal interface IListViewBaseStatics
  {
    DependencyProperty SelectionModeProperty { get; }

    DependencyProperty IsSwipeEnabledProperty { get; }

    DependencyProperty CanDragItemsProperty { get; }

    DependencyProperty CanReorderItemsProperty { get; }

    DependencyProperty IsItemClickEnabledProperty { get; }

    DependencyProperty DataFetchSizeProperty { get; }

    DependencyProperty IncrementalLoadingThresholdProperty { get; }

    DependencyProperty IncrementalLoadingTriggerProperty { get; }

    DependencyProperty SemanticZoomOwnerProperty { get; }

    DependencyProperty IsActiveViewProperty { get; }

    DependencyProperty IsZoomedInViewProperty { get; }

    DependencyProperty HeaderProperty { get; }

    DependencyProperty HeaderTemplateProperty { get; }

    DependencyProperty HeaderTransitionsProperty { get; }
  }
}
