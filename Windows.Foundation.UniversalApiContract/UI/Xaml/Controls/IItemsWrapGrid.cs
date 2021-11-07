// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsWrapGrid
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3724438367, 47752, 19069, 138, 91, 229, 140, 175, 15, 78, 45)]
  [ExclusiveTo(typeof (ItemsWrapGrid))]
  internal interface IItemsWrapGrid
  {
    Thickness GroupPadding { get; set; }

    Orientation Orientation { get; set; }

    int MaximumRowsOrColumns { get; set; }

    double ItemWidth { get; set; }

    double ItemHeight { get; set; }

    int FirstCacheIndex { get; }

    int FirstVisibleIndex { get; }

    int LastVisibleIndex { get; }

    int LastCacheIndex { get; }

    PanelScrollingDirection ScrollingDirection { get; }

    GroupHeaderPlacement GroupHeaderPlacement { get; set; }

    double CacheLength { get; set; }
  }
}
