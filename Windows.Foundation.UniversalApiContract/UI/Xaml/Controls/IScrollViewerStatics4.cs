// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IScrollViewerStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(571275212, 20294, 23025, 175, 155, 103, 250, 142, 179, 61, 1)]
  [ExclusiveTo(typeof (ScrollViewer))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  internal interface IScrollViewerStatics4
  {
    DependencyProperty ReduceViewportForCoreInputViewOcclusionsProperty { get; }

    DependencyProperty HorizontalAnchorRatioProperty { get; }

    DependencyProperty VerticalAnchorRatioProperty { get; }

    DependencyProperty CanContentRenderOutsideBoundsProperty { get; }

    bool GetCanContentRenderOutsideBounds(DependencyObject element);

    void SetCanContentRenderOutsideBounds(
      DependencyObject element,
      bool canContentRenderOutsideBounds);
  }
}
