// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreWindow
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Core
{
  /// <summary>Specifies an interface for a window object and its input events as well as basic user interface behaviors.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2042222066, 34718, 19337, 183, 152, 121, 228, 117, 152, 3, 12)]
  public interface ICoreWindow
  {
    /// <summary>Specifies the property that gets the automation provider assigned to this window.</summary>
    /// <returns>The automation provider for this window.</returns>
    object AutomationHostProvider { get; }

    /// <summary>Specifies the property that gets the bounding rectangle of the window.</summary>
    /// <returns>The bounding rectangle of the window, in device-independent pixel (DIP).</returns>
    Rect Bounds { get; }

    /// <summary>Specifies a property that gets the set of custom properties for the window.</summary>
    /// <returns>The set of custom properties for the window, represented as tuples.</returns>
    IPropertySet CustomProperties { get; }

    /// <summary>Specifies a property that gets the event dispatcher for the window.</summary>
    /// <returns>The event dispatcher for the window.</returns>
    CoreDispatcher Dispatcher { get; }

    /// <summary>Specifies the property that gets or sets the horizontal origin of the window's reading order alignment. If the language specified by the user interface is right-aligned (such as in Arabic or Hebrew), the horizontal origin of the reading layout for the window is on the right edge.</summary>
    /// <returns>The flow direction of the window's reading layout.</returns>
    CoreWindowFlowDirection FlowDirection { get; set; }

    /// <summary>Specifies a property that gets or sets whether input is enabled for the window.</summary>
    /// <returns>True if input is enabled for the window; false if it is disabled.</returns>
    bool IsInputEnabled { get; set; }

    /// <summary>Specifies a property that gets or sets the cursor used by the window.</summary>
    /// <returns>The window's cursor.</returns>
    CoreCursor PointerCursor { get; set; }

    /// <summary>Specifies a property that gets the position of the pointer.</summary>
    /// <returns>The current position of the cursor in device-independent pixels (DIPs).</returns>
    Point PointerPosition { get; }

    /// <summary>Specifies the property that gets whether the window is visible or not.</summary>
    /// <returns>True if the window is visible on the screen; false if it is not.</returns>
    bool Visible { get; }

    /// <summary>Specifies a method that activates the window. This method is called to present the window on the screen.</summary>
    void Activate();

    /// <summary>Specifies the method that closes the window and exits the message loop.</summary>
    void Close();

    /// <summary>Specifies a method that returns the state of a virtual key asynchronously.</summary>
    /// <param name="virtualKey">The virtual key for which state will be returned.</param>
    /// <returns>The state of the supplied virtual key when the input event was raised.</returns>
    CoreVirtualKeyStates GetAsyncKeyState(VirtualKey virtualKey);

    /// <summary>Specifies a method that gets the state of a key.</summary>
    /// <param name="virtualKey">The virtual key for which state will be returned.</param>
    /// <returns>The state of the supplied virtual key when the input event was raised.</returns>
    CoreVirtualKeyStates GetKeyState(VirtualKey virtualKey);

    /// <summary>Specifies a method that dissociates pointer input from the app, if previously associated through SetPointerCapture, and restores normal pointer input processing.</summary>
    void ReleasePointerCapture();

    /// <summary>Specifies a method that associates pointer input with the app. Once a pointer is captured, all subsequent events associated with that pointer are fired by the app.</summary>
    void SetPointerCapture();

    /// <summary>Specifies the event that is fired when the window completes activation or deactivation.</summary>
    event TypedEventHandler<CoreWindow, WindowActivatedEventArgs> Activated;

    /// <summary>Specifies the event that is fired when a request for an automation handler is generated.</summary>
    event TypedEventHandler<CoreWindow, AutomationProviderRequestedEventArgs> AutomationProviderRequested;

    /// <summary>Specifies the event that is fired when a new character is received by the input queue.</summary>
    event TypedEventHandler<CoreWindow, CharacterReceivedEventArgs> CharacterReceived;

    /// <summary>Specifies the event that is fired when a window is closed (or the app terminates altogether).</summary>
    event TypedEventHandler<CoreWindow, CoreWindowEventArgs> Closed;

    /// <summary>Specifies an event that occurs when input is enabled or disabled for the window.</summary>
    event TypedEventHandler<CoreWindow, InputEnabledEventArgs> InputEnabled;

    /// <summary>Specifies the event that is fired when a non-system key is pressed down.</summary>
    event TypedEventHandler<CoreWindow, KeyEventArgs> KeyDown;

    /// <summary>Specifies the event that is fired when a non-system key is released after a press.</summary>
    event TypedEventHandler<CoreWindow, KeyEventArgs> KeyUp;

    /// <summary>Specifies the event that occurs when a pointer moves to another window. This event is fired after PointerExited and is the final pointer event that is raised for a window.</summary>
    event TypedEventHandler<CoreWindow, PointerEventArgs> PointerCaptureLost;

    /// <summary>Specifies the event that occurs when a pointer moves into the bounding box of the window.</summary>
    event TypedEventHandler<CoreWindow, PointerEventArgs> PointerEntered;

    /// <summary>Specifies the event that occurs when the pointer moves outside the bounding box of the window.</summary>
    event TypedEventHandler<CoreWindow, PointerEventArgs> PointerExited;

    /// <summary>Specifies the event that occurs when a pointer moves within the bounding box of the window.</summary>
    event TypedEventHandler<CoreWindow, PointerEventArgs> PointerMoved;

    /// <summary>Occurs when a mouse button is clicked, or the digitizer surface has been touched by a finger or pen, within the bounding rectangle of the app.</summary>
    event TypedEventHandler<CoreWindow, PointerEventArgs> PointerPressed;

    /// <summary>Occurs when a pressed mouse button is released, or a touch or pen contact is lifted from the digitizer surface, within the bounding rectangle of the app (or outside the bounding rectangle, if the pointer is captured).</summary>
    event TypedEventHandler<CoreWindow, PointerEventArgs> PointerReleased;

    /// <summary>Specifies the event that occurs when a touch contact area falls within a window that is registered for touch hit testing.</summary>
    event TypedEventHandler<CoreWindow, TouchHitTestingEventArgs> TouchHitTesting;

    /// <summary>Specifies the event that occurs when the mouse wheel is rotated.</summary>
    event TypedEventHandler<CoreWindow, PointerEventArgs> PointerWheelChanged;

    /// <summary>Specifies the event that raises when the window size is changed.</summary>
    event TypedEventHandler<CoreWindow, WindowSizeChangedEventArgs> SizeChanged;

    /// <summary>Specifies the event that occurs when the window visibility is changed.</summary>
    event TypedEventHandler<CoreWindow, VisibilityChangedEventArgs> VisibilityChanged;
  }
}
