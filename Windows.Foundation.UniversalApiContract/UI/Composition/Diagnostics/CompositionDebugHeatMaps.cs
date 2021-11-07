// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Diagnostics.CompositionDebugHeatMaps
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Diagnostics
{
  /// <summary>Represents heatmaps that show overdrawn areas of a composition UI.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772165)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  public sealed class CompositionDebugHeatMaps : ICompositionDebugHeatMaps
  {
    /// <summary>Hides the heatmap for the specified subtree.</summary>
    /// <param name="subtree">The part of the visual tree for which to hide the heatmap.</param>
    [MethodImpl]
    public extern void Hide(Visual subtree);

    /// <summary>Shows a graphical representation of the GPU memory used by the app.</summary>
    /// <param name="subtree">The part of the visual tree for which to show texture memory usage.</param>
    [MethodImpl]
    public extern void ShowMemoryUsage(Visual subtree);

    /// <summary>Highlights pixels affected by multiple visuals at the same time.</summary>
    /// <param name="subtree">The part of the visual tree for which to show overdraw regions.</param>
    /// <param name="contentKinds">An enumeration value that specifies what type of content is shown on the overdraw heatmap.</param>
    [MethodImpl]
    public extern void ShowOverdraw(
      Visual subtree,
      CompositionDebugOverdrawContentKinds contentKinds);

    /// <summary>Highlights areas of the app UI that are producing updates.</summary>
    /// <param name="subtree">The part of the visual tree for which to show redraw.</param>
    [MethodImpl]
    public extern void ShowRedraw(Visual subtree);
  }
}
