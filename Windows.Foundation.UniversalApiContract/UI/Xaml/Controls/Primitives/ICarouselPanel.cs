// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ICarouselPanel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(3735779506, 14139, 16721, 135, 133, 229, 68, 208, 217, 54, 43)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CarouselPanel))]
  internal interface ICarouselPanel
  {
    bool CanVerticallyScroll { get; set; }

    bool CanHorizontallyScroll { get; set; }

    double ExtentWidth { get; }

    double ExtentHeight { get; }

    double ViewportWidth { get; }

    double ViewportHeight { get; }

    double HorizontalOffset { get; }

    double VerticalOffset { get; }

    object ScrollOwner { get; set; }

    void LineUp();

    void LineDown();

    void LineLeft();

    void LineRight();

    void PageUp();

    void PageDown();

    void PageLeft();

    void PageRight();

    void MouseWheelUp();

    void MouseWheelDown();

    void MouseWheelLeft();

    void MouseWheelRight();

    void SetHorizontalOffset(double offset);

    void SetVerticalOffset(double offset);

    Rect MakeVisible(UIElement visual, Rect rectangle);
  }
}
