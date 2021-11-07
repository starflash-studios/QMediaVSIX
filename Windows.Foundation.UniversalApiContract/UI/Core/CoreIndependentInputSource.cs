// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CoreIndependentInputSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Core
{
  /// <summary>Surfaces core input API for interoperation scenarios.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Muse(Version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CoreIndependentInputSource : 
    ICoreInputSourceBase,
    ICorePointerInputSource,
    ICorePointerInputSource2,
    ICorePointerRedirector
  {
    /// <summary>Gets the event dispatcher for the window.</summary>
    /// <returns>The CoreDispatcher for the window.</returns>
    public extern CoreDispatcher Dispatcher { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether input is enabled for the UWP app.</summary>
    /// <returns>**true** if input is enabled for the app; **false** if it is disabled.</returns>
    public extern bool IsInputEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when input is enabled or disabled for the UWP app.</summary>
    public extern event TypedEventHandler<object, InputEnabledEventArgs> InputEnabled;

    /// <summary>Disables pointer capture for the UWP app.</summary>
    [MethodImpl]
    public extern void ReleasePointerCapture();

    /// <summary>Enables pointer capture for the UWP app.</summary>
    [MethodImpl]
    public extern void SetPointerCapture();

    /// <summary>Gets a value that reports whether the window has pointer capture.</summary>
    /// <returns>**true** if the window has pointer capture; otherwise, **false**.</returns>
    public extern bool HasCapture { [MethodImpl] get; }

    /// <summary>Gets the client coordinates of the pointer.</summary>
    /// <returns>The position of the pointer in device-independent pixel (DIP).</returns>
    public extern Point PointerPosition { [MethodImpl] get; }

    /// <summary>Gets or sets the cursor used by the UWP app.</summary>
    /// <returns>The app's cursor.</returns>
    public extern CoreCursor PointerCursor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when a pointer moves to another UWP app. This event is raised after PointerExited and is the final event received by the app for this pointer.</summary>
    public extern event TypedEventHandler<object, PointerEventArgs> PointerCaptureLost;

    /// <summary>Occurs when a pointer moves into the bounding box of the UWP app.</summary>
    public extern event TypedEventHandler<object, PointerEventArgs> PointerEntered;

    /// <summary>Occurs when the pointer moves outside the bounding box of the UWP app.</summary>
    public extern event TypedEventHandler<object, PointerEventArgs> PointerExited;

    /// <summary>Occurs when a pointer moves within the bounding box of the UWP app.</summary>
    public extern event TypedEventHandler<object, PointerEventArgs> PointerMoved;

    /// <summary>Occurs when a mouse button is clicked, or a touch or pen contact is detected, within the bounding rectangle of the UWP app.</summary>
    public extern event TypedEventHandler<object, PointerEventArgs> PointerPressed;

    /// <summary>Occurs when a mouse button is released, or a touch or pen contact is lifted, within the bounding rectangle of the UWP app.</summary>
    public extern event TypedEventHandler<object, PointerEventArgs> PointerReleased;

    /// <summary>Occurs when the wheel button is rotated.</summary>
    public extern event TypedEventHandler<object, PointerEventArgs> PointerWheelChanged;

    /// <summary>Gets the DispatcherQueue associated with this CoreIndependentInputSource.</summary>
    /// <returns>The DispatcherQueue for managing prioritized tasks that execute in a serial fashion on a thread.</returns>
    public extern DispatcherQueue DispatcherQueue { [MethodImpl] get; }

    public extern event TypedEventHandler<ICorePointerRedirector, PointerEventArgs> PointerRoutedAway;

    public extern event TypedEventHandler<ICorePointerRedirector, PointerEventArgs> PointerRoutedTo;

    public extern event TypedEventHandler<ICorePointerRedirector, PointerEventArgs> PointerRoutedReleased;
  }
}
