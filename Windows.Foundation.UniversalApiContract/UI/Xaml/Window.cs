// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Window
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;
using Windows.UI.Core;

namespace Windows.UI.Xaml
{
  /// <summary>Represents an application window.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IWindowStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class Window : IWindow, IWindow2, IWindow3, IWindow4
  {
    /// <summary>Gets a Rect value containing the height and width of the application window in units of effective (view) pixels.</summary>
    /// <returns>A value that reports the height and width of the application window.</returns>
    public extern Rect Bounds { [MethodImpl] get; }

    /// <summary>Gets a value that reports whether the window is visible.</summary>
    /// <returns>**true** if the window is visible; **false** if the window is not visible.</returns>
    public extern bool Visible { [MethodImpl] get; }

    /// <summary>Gets or sets the visual root of an application window.</summary>
    /// <returns>The visual root of an application window.</returns>
    public extern UIElement Content { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an internal *core* object for the application window.</summary>
    /// <returns>A **CoreWindow** object.</returns>
    public extern CoreWindow CoreWindow { [MethodImpl] get; }

    /// <summary>Gets the CoreDispatcher object for the Window, which is generally the CoreDispatcher for the UI thread.</summary>
    /// <returns>An object that references the UI thread for the Window.</returns>
    public extern CoreDispatcher Dispatcher { [MethodImpl] get; }

    /// <summary>Occurs when the window has successfully been activated.</summary>
    public extern event WindowActivatedEventHandler Activated;

    /// <summary>Occurs when the window has closed.</summary>
    public extern event WindowClosedEventHandler Closed;

    /// <summary>Occurs when the app window has first rendered or has changed its rendering size.</summary>
    public extern event WindowSizeChangedEventHandler SizeChanged;

    /// <summary>Occurs when the value of the Visible property changes.</summary>
    public extern event WindowVisibilityChangedEventHandler VisibilityChanged;

    /// <summary>Attempts to activate the application window by bringing it to the foreground and setting the input focus to it.</summary>
    [MethodImpl]
    public extern void Activate();

    /// <summary>Closes the application window.</summary>
    [MethodImpl]
    public extern void Close();

    /// <summary>Makes a XAML element interact with the system as if it’s the title bar.</summary>
    /// <param name="value">Custom XAML content that should act as the title bar. To use multiple objects, wrap them in a container element such as one derived from Panel.</param>
    [MethodImpl]
    public extern void SetTitleBar(UIElement value);

    /// <summary>Gets the Compositor for this window.</summary>
    /// <returns>The Compositor for this window.</returns>
    public extern Compositor Compositor { [MethodImpl] get; }

    /// <summary>Gets the context identifier for the window.</summary>
    /// <returns>The context identifier for the window.</returns>
    public extern UIContext UIContext { [MethodImpl] get; }

    /// <summary>Gets the currently activated window for an application.</summary>
    /// <returns>The currently activated window.</returns>
    public static extern Window Current { [MethodImpl] get; }
  }
}
