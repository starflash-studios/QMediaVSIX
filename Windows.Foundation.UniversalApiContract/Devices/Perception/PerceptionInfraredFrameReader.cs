// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionInfraredFrameReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  /// <summary>Reads infrared frames from a infrared frame source.</summary>
  /// <deprecated type="deprecate">PerceptionInfraredFrameReader may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameReader instead.</deprecated>
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("PerceptionInfraredFrameReader may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameReader instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class PerceptionInfraredFrameReader : IPerceptionInfraredFrameReader, IClosable
  {
    /// <summary>Subscribes to the FrameArrived event. This event is fired whenever a new frame arrives from the infrared frame source.</summary>
    public extern event TypedEventHandler<PerceptionInfraredFrameReader, PerceptionInfraredFrameArrivedEventArgs> FrameArrived;

    /// <summary>Gets the infrared frame source this reader gets frames from.</summary>
    /// <returns>The infrared frame source this reader gets frames from.</returns>
    public extern PerceptionInfraredFrameSource Source { [Deprecated("PerceptionInfraredFrameReader may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameReader instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a boolean value indicating whether or not this reader is paused.</summary>
    /// <returns>A boolean value indicating whether or not this reader is paused.</returns>
    public extern bool IsPaused { [Deprecated("PerceptionInfraredFrameReader may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameReader instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("PerceptionInfraredFrameReader may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameReader instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Attempts to read the most recent frame that is available to this infrared frame reader.</summary>
    /// <deprecated type="deprecate">PerceptionInfraredFrameReader may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameReader instead.</deprecated>
    /// <returns>If the attempt was successful, this method returns the most recent frame that is available to this infrared frame reader. If the attempt was not successful, this method returns null.</returns>
    [Deprecated("PerceptionInfraredFrameReader may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameReader instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern PerceptionInfraredFrame TryReadLatestFrame();

    [MethodImpl]
    public extern void Close();
  }
}
