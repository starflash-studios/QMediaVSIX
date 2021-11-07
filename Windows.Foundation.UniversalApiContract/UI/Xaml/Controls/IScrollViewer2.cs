// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IScrollViewer2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1693040144, 19921, 18765, 171, 247, 203, 211, 197, 119, 73, 29)]
  [ExclusiveTo(typeof (ScrollViewer))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IScrollViewer2
  {
    UIElement TopLeftHeader { get; set; }

    UIElement LeftHeader { get; set; }

    UIElement TopHeader { get; set; }

    event EventHandler<ScrollViewerViewChangingEventArgs> ViewChanging;

    [Overload("ChangeView")]
    bool ChangeView(
      IReference<double> horizontalOffset,
      IReference<double> verticalOffset,
      IReference<float> zoomFactor);

    [Overload("ChangeViewWithOptionalAnimation")]
    bool ChangeView(
      IReference<double> horizontalOffset,
      IReference<double> verticalOffset,
      IReference<float> zoomFactor,
      bool disableAnimation);
  }
}
