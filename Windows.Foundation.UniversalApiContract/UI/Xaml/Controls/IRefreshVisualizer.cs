// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRefreshVisualizer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(3236102434, 62443, 19370, 161, 31, 195, 248, 115, 66, 203, 244)]
  [ExclusiveTo(typeof (RefreshVisualizer))]
  [WebHostHidden]
  internal interface IRefreshVisualizer
  {
    void RequestRefresh();

    RefreshVisualizerOrientation Orientation { get; set; }

    UIElement Content { get; set; }

    RefreshVisualizerState State { get; }

    event TypedEventHandler<RefreshVisualizer, RefreshRequestedEventArgs> RefreshRequested;

    event TypedEventHandler<RefreshVisualizer, RefreshStateChangedEventArgs> RefreshStateChanged;
  }
}
