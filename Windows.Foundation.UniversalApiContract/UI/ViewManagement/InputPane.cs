// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.InputPane
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>Enables an app to receive notifications when the docked touch keyboard, or Soft Input Panel (SIP), is about to be displayed or hidden, and to determine which portion of the application's window is obscured by the input pane.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [Static(typeof (IInputPaneStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772162)]
  [Static(typeof (IInputPaneStatics2), 524288, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class InputPane : IInputPane, IInputPane2, IInputPaneControl
  {
    /// <summary>Occurs when the input pane starts sliding into view.</summary>
    public extern event TypedEventHandler<InputPane, InputPaneVisibilityEventArgs> Showing;

    /// <summary>Occurs when the input pane starts sliding out of view.</summary>
    public extern event TypedEventHandler<InputPane, InputPaneVisibilityEventArgs> Hiding;

    /// <summary>Gets the region of the app window obscured by the input pane.</summary>
    /// <returns>The rectangle, in client coordinates, representing the region of the app window hidden behind the input pane. Specified in device-independent pixel (DIP).</returns>
    public extern Rect OccludedRect { [MethodImpl] get; }

    /// <summary>Tries to show the InputPane, if it is hidden.</summary>
    /// <returns>**true** if the request to show the InputPane was accepted; otherwise **false**.</returns>
    [MethodImpl]
    public extern bool TryShow();

    /// <summary>Tries to hide the InputPane, if it is visible.</summary>
    /// <returns>**true** if the request to hide the InputPane was accepted; otherwise **false**.</returns>
    [MethodImpl]
    public extern bool TryHide();

    /// <summary>Gets or sets a value that indicates whether the input pane is shown.</summary>
    /// <returns>**true** if the input pane is shown; otherwise, **false**.</returns>
    public extern bool Visible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the InputPane object associated with the view with the specified context identifier.</summary>
    /// <param name="context">The context identifier of the view to get the input pane for.</param>
    /// <returns>The input pane.</returns>
    [MethodImpl]
    public static extern InputPane GetForUIContext(UIContext context);

    /// <summary>Gets the InputPane object associated with the application window that is currently visible.</summary>
    /// <returns>The input pane.</returns>
    [MethodImpl]
    public static extern InputPane GetForCurrentView();
  }
}
