// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.AppBarAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes AppBar types to Microsoft UI Automation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Composable(typeof (IAppBarAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class AppBarAutomationPeer : 
    FrameworkElementAutomationPeer,
    IAppBarAutomationPeer,
    IToggleProvider,
    IExpandCollapseProvider,
    IWindowProvider
  {
    /// <summary>Initializes a new instance of the AppBarAutomationPeer class.</summary>
    /// <param name="owner">The AppBar control instance to create the peer for.</param>
    [MethodImpl]
    public extern AppBarAutomationPeer(AppBar owner);

    /// <summary>Retrieves the toggle state of the owner AppBar.</summary>
    /// <returns>The ToggleState of the owner control.</returns>
    public extern ToggleState ToggleState { [MethodImpl] get; }

    /// <summary>Cycles through the toggle states of an AppBarAutomationPeer.</summary>
    [MethodImpl]
    public extern void Toggle();

    /// <summary>Gets the state, expanded or collapsed, of the control.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern ExpandCollapseState ExpandCollapseState { [MethodImpl] get; }

    /// <summary>Hides all nodes, controls, or content that are descendants of the control.</summary>
    [MethodImpl]
    public extern void Collapse();

    /// <summary>Displays all child nodes, controls, or content of the control.</summary>
    [MethodImpl]
    public extern void Expand();

    /// <summary>Gets a Boolean value indicating if the app bar is modal.</summary>
    /// <returns>**true** if the app bar is modal; otherwise, **false**.</returns>
    public extern bool IsModal { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating if the app bar is the topmost element in the z-order of layout.</summary>
    /// <returns>**true** if the app bar is topmost; otherwise, **false**.</returns>
    public extern bool IsTopmost { [MethodImpl] get; }

    /// <summary>Gets a Boolean value that indicates whether the app bar can be maximized.</summary>
    /// <returns>**true** if the app bar can be maximized; otherwise, **false**.</returns>
    public extern bool Maximizable { [MethodImpl] get; }

    /// <summary>Gets a Boolean value that indicates whether the app bar can be minimized.</summary>
    /// <returns>**true** if the app bar can be minimized; otherwise, **false**.</returns>
    public extern bool Minimizable { [MethodImpl] get; }

    /// <summary>Gets the interaction state of the app bar, such as running, closing, and so on.</summary>
    /// <returns>The interaction state of the app bar.</returns>
    public extern WindowInteractionState InteractionState { [MethodImpl] get; }

    /// <summary>Gets the visual state of the app bar.</summary>
    /// <returns>The visual state of the app bar, as a value of the enumeration.</returns>
    public extern WindowVisualState VisualState { [MethodImpl] get; }

    /// <summary>Closes the app bar.</summary>
    [MethodImpl]
    public extern void Close();

    /// <summary>Changes the visual state of the app bar (such as minimizing or maximizing it).</summary>
    /// <param name="state">The visual state of the app bar to change to, as a value of the enumeration.</param>
    [MethodImpl]
    public extern void SetVisualState(WindowVisualState state);

    /// <summary>Blocks the calling code for the specified time or until the associated process enters an idle state, whichever completes first.</summary>
    /// <param name="milliseconds">The amount of time, in milliseconds, to wait for the associated process to become idle.</param>
    /// <returns>**true** if the app bar has entered the idle state; **false** if the timeout occurred.</returns>
    [MethodImpl]
    public extern bool WaitForInputIdle(int milliseconds);
  }
}
