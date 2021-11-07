// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionColorFrameArrivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  /// <summary>Contains information about a color frame arrived event.</summary>
  /// <deprecated type="deprecate">PerceptionColorFrameArrivedEventArgs may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameArrivedEventArgs instead.</deprecated>
  [DualApiPartition(version = 167772160)]
  [Deprecated("PerceptionColorFrameArrivedEventArgs may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameArrivedEventArgs instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class PerceptionColorFrameArrivedEventArgs : IPerceptionColorFrameArrivedEventArgs
  {
    /// <summary>Gets the relative time of this frame.</summary>
    /// <returns>The relative time of this frame.</returns>
    public extern TimeSpan RelativeTime { [Deprecated("PerceptionColorFrameArrivedEventArgs may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameArrivedEventArgs instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Attempts to open the color frame that has arrived.</summary>
    /// <deprecated type="deprecate">PerceptionColorFrameArrivedEventArgs may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameArrivedEventArgs instead.</deprecated>
    /// <returns>If the attempt is successful, this method returns the newly-arrived color frame. If the attempt is unsuccessful, this value is unchanged.</returns>
    [Deprecated("PerceptionColorFrameArrivedEventArgs may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameArrivedEventArgs instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern PerceptionColorFrame TryOpenFrame();
  }
}
