// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicFrameRenderingReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  /// <summary>Contains timing information about the work the application did leading up to the frame being scanned out by the system for the first time.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public sealed class HolographicFrameRenderingReport : IHolographicFrameRenderingReport
  {
    /// <summary>Gets the unique identifier for the HolographicFrame associated with the HolographicFrameRenderingReport.</summary>
    /// <returns>A HolographicFrameId representing the unique identifier for the HolographicFrame associated with the HolographicFrameRenderingReport.</returns>
    public extern HolographicFrameId FrameId { [MethodImpl] get; }

    /// <summary>Gets the number of scanouts where a previous HolographicFrame had to be re-projected again due to the GPU work for the current **HolographicFrame** not finishing in time for the target scanout deadline.</summary>
    /// <returns>The number of scanouts where a previous HolographicFrame had to be re-projected.</returns>
    public extern uint MissedLatchCount { [MethodImpl] get; }

    /// <summary>Gets the system-recommended time at which rendering for the HolographicFrame that is dependent on the head pose should have begun. This is the same time that HolographicSpace.WaitForNextFrameReady method is unblocked.</summary>
    /// <returns>The system-recommended time at which rendering for the HolographicFrame that is dependent on the head pose should have begun.</returns>
    public extern TimeSpan SystemRelativeFrameReadyTime { [MethodImpl] get; }

    /// <summary>Gets the time at which all GPU work needed for reprojection is known to be finished. This includes any overlay work or other hologram compositor post-processing needed to prepare the final image.</summary>
    /// <returns>The time at which all GPU work needed for reprojection is known to be finished.</returns>
    public extern TimeSpan SystemRelativeActualGpuFinishTime { [MethodImpl] get; }

    /// <summary>Gets an estimate of the time that the HolographicFrame needed to have all its GPU work, both application and compositor, finished in order to begin reprojection on schedule.</summary>
    /// <returns>An estimate of the time that the HolographicFrame needed to have all its GPU work finished in order to begin reprojection on schedule.</returns>
    public extern TimeSpan SystemRelativeTargetLatchTime { [MethodImpl] get; }
  }
}
