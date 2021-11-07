// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ComboBoxAutomationPeer
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
  /// <summary>Exposes ComboBox types to Microsoft UI Automation.</summary>
  [Composable(typeof (IComboBoxAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class ComboBoxAutomationPeer : 
    SelectorAutomationPeer,
    IComboBoxAutomationPeer,
    IValueProvider,
    IExpandCollapseProvider,
    IWindowProvider
  {
    /// <summary>Initializes a new instance of the ComboBoxAutomationPeer class.</summary>
    /// <param name="owner">The owner element to create for.</param>
    [MethodImpl]
    public extern ComboBoxAutomationPeer(ComboBox owner);

    /// <summary>Gets a value that specifies whether the value of a control is read-only.</summary>
    /// <returns>**true** if the control value can be set; otherwise, **false**.</returns>
    public extern bool IsReadOnly { [MethodImpl] get; }

    /// <summary>Gets the value of the control.</summary>
    /// <returns>The value of the control, as a string.</returns>
    public extern string Value { [MethodImpl] get; }

    /// <summary>Sets the value of a control, as an implementation of the IValueProvider pattern.</summary>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public extern void SetValue(string value);

    /// <summary>Gets the state, expanded or collapsed, of the control.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern ExpandCollapseState ExpandCollapseState { [MethodImpl] get; }

    /// <summary>Hides all nodes, controls, or content that are descendants of the control.</summary>
    [MethodImpl]
    public extern void Collapse();

    /// <summary>Displays all child nodes, controls, or content of the control.</summary>
    [MethodImpl]
    public extern void Expand();

    /// <summary>Gets a Boolean value indicating if the ComboBox control is modal.</summary>
    /// <returns>A Boolean value indicating if the ComboBox control is modal.</returns>
    public extern bool IsModal { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating if the ComboBox control is topmost.</summary>
    /// <returns>A Boolean value indicating if the ComboBox control is topmost.</returns>
    public extern bool IsTopmost { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating if the ComboBox control can be maximized.</summary>
    /// <returns>A Boolean value indicating if the ComboBox control can be maximized.</returns>
    public extern bool Maximizable { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating if the ComboBox control can be minimized.</summary>
    /// <returns>A Boolean value indicating if the ComboBox control can be minimized.</returns>
    public extern bool Minimizable { [MethodImpl] get; }

    /// <summary>Gets the interaction state of the ComboBox control.</summary>
    /// <returns>The interaction state of the ComboBox control, as a value of the enumeration.</returns>
    public extern WindowInteractionState InteractionState { [MethodImpl] get; }

    /// <summary>Gets the WindowVisualState for the ComboBox control.</summary>
    /// <returns>The WindowVisualState for the ComboBox control, as a value of the enumeration.</returns>
    public extern WindowVisualState VisualState { [MethodImpl] get; }

    /// <summary>Attempts to close the ComboBox control.</summary>
    [MethodImpl]
    public extern void Close();

    /// <summary>Changes the visual state of the ComboBox control.</summary>
    /// <param name="state">The visual state for the ComboBox control, as a value of the enumeration.</param>
    [MethodImpl]
    public extern void SetVisualState(WindowVisualState state);

    /// <summary>Causes the calling code to block for the specified time or until the associated process enters an idle state, whichever completes first.</summary>
    /// <param name="milliseconds">The amount of time, in milliseconds, to wait for the associated process to become idle. The maximum is **Int32.MaxValue**.</param>
    /// <returns>**true** if the window has entered the idle state; **false** if the time-out occurred.</returns>
    [MethodImpl]
    public extern bool WaitForInputIdle(int milliseconds);
  }
}
