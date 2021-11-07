// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapItemsControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [Guid(2495792339, 45877, 17093, 182, 96, 230, 160, 126, 195, 189, 220)]
  [ExclusiveTo(typeof (MapItemsControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapItemsControl
  {
    object ItemsSource { get; set; }

    IVector<DependencyObject> Items { get; }

    DataTemplate ItemTemplate { get; set; }
  }
}
