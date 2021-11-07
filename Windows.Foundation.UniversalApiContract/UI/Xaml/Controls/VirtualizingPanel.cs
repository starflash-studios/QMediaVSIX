// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.VirtualizingPanel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides a framework for Panel elements that virtualize their visual children.</summary>
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IVirtualizingPanelFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public class VirtualizingPanel : 
    Panel,
    IVirtualizingPanel,
    IVirtualizingPanelProtected,
    IVirtualizingPanelOverrides
  {
    /// <summary>Gets a value that identifies the ItemContainerGenerator for this VirtualizingPanel.</summary>
    /// <returns>The ItemContainerGenerator for this VirtualizingPanel.</returns>
    public extern ItemContainerGenerator ItemContainerGenerator { [MethodImpl] get; }

    [MethodImpl]
    extern void IVirtualizingPanelProtected.AddInternalChild(
      UIElement child);

    [MethodImpl]
    extern void IVirtualizingPanelProtected.InsertInternalChild(
      int index,
      UIElement child);

    [MethodImpl]
    extern void IVirtualizingPanelProtected.RemoveInternalChildRange(
      int index,
      int range);

    [MethodImpl]
    extern void IVirtualizingPanelOverrides.OnItemsChanged(
      object sender,
      ItemsChangedEventArgs args);

    [MethodImpl]
    extern void IVirtualizingPanelOverrides.OnClearChildren();

    [MethodImpl]
    extern void IVirtualizingPanelOverrides.BringIndexIntoView(int index);
  }
}
