// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.TreeViewItemAutomationPeer
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
  /// <summary>Exposes **TreeViewItem ** types to Microsoft UI Automation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (ITreeViewItemAutomationPeerFactory), CompositionType.Public, 393216, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public class TreeViewItemAutomationPeer : 
    ListViewItemAutomationPeer,
    ITreeViewItemAutomationPeer,
    IExpandCollapseProvider
  {
    /// <summary>Initializes a new instance of the **TreeViewItemAutomationPeer** class.</summary>
    /// <param name="owner">The **TreeViewItem ** control instance to create the peer for.</param>
    [MethodImpl]
    public extern TreeViewItemAutomationPeer(TreeViewItem owner);

    /// <summary>Gets a value indicating the expanded or collapsed state of the associated **TreeViewItem **.</summary>
    /// <returns>The expanded or collapsed state of the associated **TreeViewItem **. The default value is **Expanded**.</returns>
    public extern ExpandCollapseState ExpandCollapseState { [MethodImpl] get; }

    /// <summary>Collapses the associated **TreeViewItem **.</summary>
    [MethodImpl]
    public extern void Collapse();

    /// <summary>Expands the associated **TreeViewItem **.</summary>
    [MethodImpl]
    public extern void Expand();
  }
}
