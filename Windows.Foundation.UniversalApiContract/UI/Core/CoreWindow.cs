// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CoreWindow
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Core
{
  /// <summary>Represents the UWP app with input events and basic user interface behaviors.</summary>
  [Muse(Version = 100794368)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Static(typeof (ICoreWindowStatic), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CoreWindow : 
    ICoreWindow,
    ICoreWindow2,
    ICorePointerRedirector,
    ICoreWindow3,
    ICoreWindow4,
    ICoreWindow5,
    ICoreWindowWithContext
  {
    /// <summary>Gets the automation provider assigned to this window.</summary>
    /// <returns>The automation provider for this window.</returns>
    public extern object AutomationHostProvider { [MethodImpl] get; }

    /// <summary>Gets the bounding rectangle of the window.</summary>
    /// <returns>The bounding rectangle of the window, in device-independent pixels (DIPs).</returns>
    public extern Rect Bounds { [MethodImpl] get; }

    /// <summary>Gets the set of custom properties for the window.</summary>
    /// <returns>The set of custom properties for the window, represented as tuples.</returns>
    public extern IPropertySet CustomProperties { [MethodImpl] get; }

    /// <summary>Gets the event dispatcher for the window.</summary>
    /// <returns>The event dispatcher for the window.</returns>
    public extern CoreDispatcher Dispatcher { [MethodImpl] get; }

    /// <summary>Gets or sets the horizontal origin of the window's reading order alignment. If the language specified by the user interface is right-aligned (such as in Arabic or Hebrew), the horizontal origin of the reading layout for the window is on the right edge.</summary>
    /// <returns>The flow direction of the window's reading layout.</returns>
    public extern CoreWindowFlowDirection FlowDirection { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether input is enabled for the app.</summary>
    /// <returns>True if input is enabled for the app; false if it is disabled.</returns>
    public extern bool IsInputEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the cursor used by the app.</summary>
    /// <returns>The app's cursor.</returns>
    public extern CoreCursor PointerCursor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the client coordinates of the pointer.</summary>
    /// <returns>The position of the pointer in device-independent pixel (DIP).</returns>
    public extern Point PointerPosition { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the window is visible.</summary>
    /// <returns>True if the window is visible on the screen; false if it is not.</returns>
    public extern bool Visible { [MethodImpl] get; }

    /// <summary>Activates the window. This method is called to present the window on the screen.</summary>
    [MethodImpl]
    public extern void Activate();

    /// <summary>Closes a secondary window and exits the message loop.</summary>
    [MethodImpl]
    public extern void Close();

    /// <summary>Asynchronously retrieves the state of a virtual key.</summary>
    /// <param name="virtualKey">The virtual key for which state is returned.</param>
    /// <returns>The flags indicating the current state of the supplied virtual key when the input event fired.</returns>
    [MethodImpl]
    public extern CoreVirtualKeyStates GetAsyncKeyState(VirtualKey virtualKey);

    /// <summary>Retrieves the state of a virtual key.</summary>
    /// <param name="virtualKey">The virtual key for which state is returned.</param>
    /// <returns>The flags indicating the current state of the supplied virtual key when the input event fired.</returns>
    [MethodImpl]
    public extern CoreVirtualKeyStates GetKeyState(VirtualKey virtualKey);

    /// <summary>Dissociates pointer input from the app, if previously associated through SetPointerCapture, and restores normal pointer input processing.</summary>
    [MethodImpl]
    public extern void ReleasePointerCapture();

    /// <summary>Associates pointer input with the app. Once a pointer is captured, all subsequent events associated with that pointer are fired by the app.</summary>
    [MethodImpl]
    public extern void SetPointerCapture();

    /// <summary>Is fired when the window completes activation or deactivation.</summary>
    public extern event TypedEventHandler<CoreWindow, WindowActivatedEventArgs> Activated;

    /// <summary>Is fired when a request for an automation handler is generated.</summary>
    public extern event TypedEventHandler<CoreWindow, AutomationProviderRequestedEventArgs> AutomationProviderRequested;

    /// <summary>Is fired when a new character is received by the input queue.</summary>
    public extern event TypedEventHandler<CoreWindow, CharacterReceivedEventArgs> CharacterReceived;

    /// <summary>Is fired when the app terminates.</summary>
    public extern event TypedEventHandler<CoreWindow, CoreWindowEventArgs> Closed;

    /// <summary>Occurs when input is enabled or disabled for the app.</summary>
    public extern event TypedEventHandler<CoreWindow, InputEnabledEventArgs> InputEnabled;

    /// <summary>Is fired when a non-system key is pressed.</summary>
    public extern event TypedEventHandler<CoreWindow, KeyEventArgs> KeyDown;

    /// <summary>Is fired when a non-system key is released after a press.</summary>
    public extern event TypedEventHandler<CoreWindow, KeyEventArgs> KeyUp;

    /// <summary>Occurs when a pointer moves to another app. This event is raised after PointerExited and is the final event received by the app for this pointer.</summary>
    public extern event TypedEventHandler<CoreWindow, PointerEventArgs> PointerCaptureLost;

    /// <summary>Occurs when a pointer moves into the bounding box of the app.</summary>
    public extern event TypedEventHandler<CoreWindow, PointerEventArgs> PointerEntered;

    /// <summary>Occurs when the pointer moves outside the bounding box of the app.</summary>
    public extern event TypedEventHandler<CoreWindow, PointerEventArgs> PointerExited;

    /// <summary>Occurs when a pointer moves within the bounding box of the app.</summary>
    public extern event TypedEventHandler<CoreWindow, PointerEventArgs> PointerMoved;

    /// <summary>Occurs when a mouse button is clicked, or the digitizer surface has been touched by a finger or pen, within the bounding rectangle of the app.</summary>
    public extern event TypedEventHandler<CoreWindow, PointerEventArgs> PointerPressed;

    /// <summary>Occurs when a pressed mouse button is released, or a touch or pen contact is lifted from the digitizer surface, within the bounding rectangle of the app (or outside the bounding rectangle, if the pointer is captured).</summary>
    public extern event TypedEventHandler<CoreWindow, PointerEventArgs> PointerReleased;

    /// <summary>Occurs when a touch contact area intersects the bounding rectangle (or polygon) of a window that is registered for touch hit testing.</summary>
    public extern event TypedEventHandler<CoreWindow, TouchHitTestingEventArgs> TouchHitTesting;

    /// <summary>Occurs when the wheel button is rotated.</summary>
    public extern event TypedEventHandler<CoreWindow, PointerEventArgs> PointerWheelChanged;

    /// <summary>Occurs when the window size is changed.</summary>
    public extern event TypedEventHandler<CoreWindow, WindowSizeChangedEventArgs> SizeChanged;

    /// <summary>Is fired when the window visibility is changed.</summary>
    public extern event TypedEventHandler<CoreWindow, VisibilityChangedEventArgs> VisibilityChanged;

    /// <summary>Occurs on the process receiving input when the pointer input is routed to another process.</summary>
    public extern event TypedEventHandler<ICorePointerRedirector, PointerEventArgs> PointerRoutedAway;

    /// <summary>Occurs on the process not currently receiving input, but designated to begin receiving input from another process.</summary>
    public extern event TypedEventHandler<ICorePointerRedirector, PointerEventArgs> PointerRoutedTo;

    /// <summary>Occurs on a process associated with, but not currently receiving input from, a pointer that fires a PointerReleased event on a different process.</summary>
    public extern event TypedEventHandler<ICorePointerRedirector, PointerEventArgs> PointerRoutedReleased;

    /// <summary>Occurs when a framework input manager requests the bounding rectangle of an interactive element within a specific bounding rectangle and closest to a specific pointer.</summary>
    public extern event TypedEventHandler<CoreWindow, ClosestInteractiveBoundsRequestedEventArgs> ClosestInteractiveBoundsRequested;

    /// <summary>Retrieves the unique ID for the input device that generated this key event.</summary>
    /// <returns>A unique identifier for the input device associated with the key event, or an empty string. The same device can be assigned a different ID each time it is connected.</returns>
    [MethodImpl]
    public extern string GetCurrentKeyEventDeviceId();

    /// <summary>Occurs when a user starts to resize the window.</summary>
    public extern event TypedEventHandler<CoreWindow, object> ResizeStarted;

    /// <summary>Occurs when a user finishes resizing the window.</summary>
    public extern event TypedEventHandler<CoreWindow, object> ResizeCompleted;

    /// <summary>Gets the **DispatcherQueue** for the window.</summary>
    /// <returns>The **DispatcherQueue**.</returns>
    public extern DispatcherQueue DispatcherQueue { [MethodImpl] get; }

    /// <summary>Gets a value that indicates the activation state of the window.</summary>
    /// <returns>A value that indicates the activation state of the window.</returns>
    public extern CoreWindowActivationMode ActivationMode { [MethodImpl] get; }

    /// <summary>Gets the context identifier for the core window.</summary>
    /// <returns>The context identifier for the core window.</returns>
    public extern UIContext UIContext { [MethodImpl] get; }

    /// <summary>Gets the CoreWindow instance for the currently active thread.</summary>
    /// <returns>The CoreWindow for the currently active thread.</returns>
    [MethodImpl]
    public static extern CoreWindow GetForCurrentThread();
  }
}
