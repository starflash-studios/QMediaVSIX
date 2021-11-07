// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Frame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Displays Page instances, supports navigation to new pages, and maintains a navigation history to support forward and backward navigation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IFrameStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IFrameStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IFrameStatics5), 458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IFrameFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class Frame : ContentControl, IFrame, IFrame2, IFrame3, IFrame4, IFrame5, INavigate
  {
    /// <summary>Initializes a new instance of the Frame class.</summary>
    [MethodImpl]
    public extern Frame();

    /// <summary>Gets or sets the number of pages in the navigation history that can be cached for the frame.</summary>
    /// <returns>The number of pages that can be in the navigation history.</returns>
    public extern int CacheSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether there is at least one entry in back navigation history.</summary>
    /// <returns>**true** if there is at least one entry in back navigation history; **false** if there are no entries in back navigation history or the Frame does not own its own navigation history.</returns>
    public extern bool CanGoBack { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether there is at least one entry in forward navigation history.</summary>
    /// <returns>**true** if there is at least one entry in forward navigation history; **false** if there are no entries in forward navigation history or the Frame does not own its own navigation history.</returns>
    public extern bool CanGoForward { [MethodImpl] get; }

    /// <summary>Gets a type reference for the content that is currently displayed.</summary>
    /// <returns>A type reference for the content that is currently displayed.</returns>
    public extern TypeName CurrentSourcePageType { [MethodImpl] get; }

    /// <summary>Gets or sets a type reference of the current content, or the content that should be navigated to.</summary>
    /// <returns>A type reference for the current content, or the content to navigate to.</returns>
    public extern TypeName SourcePageType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the number of entries in the navigation back stack.</summary>
    /// <returns>The number of entries in the navigation back stack.</returns>
    public extern int BackStackDepth { [MethodImpl] get; }

    /// <summary>Occurs when the content that is being navigated to has been found and is available from the Content property, although it may not have completed loading.</summary>
    public extern event NavigatedEventHandler Navigated;

    /// <summary>Occurs when a new navigation is requested.</summary>
    public extern event NavigatingCancelEventHandler Navigating;

    /// <summary>Occurs when an error is raised while navigating to the requested content.</summary>
    public extern event NavigationFailedEventHandler NavigationFailed;

    /// <summary>Occurs when </summary>
    public extern event NavigationStoppedEventHandler NavigationStopped;

    /// <summary>Navigates to the most recent item in back navigation history, if a Frame manages its own navigation history.</summary>
    [MethodImpl]
    public extern void GoBack();

    /// <summary>Navigates to the most recent item in forward navigation history, if a Frame manages its own navigation history.</summary>
    [MethodImpl]
    public extern void GoForward();

    [MethodImpl]
    public extern bool Navigate(TypeName sourcePageType, object parameter);

    /// <summary>Serializes the Frame navigation history into a string.</summary>
    /// <returns>The string-form serialized navigation history. See Remarks.</returns>
    [MethodImpl]
    public extern string GetNavigationState();

    /// <summary>Reads and restores the navigation history of a Frame from a provided serialization string.</summary>
    /// <param name="navigationState">The serialization string that supplies the restore point for navigation history.</param>
    [Overload("SetNavigationState")]
    [MethodImpl]
    public extern void SetNavigationState(string navigationState);

    /// <summary>Gets a collection of PageStackEntry instances representing the backward navigation history of the Frame.</summary>
    /// <returns>The backward navigation stack.</returns>
    public extern IVector<PageStackEntry> BackStack { [MethodImpl] get; }

    /// <summary>Gets a collection of PageStackEntry instances representing the forward navigation history of the Frame.</summary>
    /// <returns>The forward navigation stack.</returns>
    public extern IVector<PageStackEntry> ForwardStack { [MethodImpl] get; }

    [MethodImpl]
    public extern bool Navigate(
      TypeName sourcePageType,
      object parameter,
      NavigationTransitionInfo infoOverride);

    /// <summary>Navigates to the most recent item in back navigation history, if a Frame manages its own navigation history, and specifies the animated transition to use.</summary>
    /// <param name="transitionInfoOverride">Info about the animated transition to use.</param>
    [MethodImpl]
    public extern void GoBack(NavigationTransitionInfo transitionInfoOverride);

    /// <summary>Reads and restores the navigation history of a Frame from a provided serialization string.</summary>
    /// <param name="navigationState">The serialization string that supplies the restore point for navigation history.</param>
    /// <param name="suppressNavigate">**true** to restore navigation history without navigating to the current page; otherwise, **false**.</param>
    [Overload("SetNavigationStateWithNavigationControl")]
    [MethodImpl]
    public extern void SetNavigationState(string navigationState, bool suppressNavigate);

    /// <summary>Gets or sets a value that indicates whether navigation is recorded in the Frame's ForwardStack or BackStack.</summary>
    /// <returns>**true** if navigation is recorded in the Frame's ForwardStack or BackStack; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsNavigationStackEnabled { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern bool NavigateToType(
      TypeName sourcePageType,
      object parameter,
      FrameNavigationOptions navigationOptions);

    [MethodImpl]
    public extern bool Navigate(TypeName sourcePageType);

    /// <summary>Identifies the IsNavigationStackEnabled dependency property.</summary>
    /// <returns>The identifier for the IsNavigationStackEnabled dependency property.</returns>
    public static extern DependencyProperty IsNavigationStackEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the BackStack dependency property.</summary>
    /// <returns>The identifier for the BackStack dependency property.</returns>
    public static extern DependencyProperty BackStackProperty { [MethodImpl] get; }

    /// <summary>Identifies the ForwardStack dependency property.</summary>
    /// <returns>The identifier for the ForwardStack dependency property.</returns>
    public static extern DependencyProperty ForwardStackProperty { [MethodImpl] get; }

    /// <summary>Identifies the CacheSize dependency property.</summary>
    /// <returns>The identifier for the CacheSize dependency property.</returns>
    public static extern DependencyProperty CacheSizeProperty { [MethodImpl] get; }

    /// <summary>Identifies the CanGoBack dependency property.</summary>
    /// <returns>The identifier for the CanGoBack dependency property.</returns>
    public static extern DependencyProperty CanGoBackProperty { [MethodImpl] get; }

    /// <summary>Identifies the CanGoForward dependency property.</summary>
    /// <returns>The identifier for the CanGoForward dependency property.</returns>
    public static extern DependencyProperty CanGoForwardProperty { [MethodImpl] get; }

    /// <summary>Identifies the CurrentSourcePageType dependency property.</summary>
    /// <returns>The identifier for the CurrentSourcePageType dependency property.</returns>
    public static extern DependencyProperty CurrentSourcePageTypeProperty { [MethodImpl] get; }

    /// <summary>Identifies the SourcePageType dependency property.</summary>
    /// <returns>The identifier for the SourcePageType dependency property.</returns>
    public static extern DependencyProperty SourcePageTypeProperty { [MethodImpl] get; }

    /// <summary>Identifies the BackStackDepth dependency property.</summary>
    /// <returns>The identifier for the BackStackDepth dependency property.</returns>
    public static extern DependencyProperty BackStackDepthProperty { [MethodImpl] get; }
  }
}
