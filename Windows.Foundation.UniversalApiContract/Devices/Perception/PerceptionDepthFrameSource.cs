// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionDepthFrameSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Media.Devices.Core;

namespace Windows.Devices.Perception
{
  /// <summary>A frame source that provides depth frames.</summary>
  /// <deprecated type="deprecate">PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Frames.MediaFrameSource instead.</deprecated>
  [Static(typeof (IPerceptionDepthFrameSourceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class PerceptionDepthFrameSource : 
    IPerceptionDepthFrameSource,
    IPerceptionDepthFrameSource2
  {
    /// <summary>Subscribes to the AvailableChanged event.</summary>
    public extern event TypedEventHandler<PerceptionDepthFrameSource, object> AvailableChanged;

    /// <summary>Subscribes to the ActiveChanged event.</summary>
    public extern event TypedEventHandler<PerceptionDepthFrameSource, object> ActiveChanged;

    /// <summary>Subscribes to the PropertiesChanged event.</summary>
    public extern event TypedEventHandler<PerceptionDepthFrameSource, PerceptionFrameSourcePropertiesChangedEventArgs> PropertiesChanged;

    /// <summary>Subscribes to the VideoProfileChanged event.</summary>
    public extern event TypedEventHandler<PerceptionDepthFrameSource, object> VideoProfileChanged;

    /// <summary>Subscribes to the CameraIntrinsicsChanged event.</summary>
    public extern event TypedEventHandler<PerceptionDepthFrameSource, object> CameraIntrinsicsChanged;

    /// <summary>Gets a string value indicating the unique ID of the depth frame source.</summary>
    /// <returns>A string value indicating the unique ID of the depth frame source.</returns>
    public extern string Id { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string value indicating the display name of the depth frame source.</summary>
    /// <returns>A string value indicating the display name of the depth frame source.</returns>
    public extern string DisplayName { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string value indicating the kind of physical device that generates the depth frames.</summary>
    /// <returns>A string value indicating the kind of physical device that generates the depth frames.</returns>
    public extern string DeviceKind { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a boolean value indicating whether or not the source is available.</summary>
    /// <returns>A boolean value indicating whether or not the source is available.</returns>
    public extern bool Available { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a boolean value indicating whether or not the source is active.</summary>
    /// <returns>A boolean value indicating whether or not the source is active.</returns>
    public extern bool Active { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a boolean value indicating whether or not the source is the subject of controller mode.</summary>
    /// <returns>A boolean value indicating whether or not the source is the subject of controller mode.</returns>
    public extern bool IsControlled { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a read-only collection of frame source properties.</summary>
    /// <returns>A read-only collection of frame source properties.</returns>
    public extern IMapView<string, object> Properties { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] [return: HasVariant] get; }

    /// <summary>Gets a read-only collection of video profiles that are supported by the depth frame source.</summary>
    /// <returns>A read-only collection of video profiles that are supported by the depth frame source.</returns>
    public extern IVectorView<PerceptionVideoProfile> SupportedVideoProfiles { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a read-only collection of video profiles that are currently available from the depth frame source.</summary>
    /// <returns>A read-only collection of video profiles that are currently available from the depth frame source.</returns>
    public extern IVectorView<PerceptionVideoProfile> AvailableVideoProfiles { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a PerceptionVideoProfile object indicating the current video profile.</summary>
    /// <returns>A PerceptionVideoProfile object indicating the current video profile.</returns>
    public extern PerceptionVideoProfile VideoProfile { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a CameraIntrinsics value specifying the intrinsic properties of the depth frame source camera device.</summary>
    /// <returns>A CameraIntrinsics value specifying the intrinsic properties of the depth frame source camera device.</returns>
    public extern CameraIntrinsics CameraIntrinsics { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Attempts to acquire Controller Mode on the depth frame source.</summary>
    /// <deprecated type="deprecate">PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.</deprecated>
    /// <returns>If the attempt is successful, this returns a PerceptionControlSession object that can be used to control properties of the depth frame source. Otherwise, this returns null.</returns>
    [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern PerceptionControlSession AcquireControlSession();

    /// <summary>This method returns a boolean value indicating whether or not the depth frame source can be controlled separately from another frame source.</summary>
    /// <deprecated type="deprecate">PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.</deprecated>
    /// <param name="targetId">A string representing the unique ID of the other frame source.</param>
    /// <returns>True if the two sources can be controlled independently of one another; otherwise, false.</returns>
    [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern bool CanControlIndependentlyFrom(string targetId);

    /// <summary>Checks whether or not the depth frame source is correlated with the target entity. If the result is true, a transform matrix can be retrieved to change coordinate basis from this depth frame source to the entity, or vice versa.</summary>
    /// <deprecated type="deprecate">PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.</deprecated>
    /// <param name="targetId">The unique ID of the target entity.</param>
    /// <returns>True if a correlation exists, otherwise false.</returns>
    [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern bool IsCorrelatedWith(string targetId);

    [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern bool TryGetTransformTo(string targetId, out Matrix4x4 result);

    /// <summary>Attempts to get the intrinsic properties of the depth camera that is correlated with this depth source.</summary>
    /// <deprecated type="deprecate">PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.</deprecated>
    /// <param name="target">The depth frame source to try to get intrinsic properties of.</param>
    /// <returns>If the attempt is successful, this returns a read-only collection of PerceptionDepthCorrelatedCameraIntrinsics objects specifying the intrinsic properties of the camera used by the correlated depth frame source. Otherwise, this returns null.</returns>
    [RemoteAsync]
    [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncOperation<PerceptionDepthCorrelatedCameraIntrinsics> TryGetDepthCorrelatedCameraIntrinsicsAsync(
      PerceptionDepthFrameSource target);

    /// <summary>Attempts to get a coordinate mapper that maps from depth frame image space to depth frame space.</summary>
    /// <deprecated type="deprecate">PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.</deprecated>
    /// <param name="targetId">The unique ID of the depth frame source to try to map to.</param>
    /// <param name="depthFrameSourceToMapWith">The depth frame source to try to map to. This should be in a correlation group with the depth frame source.</param>
    /// <returns>If the two sources are correlated, this method returns a PerceptionDepthCorrelatedCoordinateMapper. Otherwise, it returns null. This method returns asynchronously.</returns>
    [RemoteAsync]
    [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncOperation<PerceptionDepthCorrelatedCoordinateMapper> TryGetDepthCorrelatedCoordinateMapperAsync(
      string targetId,
      PerceptionDepthFrameSource depthFrameSourceToMapWith);

    /// <summary>Attempts to set a video profile on this depth frame source. Requires an active Controller Mode control session on this frame source.</summary>
    /// <deprecated type="deprecate">PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.</deprecated>
    /// <param name="controlSession">A PerceptionControlSession representing active control of this frame source.</param>
    /// <param name="profile">The video profile to set.</param>
    /// <returns>This method returns an PerceptionFrameSourcePropertyChangeResult object asynchronously. If the control session was still active when the video profile was set, and if the video profile is supported and can be activated, this will be a result indicating success.</returns>
    [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PerceptionFrameSourcePropertyChangeResult> TrySetVideoProfileAsync(
      PerceptionControlSession controlSession,
      PerceptionVideoProfile profile);

    /// <summary>Gets a frame reader that reads frames from this depth frame source.</summary>
    /// <deprecated type="deprecate">PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.</deprecated>
    /// <returns>A frame reader that reads frames from this depth frame source.</returns>
    [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern PerceptionDepthFrameReader OpenReader();

    /// <summary>Gets a string value that identifies the device on the system.</summary>
    /// <returns>The identifier.</returns>
    public extern string DeviceId { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Creates a new depth frame source watcher.</summary>
    /// <deprecated type="deprecate">PerceptionDepthFrameSource.CreateWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation.CreateWatcher instead.</deprecated>
    /// <returns>A new depth frame source watcher.</returns>
    [Deprecated("PerceptionDepthFrameSource.CreateWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation.CreateWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern PerceptionDepthFrameSourceWatcher CreateWatcher();

    /// <summary>Finds all depth frame sources.</summary>
    /// <deprecated type="deprecate">PerceptionDepthFrameSource.FindAllAsync may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation.FindAllAsync instead.</deprecated>
    /// <returns>When the method completes, it asynchronously returns a list of depth frame sources.</returns>
    [RemoteAsync]
    [Deprecated("PerceptionDepthFrameSource.FindAllAsync may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation.FindAllAsync instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<PerceptionDepthFrameSource>> FindAllAsync();

    /// <summary>Finds an depth frame source by looking up its unique ID.</summary>
    /// <deprecated type="deprecate">PerceptionDepthFrameSource.FromIdAsync may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation.FromIdAsync instead.</deprecated>
    /// <param name="id">The unique ID of the depth frame source.</param>
    /// <returns>When this method completes, it asynchronously returns a depth frame source if one exists with the specified ID. Otherwise, this method asynchronously returns null.</returns>
    [RemoteAsync]
    [Deprecated("PerceptionDepthFrameSource.FromIdAsync may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation.FromIdAsync instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncOperation<PerceptionDepthFrameSource> FromIdAsync(
      string id);

    /// <summary>Requests access to use depth frame sources.</summary>
    /// <deprecated type="deprecate">PerceptionDepthFrameSource.RequestAccessAsync may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.</deprecated>
    /// <returns>When this method completes, it asynchronously returns a PerceptionFrameSourceAccessStatus indicating the result of the access request.</returns>
    [RemoteAsync]
    [Deprecated("PerceptionDepthFrameSource.RequestAccessAsync may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncOperation<PerceptionFrameSourceAccessStatus> RequestAccessAsync();
  }
}
