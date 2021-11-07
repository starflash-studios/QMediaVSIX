// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.FlipViewItemDataAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes the data content of a FlipViewItem to Microsoft UI Automation.</summary>
  [WebHostHidden]
  [Composable(typeof (IFlipViewItemDataAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public class FlipViewItemDataAutomationPeer : 
    SelectorItemAutomationPeer,
    IFlipViewItemDataAutomationPeer,
    IScrollItemProvider
  {
    /// <summary>Initializes a new instance of the FlipViewItemDataAutomationPeer class.</summary>
    /// <param name="item">The item data.</param>
    /// <param name="parent">The owner to create for.</param>
    [MethodImpl]
    public extern FlipViewItemDataAutomationPeer(object item, FlipViewAutomationPeer parent);

    /// <summary>Scrolls the content area of a parent container in order to display the peer owner's content within the visible region (viewport) of the container.</summary>
    [MethodImpl]
    public extern void ScrollIntoView();
  }
}
