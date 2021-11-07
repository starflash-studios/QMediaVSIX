// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.FocusManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>A helper class that enables global management of focus actions and events across all elements in an application.</summary>
  [Static(typeof (IFocusManagerStatics6), 458752, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IFocusManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IFocusManagerStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IFocusManagerStatics5), 393216, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IFocusManagerStatics7), 524288, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IFocusManagerStatics4), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IFocusManagerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class FocusManager : IFocusManager
  {
    /// <summary>Retrieves the focused element within the Xaml island container.</summary>
    /// <param name="xamlRoot">
    /// </param>
    /// <returns>The object that has focus. Typically, this is a Control class.</returns>
    [Overload("GetFocusedElement")]
    [MethodImpl]
    public static extern object GetFocusedElement(XamlRoot xamlRoot);

    /// <summary>Occurs when an element within a container element (a focus scope) receives focus. This event is raised asynchronously, so focus might move before bubbling is complete.</summary>
    public static extern event EventHandler<FocusManagerGotFocusEventArgs> GotFocus;

    /// <summary>Occurs when an element within a container element (a focus scope) loses focus. This event is raised asynchronously, so focus might move again before bubbling is complete.</summary>
    public static extern event EventHandler<FocusManagerLostFocusEventArgs> LostFocus;

    /// <summary>Occurs before an element actually receives focus. This event is raised synchronously to ensure focus isn't moved while the event is bubbling.</summary>
    public static extern event EventHandler<GettingFocusEventArgs> GettingFocus;

    /// <summary>Occurs before focus moves from the current element with focus to the target element. This event is raised synchronously to ensure focus isn't moved while the event is bubbling.</summary>
    public static extern event EventHandler<LosingFocusEventArgs> LosingFocus;

    /// <summary>Asynchronously attempts to set focus on an element when the application is initialized.</summary>
    /// <param name="element">The object on which to set focus.</param>
    /// <param name="value">One of the values from the FocusState enumeration that specify how an elemnent can obtain focus.</param>
    /// <returns>The FocusMovementResult that indicates whether focus was successfully set.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<FocusMovementResult> TryFocusAsync(
      DependencyObject element,
      FocusState value);

    /// <summary>Asynchronously attempts to change focus from the current element with focus to the next focusable element in the specified direction.</summary>
    /// <param name="focusNavigationDirection">The direction that focus moves from element to element within the app UI.</param>
    /// <returns>The FocusMovementResult that indicates whether focus was successfully set.</returns>
    [RemoteAsync]
    [Overload("TryMoveFocusAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<FocusMovementResult> TryMoveFocusAsync(
      FocusNavigationDirection focusNavigationDirection);

    /// <summary>Asynchronously attempts to change focus from the current element with focus to the next focusable element in the specified direction and subject to the specified navigation options.</summary>
    /// <param name="focusNavigationDirection">The direction that focus moves from element to element within the app UI.</param>
    /// <param name="focusNavigationOptions">The navigation options used to identify the focus candidate.</param>
    /// <returns>The FocusMovementResult that indicates whether focus was successfully set.</returns>
    [Overload("TryMoveFocusWithOptionsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<FocusMovementResult> TryMoveFocusAsync(
      FocusNavigationDirection focusNavigationDirection,
      FindNextElementOptions focusNavigationOptions);

    /// <summary>Attempts to change focus from the element with focus to the next focusable element in the specified direction, using the specified navigation options.</summary>
    /// <param name="focusNavigationDirection">The direction to traverse (in tab order).</param>
    /// <param name="focusNavigationOptions">The options to help identify the next element to receive focus with keyboard/controller/remote navigation.</param>
    /// <returns>**true** if focus moved; otherwise, **false**.</returns>
    [Overload("TryMoveFocusWithOptions")]
    [MethodImpl]
    public static extern bool TryMoveFocus(
      FocusNavigationDirection focusNavigationDirection,
      FindNextElementOptions focusNavigationOptions);

    /// <summary>Retrieves the element that should receive focus based on the specified navigation direction.</summary>
    /// <param name="focusNavigationDirection">The direction that focus moves from element to element within the app UI.</param>
    /// <returns>The next object to receive focus.</returns>
    [Overload("FindNextElement")]
    [MethodImpl]
    public static extern DependencyObject FindNextElement(
      FocusNavigationDirection focusNavigationDirection);

    /// <summary>Retrieves the first element that can receive focus based on the specified scope.</summary>
    /// <param name="searchScope">The root object from which to search. If **null**, the search scope is the current window.</param>
    /// <returns>The first focusable object.</returns>
    [MethodImpl]
    public static extern DependencyObject FindFirstFocusableElement(
      DependencyObject searchScope);

    /// <summary>Retrieves the last element that can receive focus based on the specified scope.</summary>
    /// <param name="searchScope">The root object from which to search. If **null**, the search scope is the current window.</param>
    /// <returns>The last focusable object.</returns>
    [MethodImpl]
    public static extern DependencyObject FindLastFocusableElement(
      DependencyObject searchScope);

    /// <summary>Retrieves the element that should receive focus based on the specified navigation direction (cannot be used with tab navigation, see remarks).</summary>
    /// <param name="focusNavigationDirection">The direction that focus moves from element to element within the app UI.</param>
    /// <param name="focusNavigationOptions">The options to help identify the next element to receive focus with keyboard/controller/remote navigation.</param>
    /// <returns>The next object to receive focus.</returns>
    [Overload("FindNextElementWithOptions")]
    [MethodImpl]
    public static extern DependencyObject FindNextElement(
      FocusNavigationDirection focusNavigationDirection,
      FindNextElementOptions focusNavigationOptions);

    /// <summary>Retrieves the element that should receive focus based on the specified navigation direction.</summary>
    /// <param name="focusNavigationDirection">The direction that focus moves from element to element within the application UI.</param>
    /// <returns>**null** if focus cannot be set in the specified direction.</returns>
    [Overload("FindNextFocusableElement")]
    [MethodImpl]
    public static extern UIElement FindNextFocusableElement(
      FocusNavigationDirection focusNavigationDirection);

    /// <summary>Retrieves the element that should receive focus based on the specified navigation direction and hint rectangle.</summary>
    /// <param name="focusNavigationDirection">The direction that focus moves from element to element within the app UI.</param>
    /// <param name="hintRect">A bounding rectangle used to influence which element is most likely to be considered the next to receive focus. Examples where this can be useful include:</param>
    /// <returns>**null** if focus cannot be set in the specified direction.</returns>
    [Overload("FindNextFocusableElementWithHint")]
    [MethodImpl]
    public static extern UIElement FindNextFocusableElement(
      FocusNavigationDirection focusNavigationDirection,
      Rect hintRect);

    /// <summary>Attempts to change focus from the element with focus to the next focusable element in the specified direction.</summary>
    /// <param name="focusNavigationDirection">The direction to traverse (in tab order).</param>
    /// <returns>**true** if focus moved; otherwise, **false**.</returns>
    [Overload("TryMoveFocus")]
    [MethodImpl]
    public static extern bool TryMoveFocus(FocusNavigationDirection focusNavigationDirection);

    /// <summary>Retrieves the element in the UI that has focus.</summary>
    /// <returns>The object that has focus. Typically, this is a Control class.</returns>
    [MethodImpl]
    public static extern object GetFocusedElement();
  }
}
