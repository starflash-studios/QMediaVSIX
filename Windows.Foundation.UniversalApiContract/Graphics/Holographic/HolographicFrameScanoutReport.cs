// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicFrameScanoutReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  /// <summary>Provides performance and timing information about a single scanout to a holographic display.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public sealed class HolographicFrameScanoutReport : IHolographicFrameScanoutReport
  {
    /// <summary>Gets rendering timing information about the HolographicFrame that was scanned out.</summary>
    /// <returns>A HolographicFrameRenderingReport containing rendering timing information about the HolographicFrame that was scanned out.</returns>
    public extern HolographicFrameRenderingReport RenderingReport { [MethodImpl] get; }

    /// <summary>Gets the number of scanout opportunities that were missed since the last scanout.</summary>
    /// <returns>The number of scanout opportunities that were missed since the last scanout.</returns>
    public extern uint MissedScanoutCount { [MethodImpl] get; }

    /// <summary>Gets the time that the final decision on which HolographicFrame will be scanned out is made and reprojection begins, if applicable.</summary>
    /// <returns>The time that the final decision on which HolographicFrame will be scanned out is made</returns>
    public extern TimeSpan SystemRelativeLatchTime { [MethodImpl] get; }

    /// <summary>Gets the time that the image began scanning out to the display hardware.</summary>
    /// <returns>The time that the image began scanning out to the display hardware.</returns>
    public extern TimeSpan SystemRelativeScanoutStartTime { [MethodImpl] get; }

    /// <summary>Gets the time that the light from the display hardware for the current scanout is expected to be emitted.</summary>
    /// <returns>The time that the light from the display hardware for the current scanout is expected to be emitted.</returns>
    public extern TimeSpan SystemRelativePhotonTime { [MethodImpl] get; }
  }
}
