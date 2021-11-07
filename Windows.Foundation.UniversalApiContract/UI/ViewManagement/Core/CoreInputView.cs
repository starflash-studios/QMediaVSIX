// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.CoreInputView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  /// <summary>Enables an app to receive notifications when a docked, undocked, moveable, or transitory input pane (and associated UI) is moved, displayed, or hidden, and to determine which portion of the app's window is obscured by the pane.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Static(typeof (ICoreInputViewStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 1)]
  [Static(typeof (ICoreInputViewStatics2), 524288, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CoreInputView : 
    ICoreInputView,
    ICoreInputView2,
    ICoreInputView3,
    ICoreInputView4,
    ICoreInputView5
  {
    /// <summary>Occurs when one or more CoreInputViewOcclusion objects change their position or occluding area.</summary>
    public extern event TypedEventHandler<CoreInputView, CoreInputViewOcclusionsChangedEventArgs> OcclusionsChanged;

    /// <summary>Retrieves a reference to each input pane currently occluding the app.</summary>
    /// <returns>A CoreInputViewOcclusion collection.</returns>
    [MethodImpl]
    public extern IVectorView<CoreInputViewOcclusion> GetCoreInputViewOcclusions();

    /// <summary>Attempts to show (if hidden) the CoreInputView pane.</summary>
    /// <returns>**true** if the request to show the input pane was accepted; otherwise **false**.</returns>
    [MethodImpl]
    public extern bool TryShowPrimaryView();

    /// <summary>Attempts to hide (if visible) the input pane associated with the CoreInputView.</summary>
    /// <returns>**true** if the request to show the input pane was accepted; otherwise **false**.</returns>
    [MethodImpl]
    public extern bool TryHidePrimaryView();

    /// <summary>Occurs before the input pane loses focus and before a UI element gets focus.</summary>
    public extern event TypedEventHandler<CoreInputView, CoreInputViewTransferringXYFocusEventArgs> XYFocusTransferringFromPrimaryView;

    /// <summary>Occurs when focus is moved to the input pane from the application UI.</summary>
    public extern event TypedEventHandler<CoreInputView, object> XYFocusTransferredToPrimaryView;

    /// <summary>Attempts to move focus from the application UI to the input pane.</summary>
    /// <param name="origin">The rectangle, in client coordinates, representing the previously focused UI element. Specified in device-independent pixels (DIP).</param>
    /// <param name="direction">The direction of navigation. If the input pane is not located in the specified direction, this method fails and returns false.</param>
    /// <returns>True, if the input pane received focus; otherwise, false.</returns>
    [MethodImpl]
    public extern bool TryTransferXYFocusToPrimaryView(
      Rect origin,
      CoreInputViewXYFocusTransferDirection direction);

    /// <summary>Attempts to show (if hidden) the input pane associated with the CoreInputView.</summary>
    /// <returns>**true** if the request to show the input pane was accepted; otherwise **false**.</returns>
    [Overload("TryShow")]
    [MethodImpl]
    public extern bool TryShow();

    /// <summary>Attempts to show (if hidden) the specified type of input pane associated with the CoreInputView.</summary>
    /// <param name="type">CoreInputViewKind</param>
    /// <returns>**true** if the request to show the input pane was accepted; otherwise **false**.</returns>
    [Overload("TryShowWithKind")]
    [MethodImpl]
    public extern bool TryShow(CoreInputViewKind type);

    /// <summary>Attempts to hide (if visible) the input pane associated with the CoreInputView pane.</summary>
    /// <returns>**true** if the request to show the input pane was accepted; otherwise **false**.</returns>
    [MethodImpl]
    public extern bool TryHide();

    /// <summary>Occurs before the input pane associated with the CoreInputView is shown (if hidden).</summary>
    public extern event TypedEventHandler<CoreInputView, CoreInputViewShowingEventArgs> PrimaryViewShowing;

    /// <summary>Occurs before the input pane associated with the CoreInputView is hidden (if visible).</summary>
    public extern event TypedEventHandler<CoreInputView, CoreInputViewHidingEventArgs> PrimaryViewHiding;

    [MethodImpl]
    public extern bool IsKindSupported(CoreInputViewKind type);

    public extern event TypedEventHandler<CoreInputView, object> SupportedKindsChanged;

    public extern event TypedEventHandler<CoreInputView, CoreInputViewAnimationStartingEventArgs> PrimaryViewAnimationStarting;

    /// <summary>Gets a CoreInputView object associated with the view with the specified context identifier.</summary>
    /// <param name="context">The context identifier of the view to get the CoreInputView for.</param>
    /// <returns>A CoreInputView for the specified context identifier.</returns>
    [MethodImpl]
    public static extern CoreInputView GetForUIContext(UIContext context);

    /// <summary>Retrieves the CoreInputView object associated with the current window.</summary>
    /// <returns>The CoreInputView object associated with the current window.</returns>
    [MethodImpl]
    public static extern CoreInputView GetForCurrentView();
  }
}
