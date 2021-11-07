// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Hosting.ElementCompositionPreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;
using Windows.UI.WindowManagement;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Hosting
{
  /// <summary>Enables access to composition visual objects that back XAML elements in the XAML composition tree.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IElementCompositionPreviewStatics3), 524288, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IElementCompositionPreviewStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Static(typeof (IElementCompositionPreviewStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class ElementCompositionPreview : IElementCompositionPreview
  {
    /// <summary>Sets a XAML UIElement as the content root of an AppWindow.</summary>
    /// <param name="appWindow">The AppWindow to set the content for.</param>
    /// <param name="xamlContent">The content to set.</param>
    [MethodImpl]
    public static extern void SetAppWindowContent(AppWindow appWindow, UIElement xamlContent);

    /// <summary>Retrieves the content root of an AppWindow.</summary>
    /// <param name="appWindow">The AppWindow to get the content from.</param>
    /// <returns>The content root of the AppWindow.</returns>
    [MethodImpl]
    public static extern UIElement GetAppWindowContent(AppWindow appWindow);

    /// <summary>Associates the specified show animation with a UIElement.</summary>
    /// <param name="element">The UIElement to associate the animation with.</param>
    /// <param name="animation">The animation to play when the UIElement is shown. A **Null** value prevents show animations from playing for this element until the method is called again with an animation value.</param>
    [MethodImpl]
    public static extern void SetImplicitShowAnimation(
      UIElement element,
      ICompositionAnimationBase animation);

    /// <summary>Associates the specified hide animation with a UIElement.</summary>
    /// <param name="element">The UIElement to associate the animation with.</param>
    /// <param name="animation">The animation to play when the UIElement is hidden. A **Null** value prevents hide animations from playing for this element until the method is called again with an animation value.</param>
    [MethodImpl]
    public static extern void SetImplicitHideAnimation(
      UIElement element,
      ICompositionAnimationBase animation);

    /// <summary>Toggles the ability to set, animate, and use a render-time post-layout translate transform to position XAML elements on screen using Composition APIs.</summary>
    /// <param name="element">The element on which to enable or disable translate transforms.</param>
    /// <param name="value">**true** to enable translate transforms; **false** to disable translate transforms.</param>
    [MethodImpl]
    public static extern void SetIsTranslationEnabled(UIElement element, bool value);

    /// <summary>Retrieves the pointer position relative to a UIElement.</summary>
    /// <param name="targetElement">The element that the pointer position is relative to.</param>
    /// <returns>The position properties of the pointer.</returns>
    [MethodImpl]
    public static extern CompositionPropertySet GetPointerPositionPropertySet(
      UIElement targetElement);

    /// <summary>Retrieves the Windows.UI.Composition.Visual object that backs a XAML element in the XAML composition tree.</summary>
    /// <param name="element">The element to retrieve the Visual for.</param>
    /// <returns>The Windows.UI.Composition.Visual object that backs the XAML element.</returns>
    [MethodImpl]
    public static extern Visual GetElementVisual(UIElement element);

    /// <summary>Retrieves a Windows.UI.Composition.Visual object previously set by a call to SetElementChildVisual.</summary>
    /// <param name="element">The element to retrieve the Visual for.</param>
    /// <returns>A Windows.UI.Composition.Visual object previously set by a call to SetElementChildVisual.</returns>
    [MethodImpl]
    public static extern Visual GetElementChildVisual(UIElement element);

    /// <summary>Sets a custom Windows.UI.Composition.Visual as the last child of the element’s visual tree.</summary>
    /// <param name="element">The element to add the child Visual to.</param>
    /// <param name="visual">The Visual to add to the element's visual tree.</param>
    [MethodImpl]
    public static extern void SetElementChildVisual(UIElement element, Visual visual);

    /// <summary>Retrieves the composition properties of a ScrollViewer element.</summary>
    /// <param name="scrollViewer">The ScrollViewer element to get the composition properties for.</param>
    /// <returns>The composition properties of the specified ScrollViewer.</returns>
    [MethodImpl]
    public static extern CompositionPropertySet GetScrollViewerManipulationPropertySet(
      ScrollViewer scrollViewer);
  }
}
