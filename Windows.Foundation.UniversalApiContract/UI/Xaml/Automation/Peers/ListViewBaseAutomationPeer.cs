// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ListViewBaseAutomationPeer
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
  /// <summary>A base class that provides a Microsoft UI Automation peer implementation for types that derive from ListViewBase.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Composable(typeof (IListViewBaseAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class ListViewBaseAutomationPeer : 
    SelectorAutomationPeer,
    IListViewBaseAutomationPeer,
    IDropTargetProvider
  {
    /// <summary>Initializes a new instance of the ListViewBaseAutomationPeer class.</summary>
    /// <param name="owner">The ListViewBase derived object to create a peer for.</param>
    [MethodImpl]
    public extern ListViewBaseAutomationPeer(ListViewBase owner);

    /// <summary>Gets a string that indicates what will happen when the item is dropped.</summary>
    /// <returns>A string that indicates what will happen when the item is dropped.</returns>
    public extern string DropEffect { [MethodImpl] get; }

    /// <summary>Gets an array of strings that enumerates possible drop effects when this item is dropped.</summary>
    /// <returns>An array of strings that enumerates possible drop effects when this item is dropped.</returns>
    public extern string[] DropEffects { [MethodImpl] get; }
  }
}
