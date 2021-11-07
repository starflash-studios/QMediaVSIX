// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionInfraredFrameSource
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
  /// <summary>A frame source that provides infrared frames.</summary>
  /// <deprecated type="deprecate">PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Frames.MediaFrameSource instead.</deprecated>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPerceptionInfraredFrameSourceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Deprecated("PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class PerceptionInfraredFrameSource : 
    IPerceptionInfraredFrameSource,
    IPerceptionInfraredFrameSource2
  {
    /// <summary>Subscribes to the AvailableChanged event.</summary>
    public extern event TypedEventHandler<PerceptionInfraredFrameSource, object> AvailableChanged;

    /// <summary>Subscribes to the ActiveChanged event.</summary>
    public extern event TypedEventHandler<PerceptionInfraredFrameSource, object> ActiveChanged;

    /// <summary>Subscribes to the PropertiesChanged event.</summary>
    public extern event TypedEventHandler<PerceptionInfraredFrameSource, PerceptionFrameSourcePropertiesChangedEventArgs> PropertiesChanged;

    /// <summary>Subscribes to the VideoProfileChanged event.</summary>
    public extern event TypedEventHandler<PerceptionInfraredFrameSource, object> VideoProfileChanged;

    /// <summary>Subscribes to the CameraIntrinsicsChanged event.</summary>
    public extern event TypedEventHandler<PerceptionInfraredFrameSource, object> CameraIntrinsicsChanged;

    /// <summary>Gets a string value indicating the unique ID of the infrared frame source.</summary>
    /// <returns>A string value indicating the unique ID of the infrared frame source.</returns>
    public extern string Id { [Deprecated("PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string value indicating the display name of the infrared frame source.</summary>
    /// <returns>A string value indicating the display name of the infrared frame source.</returns>
    public extern string DisplayName { [Deprecated("PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string value indicating the kind of physical device that generates the infrared frames.</summary>
    /// <returns>A string value indicating the kind of physical device that generates the infrared frames.</returns>
    public extern string DeviceKind { [Deprecated("PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a boolean value indicating whether or not the source is available.</summary>
    /// <returns>A boolean value indicating whether or not the source is available.</returns>
    public extern bool Available { [Deprecated("PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a boolean value indicating whether or not the source is active.</summary>
    /// <returns>A boolean value indicating whether or not the source is active.</returns>
    public extern bool Active { [Deprecated("PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a boolean value indicating whether or not the source is the subject of controller mode.</summary>
    /// <returns>A boolean value indicating whether or not the source is the subject of controller mode.</returns>
    public extern bool IsControlled { [Deprecated("PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a read-only collection of frame source properties.</summary>
    /// <returns>A read-only collection of frame source properties.</returns>
    public extern IMapView<string, object> Properties { [Deprecated("PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] [return: HasVariant] get; }

    /// <summary>Gets a read-only collection of video profiles that are supported by the infrared frame source.</summary>
    /// <returns>A read-only collection of video profiles that are supported by the infrared frame source.</returns>
    public extern IVectorView<PerceptionVideoProfile> SupportedVideoProfiles { [Deprecated("PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a read-only collection of video profiles that are currently available from the infrared frame source.</summary>
    /// <returns>A read-only collection of video profiles that are currently available from the infrared frame source.</returns>
    public extern IVectorView<PerceptionVideoProfile> AvailableVideoProfiles { [Deprecated("PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a PerceptionVideoProfile object indicating the current video profile.</summary>
    /// <returns>A PerceptionVideoProfile object indicating the current video profile.</returns>
    public extern PerceptionVideoProfile VideoProfile { [Deprecated("PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a CameraIntrinsics value specifying the intrinsic properties of the infrared frame source camera device.</summary>
    /// <returns>A CameraIntrinsics value specifying the intrinsic properties of the infrared frame source camera device.</returns>
    public extern CameraIntrinsics CameraIntrinsics { [Deprecated("PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Attempts to acquire Controller Mode on the infrared frame source.</summary>
    /// <deprecated type="deprecate">PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.</deprecated>
    /// <returns>If the attempt is successful, this returns a PerceptionControlSession object that can be used to control properties of the infrared frame source. Otherwise, this returns null.</returns>
    [Deprecated("PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern PerceptionControlSession AcquireControlSession();

    /// <summary>Retrieves a boolean value indicating whether or not the infrared frame source can be controlled separately from another frame source.</summary>
    /// <deprecated type="deprecate">PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.</deprecated>
    /// <param name="targetId">A string representing the unique ID of the other frame source.</param>
    /// <returns>True if the two sources can be controlled independently of one another, otherwise false.</returns>
    [Deprecated("PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern bool CanControlIndependentlyFrom(string targetId);

    /// <summary>Checks whether or not the infrared frame source is correlated with the target entity.</summary>
    /// <deprecated type="deprecate">PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.</deprecated>
    /// <param name="targetId">The unique ID of the target entity.</param>
    /// <returns>True if a correlation exists, otherwise false. If the result is true, a transform matrix can be retrieved to change coordinate basis from this infrared frame source to the entity, or vice versa.</returns>
    [Deprecated("PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern bool IsCorrelatedWith(string targetId);

    [Deprecated("PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern bool TryGetTransformTo(string targetId, out Matrix4x4 result);

    /// <summary>Attempts to get the intrinsic properties of the depth camera that is correlated with this infrared source.</summary>
    /// <deprecated type="deprecate">PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.</deprecated>
    /// <param name="target">The depth frame source to try to get intrinsic properties of.</param>
    /// <returns>If the attempt is successful, this returns a read-only collection of PerceptionDepthCorrelatedCameraIntrinsics objects specifying the intrinsic properties of the camera used by the correlated depth frame source. Otherwise, this returns null.</returns>
    [RemoteAsync]
    [Deprecated("PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncOperation<PerceptionDepthCorrelatedCameraIntrinsics> TryGetDepthCorrelatedCameraIntrinsicsAsync(
      PerceptionDepthFrameSource target);

    /// <summary>Attempts to get a coordinate mapper that maps from infrared frame image space to depth frame space.</summary>
    /// <deprecated type="deprecate">PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.</deprecated>
    /// <param name="targetId">The unique ID of the depth frame source to try to map to.</param>
    /// <param name="depthFrameSourceToMapWith">The depth frame source to try to map to. This should be in a correlation group with the infrared frame source.</param>
    /// <returns>If the two sources are correlated, this method returns a PerceptionDepthCorrelatedCoordinateMapper. Otherwise, it returns null. This method returns asynchronously.</returns>
    [Deprecated("PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PerceptionDepthCorrelatedCoordinateMapper> TryGetDepthCorrelatedCoordinateMapperAsync(
      string targetId,
      PerceptionDepthFrameSource depthFrameSourceToMapWith);

    /// <summary>Attempts to set a video profile on this infrared frame source. Requires an active Controller Mode control session on this frame source.</summary>
    /// <deprecated type="deprecate">PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.</deprecated>
    /// <param name="controlSession">A PerceptionControlSession representing active control of this frame source.</param>
    /// <param name="profile">The video profile to set.</param>
    /// <returns>This method returns an PerceptionFrameSourcePropertyChangeResult object asynchonously. If the control session was still active when the video profile was set, and if the video profile is supported and can be activated, this will be a success result.</returns>
    [RemoteAsync]
    [Deprecated("PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncOperation<PerceptionFrameSourcePropertyChangeResult> TrySetVideoProfileAsync(
      PerceptionControlSession controlSession,
      PerceptionVideoProfile profile);

    /// <summary>Gets a frame reader that reads frames from this infrared frame source.</summary>
    /// <deprecated type="deprecate">PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.</deprecated>
    /// <returns>A frame reader that reads frames from this infrared frame source.</returns>
    [Deprecated("PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern PerceptionInfraredFrameReader OpenReader();

    /// <summary>Gets a string value that identifies the device on the system.</summary>
    /// <returns>The identifier.</returns>
    public extern string DeviceId { [Deprecated("PerceptionInfraredFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Creates a new infrared frame source watcher.</summary>
    /// <deprecated type="deprecate">PerceptionInfraredFrameSource.CreateWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation.CreateWatcher instead.</deprecated>
    /// <returns>A new infrared frame source watcher.</returns>
    [Deprecated("PerceptionInfraredFrameSource.CreateWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation.CreateWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern PerceptionInfraredFrameSourceWatcher CreateWatcher();

    /// <summary>Finds all infrared frame sources.</summary>
    /// <deprecated type="deprecate">PerceptionInfraredFrameSource.FindAllAsync may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation.FindAllAsync instead.</deprecated>
    /// <returns>When the method completes, it asynchronously returns a list of infrared frame sources.</returns>
    [Deprecated("PerceptionInfraredFrameSource.FindAllAsync may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation.FindAllAsync instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<PerceptionInfraredFrameSource>> FindAllAsync();

    /// <summary>Finds an infrared frame source by looking up its unique ID.</summary>
    /// <deprecated type="deprecate">PerceptionInfraredFrameSource.FromIdAsync may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation.FromIdAsync instead.</deprecated>
    /// <param name="id">The unique ID of the infrared frame source.</param>
    /// <returns>When the method completes, it asynchronously returns an infrared frame source if one exists with the specified ID. Otherwise, this method asynchronously returns nullptr.</returns>
    [Deprecated("PerceptionInfraredFrameSource.FromIdAsync may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation.FromIdAsync instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PerceptionInfraredFrameSource> FromIdAsync(
      string id);

    /// <summary>Requests access to use infrared frame sources.</summary>
    /// <deprecated type="deprecate">PerceptionInfraredFrameSource.RequestAccessAsync may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.</deprecated>
    /// <returns>When this method completes, it asynchronously returns a PerceptionFrameSourceAccessStatus indicating the result of the access request.</returns>
    [Deprecated("PerceptionInfraredFrameSource.RequestAccessAsync may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PerceptionFrameSourceAccessStatus> RequestAccessAsync();
  }
}
