// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicFramePresentationReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Deprecated("Use IHolographicFrameScanoutReport instead of IHolographicFramePresentationReport. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [Guid(2159736340, 62196, 19594, 141, 227, 6, 92, 120, 246, 213, 222)]
  [ExclusiveTo(typeof (HolographicFramePresentationReport))]
  internal interface IHolographicFramePresentationReport
  {
    TimeSpan CompositorGpuDuration { [Deprecated("Use IHolographicFrameScanoutReport instead of IHolographicFramePresentationReport. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }

    TimeSpan AppGpuDuration { [Deprecated("Use IHolographicFrameScanoutReport instead of IHolographicFramePresentationReport. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }

    TimeSpan AppGpuOverrun { [Deprecated("Use IHolographicFrameScanoutReport instead of IHolographicFramePresentationReport. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }

    uint MissedPresentationOpportunityCount { [Deprecated("Use IHolographicFrameScanoutReport instead of IHolographicFramePresentationReport. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }

    uint PresentationCount { [Deprecated("Use IHolographicFrameScanoutReport instead of IHolographicFramePresentationReport. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
