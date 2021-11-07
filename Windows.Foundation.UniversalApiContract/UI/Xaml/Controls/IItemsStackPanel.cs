// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsStackPanel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(3749361565, 31445, 19288, 147, 99, 145, 154, 249, 2, 38, 230)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ItemsStackPanel))]
  internal interface IItemsStackPanel
  {
    Thickness GroupPadding { get; set; }

    Orientation Orientation { get; set; }

    int FirstCacheIndex { get; }

    int FirstVisibleIndex { get; }

    int LastVisibleIndex { get; }

    int LastCacheIndex { get; }

    PanelScrollingDirection ScrollingDirection { get; }

    GroupHeaderPlacement GroupHeaderPlacement { get; set; }

    ItemsUpdatingScrollMode ItemsUpdatingScrollMode { get; set; }

    double CacheLength { get; set; }
  }
}
