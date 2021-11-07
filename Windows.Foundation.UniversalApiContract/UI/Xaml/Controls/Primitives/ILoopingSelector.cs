// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ILoopingSelector
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(1285176836, 18471, 18905, 136, 6, 9, 57, 87, 176, 253, 33)]
  [ExclusiveTo(typeof (LoopingSelector))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILoopingSelector
  {
    bool ShouldLoop { get; set; }

    IVector<object> Items { get; set; }

    int SelectedIndex { get; set; }

    object SelectedItem { get; set; }

    int ItemWidth { get; set; }

    int ItemHeight { get; set; }

    DataTemplate ItemTemplate { get; set; }

    event SelectionChangedEventHandler SelectionChanged;
  }
}
