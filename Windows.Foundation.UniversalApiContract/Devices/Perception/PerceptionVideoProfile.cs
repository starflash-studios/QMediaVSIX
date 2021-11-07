// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionVideoProfile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Devices.Perception
{
  /// <summary>Represents a Windows.Devices.Perception video profile.</summary>
  /// <deprecated type="deprecate">PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.</deprecated>
  [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class PerceptionVideoProfile : IPerceptionVideoProfile
  {
    /// <summary>Gets the bitmap pixel format.</summary>
    /// <returns>A BitmapPixelFormat enumeration value indicating the bitmap pixel format.</returns>
    public extern BitmapPixelFormat BitmapPixelFormat { [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the bitmap alpha mode.</summary>
    /// <returns>A BitmapAlphaMode enumeration value indicating the bitmap alpha mode.</returns>
    public extern BitmapAlphaMode BitmapAlphaMode { [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the frame width, in pixels.</summary>
    /// <returns>The frame width, in pixels.</returns>
    public extern int Width { [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the frame height, in pixels.</summary>
    /// <returns>The frame height, in pixels.</returns>
    public extern int Height { [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the time duration of each frame.</summary>
    /// <returns>A Windows.Foundation.TimeSpan indicating the time duration of each video frame.</returns>
    public extern TimeSpan FrameDuration { [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>A comparison function used to determine if two IPerceptionVideoProfile objects are equivalent.</summary>
    /// <deprecated type="deprecate">PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.</deprecated>
    /// <param name="other">The IPerceptionVideoProfile object to compare to this one.</param>
    /// <returns>True if the two video profiles are equivalent, otherwise false.</returns>
    [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern bool IsEqual(PerceptionVideoProfile other);
  }
}
