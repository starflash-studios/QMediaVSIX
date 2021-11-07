// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicFramePresentationReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  /// <summary>A frame presentation report for a particular compositor frame.</summary>
  /// <deprecated type="deprecate">Use HolographicFrameScanoutReport instead of HolographicFramePresentationReport. For more info, see MSDN.</deprecated>
  [Deprecated("Use HolographicFrameScanoutReport instead of HolographicFramePresentationReport. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HolographicFramePresentationReport : IHolographicFramePresentationReport
  {
    /// <summary>The amount of GPU time which was not available for the app's use since it was consumed by the compositor.</summary>
    /// <returns>
    /// </returns>
    public extern TimeSpan CompositorGpuDuration { [Deprecated("Use IHolographicFrameScanoutReport instead of IHolographicFramePresentationReport. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The amount of GPU time which was consumed by the app.</summary>
    /// <returns>
    /// </returns>
    public extern TimeSpan AppGpuDuration { [Deprecated("Use IHolographicFrameScanoutReport instead of IHolographicFramePresentationReport. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The amount of GPU time the app spent which went beyond its presentation target time.</summary>
    /// <returns>
    /// </returns>
    public extern TimeSpan AppGpuOverrun { [Deprecated("Use IHolographicFrameScanoutReport instead of IHolographicFramePresentationReport. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The number of presentation opportunities which were missed before the app's frame was finished rendering.</summary>
    /// <returns>
    /// </returns>
    public extern uint MissedPresentationOpportunityCount { [Deprecated("Use IHolographicFrameScanoutReport instead of IHolographicFramePresentationReport. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The number of times the app's frame was presented by the compositor.</summary>
    /// <returns>
    /// </returns>
    public extern uint PresentationCount { [Deprecated("Use IHolographicFrameScanoutReport instead of IHolographicFramePresentationReport. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
