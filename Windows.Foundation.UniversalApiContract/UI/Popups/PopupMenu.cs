// Decompiled with JetBrains decompiler
// Type: Windows.UI.Popups.PopupMenu
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Popups
{
  /// <summary>Represents a context menu.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100794368)]
  public sealed class PopupMenu : IPopupMenu
  {
    /// <summary>Creates a new instance of the PopupMenu class.</summary>
    [MethodImpl]
    public extern PopupMenu();

    /// <summary>Gets the commands for the context menu.</summary>
    /// <returns>The commands for the context menu.</returns>
    public extern IVector<IUICommand> Commands { [MethodImpl] get; }

    /// <summary>Shows the context menu at the specified client coordinates.</summary>
    /// <param name="invocationPoint">The coordinates (in DIPs), relative to the window, of the user's finger or mouse pointer when the [oncontextmenu](https://docs.microsoft.com/previous-versions/windows/internet-explorer/ie-developer/platform-apis/aa704010(v=vs.85)) event fired. The menu is placed above and centered on this point.</param>
    /// <returns>A IUICommand object that represents the context menu command that was invoked by the user, after the ShowAsync call completes.</returns>
    [MethodImpl]
    public extern IAsyncOperation<IUICommand> ShowAsync(
      Point invocationPoint);

    /// <summary>Shows the context menu above the specified selection.</summary>
    /// <param name="selection">The coordinates (in DIPs) of the selected rectangle, relative to the window. The context menu is placed directly above and centered on this rectangle such that selection is not covered.</param>
    /// <returns>A IUICommand object that represents the context menu command invoked by the user, after the ShowForSelectionAsync call completes.</returns>
    [Overload("ShowAsyncWithRect")]
    [MethodImpl]
    public extern IAsyncOperation<IUICommand> ShowForSelectionAsync(
      Rect selection);

    /// <summary>Shows the context menu in the preferred placement relative to the specified selection.</summary>
    /// <param name="selection">The coordinates (in DIPs) of the selected rectangle, relative to the window.</param>
    /// <param name="preferredPlacement">The preferred placement of the context menu relative to the selection rectangle.</param>
    /// <returns>A IUICommand object that represents the context menu command invoked by the user, after the ShowForSelectionAsync call completes.</returns>
    [Overload("ShowAsyncWithRectAndPlacement")]
    [MethodImpl]
    public extern IAsyncOperation<IUICommand> ShowForSelectionAsync(
      Rect selection,
      Placement preferredPlacement);
  }
}
