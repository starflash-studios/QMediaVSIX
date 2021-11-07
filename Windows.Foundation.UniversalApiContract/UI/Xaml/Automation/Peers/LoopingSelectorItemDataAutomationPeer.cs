// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.LoopingSelectorItemDataAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes the data content of a LoopingSelectorItem to Microsoft UI Automation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class LoopingSelectorItemDataAutomationPeer : 
    AutomationPeer,
    ILoopingSelectorItemDataAutomationPeer,
    IVirtualizedItemProvider
  {
    /// <summary>Makes the virtual item fully accessible as a Microsoft UI Automation element.</summary>
    [MethodImpl]
    public extern void Realize();
  }
}
