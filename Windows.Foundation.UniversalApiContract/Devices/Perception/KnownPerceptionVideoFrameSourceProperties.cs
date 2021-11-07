// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.KnownPerceptionVideoFrameSourceProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  /// <summary>Provides static properties of video frame sources.</summary>
  /// <deprecated type="deprecate">KnownPerceptionVideoFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.</deprecated>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IKnownPerceptionVideoFrameSourcePropertiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Deprecated("KnownPerceptionVideoFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  public static class KnownPerceptionVideoFrameSourceProperties
  {
    /// <summary>Gets a string key used to retrieve the current video profile property.</summary>
    /// <returns>The current video profile. This property is an IInspectable value.</returns>
    public static extern string VideoProfile { [Deprecated("KnownPerceptionVideoFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to retrieve the supported video profiles property.</summary>
    /// <returns>The supported video profiles. This property is an IInspectable value.</returns>
    public static extern string SupportedVideoProfiles { [Deprecated("KnownPerceptionVideoFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to retrieve a boolean property indicating the supported video profiles that are currently available.</summary>
    /// <returns>The supported video profiles that are currently available. This property is an IInspectable value.</returns>
    public static extern string AvailableVideoProfiles { [Deprecated("KnownPerceptionVideoFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to retrieve a boolean property indicating whether or not the video frame source is providing mirrored video frames.</summary>
    /// <returns>Indicates whether or not the video frame source is providing mirrored video frames. This property is a Boolean value.</returns>
    public static extern string IsMirrored { [Deprecated("KnownPerceptionVideoFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to retrieve a CameraIntrinsics property defining the physical properties of the camera device. The CameraIntrinsics object also provides convenience methods for sensor-related geometry, including camera space to image space projections.</summary>
    /// <returns>Returns an object representing the intrinsic physical properties of the camera.</returns>
    public static extern string CameraIntrinsics { [Deprecated("KnownPerceptionVideoFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
