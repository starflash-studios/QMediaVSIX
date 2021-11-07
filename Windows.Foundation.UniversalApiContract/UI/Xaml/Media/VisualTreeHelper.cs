// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.VisualTreeHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Provides utility methods that can be used to traverse object relationships (along child-object or parent-object axes) in the visual tree of your app.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Static(typeof (IVisualTreeHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IVisualTreeHelperStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IVisualTreeHelperStatics3), 524288, "Windows.Foundation.UniversalApiContract")]
  public sealed class VisualTreeHelper : IVisualTreeHelper
  {
    /// <summary>Retrieves a collection of all open popup controls from the target XamlRoot.</summary>
    /// <param name="xamlRoot">The current XamlRoot instance to retrieve the popups from.</param>
    /// <returns>The list of all open popups. If no popups are open, the list is empty.</returns>
    [MethodImpl]
    public static extern IVectorView<Popup> GetOpenPopupsForXamlRoot(
      XamlRoot xamlRoot);

    /// <summary>Retrieves a collection of all open popup controls from the target Window.</summary>
    /// <param name="window">The current Window instance to retrieve the popups from.</param>
    /// <returns>The list of all open popups. If no popups are open, the list is empty.</returns>
    [MethodImpl]
    public static extern IVectorView<Popup> GetOpenPopups(Window window);

    /// <summary>Retrieves a set of objects that are located within a specified x-y coordinate point of an app UI. The set of objects represents the components of a visual tree that share that point.</summary>
    /// <param name="intersectingPoint">The point to use as the determination point. This point is using the coordinate space of the app window, not of any specific element (and not of *subtree* if specified).</param>
    /// <param name="subtree">An object to search for. If the *subtree* object exists in the overall set of elements that exist at the specified *intersectingPoint* coordinates, then the return value contains only the *subtree* object and any objects that have a higher z-order than *subtree*, listed by inverse of z-order. If the *subtree* object doesn't exist at *intersectingPoint* coordinates, the return value will be empty.</param>
    /// <returns>An enumerable set of UIElement objects in the visual tree composition at the specified point, listed by inverse of z-order.</returns>
    [Overload("FindElementsInHostCoordinatesPoint")]
    [DefaultOverload]
    [MethodImpl]
    public static extern IIterable<UIElement> FindElementsInHostCoordinates(
      Point intersectingPoint,
      UIElement subtree);

    /// <summary>Retrieves a set of objects that are located within a specified Rect frame of an app UI. The set of objects represents the components of a visual tree that share a rectangular area, and might include elements that overdraw.</summary>
    /// <param name="intersectingRect">The Rect to use as the determination area. This frame is using the coordinate space of the app window, not of any specific element (and not of *subtree* if specified).</param>
    /// <param name="subtree">An object to search for. If the *subtree* object exists in the overall set of elements that exist within the specified *intersectingRect*, then the return value contains only the *subtree* object and elements that are drawing on top of its space. If the *subtree* object doesn't exist within the *intersectingRect* frame, the return value will be empty.</param>
    /// <returns>An enumerable set of UIElement objects that are in the visual tree composition in the specified Rect frame.</returns>
    [Overload("FindElementsInHostCoordinatesRect")]
    [MethodImpl]
    public static extern IIterable<UIElement> FindElementsInHostCoordinates(
      Rect intersectingRect,
      UIElement subtree);

    /// <summary>Retrieves a set of objects that are located within a specified x-y coordinate point of an app UI. The set of objects represents the components of a visual tree that share that point.</summary>
    /// <param name="intersectingPoint">The point to use as the determination point. This point is using the coordinate space of the app window, not of any specific element (and not of *subtree* if specified).</param>
    /// <param name="subtree">An object to search for. If the *subtree* object exists in the overall set of elements that exist at the specified *intersectingPoint* coordinates, then the return value contains only the *subtree* object and any objects that have a higher z-order than *subtree*, listed by inverse of z-order. If the *subtree* object doesn't exist at *intersectingPoint* coordinates, the return value will be empty.</param>
    /// <param name="includeAllElements">**true** to include all elements that intersect, including those elements considered to be invisible to hit testing. **false** to find only visible, hit-testable elements. The default is **false**.</param>
    /// <returns>An enumerable set of UIElement objects that are determined to be located in the visual tree composition at the specified point, listed by inverse of z-order.</returns>
    [Overload("FindAllElementsInHostCoordinatesPoint")]
    [DefaultOverload]
    [MethodImpl]
    public static extern IIterable<UIElement> FindElementsInHostCoordinates(
      Point intersectingPoint,
      UIElement subtree,
      bool includeAllElements);

    /// <summary>Retrieves a set of objects that are located within a specified Rect frame of an app UI. The set of objects represents the components of a visual tree that share a rectangular area, and might include elements that overdraw.</summary>
    /// <param name="intersectingRect">The Rect to use as the determination area. This frame is using the coordinate space of the app window, not of any specific element (and not of *subtree* if specified).</param>
    /// <param name="subtree">An object to search for. If the *subtree* object exists in the overall set of elements that exist within the specified *intersectingRect*, then the return value contains only the *subtree* object and elements that are drawing on top of its space. If the *subtree* object doesn't exist within the *intersectingRect* frame, the return value will be empty.</param>
    /// <param name="includeAllElements">**true** to include all elements that intersect, including those elements considered to be invisible to hit testing. **false** to find only visible, hit-testable elements. The default is **false**.</param>
    /// <returns>An enumerable set of UIElement objects that are determined to be located in the visual tree composition in the specified Rect frame.</returns>
    [Overload("FindAllElementsInHostCoordinatesRect")]
    [MethodImpl]
    public static extern IIterable<UIElement> FindElementsInHostCoordinates(
      Rect intersectingRect,
      UIElement subtree,
      bool includeAllElements);

    /// <summary>Using the provided index, obtains a specific child object of the provided object by examining the visual tree.</summary>
    /// <param name="reference">The object that holds the child collection.</param>
    /// <param name="childIndex">The index of the requested child object in the *reference* child collection.</param>
    /// <returns>The child object as referenced by *childIndex*.</returns>
    [MethodImpl]
    public static extern DependencyObject GetChild(
      DependencyObject reference,
      int childIndex);

    /// <summary>Returns the number of children that exist in an object's child collection in the visual tree.</summary>
    /// <param name="reference">The source visual.</param>
    /// <returns>The number of visual children for the provided source visual.</returns>
    [MethodImpl]
    public static extern int GetChildrenCount(DependencyObject reference);

    /// <summary>Returns an object's parent object in the visual tree.</summary>
    /// <param name="reference">The object for which to get the parent object.</param>
    /// <returns>The parent object of the *reference* object in the visual tree.</returns>
    [MethodImpl]
    public static extern DependencyObject GetParent(DependencyObject reference);

    /// <summary>Explicitly removes all references from a target UIElement, with the goal of cleaning up reference cycles.</summary>
    /// <param name="element">The target object to disconnect children and remove references from.</param>
    [MethodImpl]
    public static extern void DisconnectChildrenRecursive(UIElement element);
  }
}
