// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.SelectorAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>A base class that provides a Microsoft UI Automation peer implementation for types that derive from Selector.</summary>
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (ISelectorAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class SelectorAutomationPeer : 
    ItemsControlAutomationPeer,
    ISelectorAutomationPeer,
    ISelectionProvider
  {
    /// <summary>Initializes a new instance of the SelectorAutomationPeer class.</summary>
    /// <param name="owner">The owner Selector implementation to create for.</param>
    [MethodImpl]
    public extern SelectorAutomationPeer(Selector owner);

    /// <summary>Gets a value that indicates whether the Microsoft UI Automation provider allows more than one child element to be selected concurrently.</summary>
    /// <returns>**true** if multiple selection is allowed; otherwise, **false**.</returns>
    public extern bool CanSelectMultiple { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the Microsoft UI Automation provider requires at least one child element to be selected.</summary>
    /// <returns>**true** if selection is required; otherwise, **false**.</returns>
    public extern bool IsSelectionRequired { [MethodImpl] get; }

    /// <summary>Retrieves a Microsoft UI Automation provider for each child element that is selected.</summary>
    /// <returns>A generic list of Microsoft UI Automation providers.</returns>
    [MethodImpl]
    public extern IRawElementProviderSimple[] GetSelection();
  }
}
