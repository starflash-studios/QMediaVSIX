// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionDepthFrameArrivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  /// <summary>Contains information about a depth frame arrived event.</summary>
  /// <deprecated type="deprecate">PerceptionDepthFrameArrivedEventArgs may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameArrivedEventArgs instead.</deprecated>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("PerceptionDepthFrameArrivedEventArgs may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameArrivedEventArgs instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class PerceptionDepthFrameArrivedEventArgs : IPerceptionDepthFrameArrivedEventArgs
  {
    /// <summary>Gets the relative time of this frame.</summary>
    /// <returns>The relative time of this frame.</returns>
    public extern TimeSpan RelativeTime { [Deprecated("PerceptionDepthFrameArrivedEventArgs may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameArrivedEventArgs instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Attempts to open the depth frame that has arrived. Existing frames should be closed before opening new frames. If an app has three or more frames still open when this method is called, TryOpenFrame will fail.</summary>
    /// <deprecated type="deprecate">PerceptionDepthFrameArrivedEventArgs may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameArrivedEventArgs instead.</deprecated>
    /// <returns>If the attempt is successful, this method returns the newly-arrived depth frame. If the attempt is unsuccessful, this value is unchanged.</returns>
    [Deprecated("PerceptionDepthFrameArrivedEventArgs may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameArrivedEventArgs instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern PerceptionDepthFrame TryOpenFrame();
  }
}
