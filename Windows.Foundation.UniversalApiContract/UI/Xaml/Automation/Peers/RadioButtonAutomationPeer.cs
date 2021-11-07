// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.RadioButtonAutomationPeer
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
  /// <summary>Exposes RadioButton types to Microsoft UI Automation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IRadioButtonAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class RadioButtonAutomationPeer : 
    ToggleButtonAutomationPeer,
    IRadioButtonAutomationPeer,
    ISelectionItemProvider
  {
    /// <summary>Initializes a new instance of the RadioButtonAutomationPeer class.</summary>
    /// <param name="owner">The owner element to create for.</param>
    [MethodImpl]
    public extern RadioButtonAutomationPeer(RadioButton owner);

    /// <summary>Gets a value that indicates whether an item is selected.</summary>
    /// <returns>**true** if the element is selected; otherwise, **false**.</returns>
    public extern bool IsSelected { [MethodImpl] get; }

    /// <summary>Gets the UI automation provider that implements ISelectionProvider and acts as the container for the calling object.</summary>
    /// <returns>The provider that supports ISelectionProvider.</returns>
    public extern IRawElementProviderSimple SelectionContainer { [MethodImpl] get; }

    /// <summary>Adds the current element to the collection of selected items.</summary>
    [MethodImpl]
    public extern void AddToSelection();

    /// <summary>Removes the current element from the collection of selected items.</summary>
    [MethodImpl]
    public extern void RemoveFromSelection();

    /// <summary>Clears any existing selection and then selects the current element.</summary>
    [MethodImpl]
    public extern void Select();
  }
}
