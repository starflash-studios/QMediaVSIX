// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CoreComponentInputSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Core
{
  /// <summary>Provides a mechanism to receive input for a XAML framework element hosted in another framework, such as a DirectX interop framework.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Muse(Version = 100859904)]
  [WebHostHidden]
  public sealed class CoreComponentInputSource : 
    ICoreInputSourceBase,
    ICorePointerInputSource,
    ICoreKeyboardInputSource,
    ICoreComponentFocusable,
    ICoreTouchHitTesting,
    ICoreClosestInteractiveBoundsRequested,
    ICoreKeyboardInputSource2,
    ICorePointerInputSource2
  {
    /// <summary>Gets the input event dispatcher for the hosted XAML framework element.</summary>
    /// <returns>The CoreDispatcher for the hosted XAML framework element.</returns>
    public extern CoreDispatcher Dispatcher { [MethodImpl] get; }

    /// <summary>Gets or sets whether input is enabled for the hosted XAML framework element.</summary>
    /// <returns>**true** if input is enabled; **false** if it is not.</returns>
    public extern bool IsInputEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Raised when the hosted XAML control is enabled for input.</summary>
    public extern event TypedEventHandler<object, InputEnabledEventArgs> InputEnabled;

    /// <summary>Stops the capture of pointer input data (if the pointing device supports input capture).</summary>
    [MethodImpl]
    public extern void ReleasePointerCapture();

    /// <summary>Starts the capture of pointer input data (if the pointing device supports input capture).</summary>
    [MethodImpl]
    public extern void SetPointerCapture();

    /// <summary>Indicates whether the input device supports input capture.</summary>
    /// <returns>**true** if the input device supports capture (recording of input data); **false** if it does not.</returns>
    public extern bool HasCapture { [MethodImpl] get; }

    /// <summary>Gets the current pointer position in the hosted XAML framework.</summary>
    /// <returns>The current pointer position.</returns>
    public extern Point PointerPosition { [MethodImpl] get; }

    /// <summary>Gets the pointer cursor behavior for interactions with the hosted XAML framework element.</summary>
    /// <returns>The pointer cursor object.</returns>
    public extern CoreCursor PointerCursor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Raised when the pointer input capture stream is lost.</summary>
    public extern event TypedEventHandler<object, PointerEventArgs> PointerCaptureLost;

    /// <summary>Raised when the pointer enters the hosted XAML element.</summary>
    public extern event TypedEventHandler<object, PointerEventArgs> PointerEntered;

    /// <summary>Raised when the pointer exits the hosted XAML element.</summary>
    public extern event TypedEventHandler<object, PointerEventArgs> PointerExited;

    /// <summary>Raised when the pointer is moved for the active hosted XAML element.</summary>
    public extern event TypedEventHandler<object, PointerEventArgs> PointerMoved;

    /// <summary>Raised when the pointer is "pressed" (such as a mouse button click or full screen press) for the active hosted XAML element.</summary>
    public extern event TypedEventHandler<object, PointerEventArgs> PointerPressed;

    /// <summary>Raised when the pointer is released (such as when a mouse button click or screen press is released) for the active hosted XAML element.</summary>
    public extern event TypedEventHandler<object, PointerEventArgs> PointerReleased;

    /// <summary>Raised when the mouse wheel is rotated for the active hosted XAML element.</summary>
    public extern event TypedEventHandler<object, PointerEventArgs> PointerWheelChanged;

    /// <summary>Gets the current status of a virtual key press.</summary>
    /// <param name="virtualKey">The key from which to retrieve status.</param>
    /// <returns>The flags indicating the current state of the supplied virtual key when the input event fired.</returns>
    [MethodImpl]
    public extern CoreVirtualKeyStates GetCurrentKeyState(VirtualKey virtualKey);

    /// <summary>Raised when a character is received (such as from a completed key press sequence) by the hosted XAML element.</summary>
    public extern event TypedEventHandler<object, CharacterReceivedEventArgs> CharacterReceived;

    /// <summary>Raised when a key is pressed for the current active hosted XAML element.</summary>
    public extern event TypedEventHandler<object, KeyEventArgs> KeyDown;

    /// <summary>Raised when a key press is released for the current active hosted XAML element.</summary>
    public extern event TypedEventHandler<object, KeyEventArgs> KeyUp;

    /// <summary>Gets whether the current hosted XAML control element has focus. If it does, keyboard input is delivered to that control.</summary>
    /// <returns>**true** if the element has focus; **false** if it does not.</returns>
    public extern bool HasFocus { [MethodImpl] get; }

    /// <summary>Raised when a hosted XAML element gets focus.</summary>
    public extern event TypedEventHandler<object, CoreWindowEventArgs> GotFocus;

    /// <summary>Raised when a hosted XAML element loses focus.</summary>
    public extern event TypedEventHandler<object, CoreWindowEventArgs> LostFocus;

    /// <summary>Raised for a touch hit test on a hosted XAML element.</summary>
    public extern event TypedEventHandler<object, TouchHitTestingEventArgs> TouchHitTesting;

    /// <summary>Occurs when a framework input manager requests the bounding rectangle of an interactive element within a specific bounding rectangle and closest to a specific pointer.</summary>
    public extern event TypedEventHandler<CoreComponentInputSource, ClosestInteractiveBoundsRequestedEventArgs> ClosestInteractiveBoundsRequested;

    /// <summary>Retrieves the unique ID for the input device that generated this key event.</summary>
    /// <returns>A unique identifier for the input device associated with the key event, or an empty string. The same device can be assigned a different ID each time it is connected.</returns>
    [MethodImpl]
    public extern string GetCurrentKeyEventDeviceId();

    /// <summary>Gets the DispatcherQueue associated with this CoreComponentInputSource.</summary>
    /// <returns>The DispatcherQueue for managing prioritized tasks that execute in a serial fashion on a thread.</returns>
    public extern DispatcherQueue DispatcherQueue { [MethodImpl] get; }
  }
}
