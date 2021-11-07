// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Hosting.IElementCompositionPreviewStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Hosting
{
  [ExclusiveTo(typeof (ElementCompositionPreview))]
  [Guid(147401528, 60569, 19541, 188, 133, 161, 193, 128, 178, 118, 70)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IElementCompositionPreviewStatics
  {
    Visual GetElementVisual(UIElement element);

    Visual GetElementChildVisual(UIElement element);

    void SetElementChildVisual(UIElement element, Visual visual);

    CompositionPropertySet GetScrollViewerManipulationPropertySet(
      ScrollViewer scrollViewer);
  }
}
