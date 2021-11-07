// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionColorFrameSource
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
  /// <summary>A frame source that provides color frames.</summary>
  /// <deprecated type="deprecate">PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Frames.MediaFrameSource instead.</deprecated>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IPerceptionColorFrameSourceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class PerceptionColorFrameSource : 
    IPerceptionColorFrameSource,
    IPerceptionColorFrameSource2
  {
    /// <summary>Subscribes to the AvailableChanged event.</summary>
    public extern event TypedEventHandler<PerceptionColorFrameSource, object> AvailableChanged;

    /// <summary>Subscribes to the ActiveChanged event.</summary>
    public extern event TypedEventHandler<PerceptionColorFrameSource, object> ActiveChanged;

    /// <summary>Subscribes to the PropertiesChanged event.</summary>
    public extern event TypedEventHandler<PerceptionColorFrameSource, PerceptionFrameSourcePropertiesChangedEventArgs> PropertiesChanged;

    /// <summary>Subscribes to the VideoProfileChanged event.</summary>
    public extern event TypedEventHandler<PerceptionColorFrameSource, object> VideoProfileChanged;

    /// <summary>Subscribes to the CameraIntrinsicsChanged event.</summary>
    public extern event TypedEventHandler<PerceptionColorFrameSource, object> CameraIntrinsicsChanged;

    /// <summary>Gets a string value indicating the unique ID of the color frame source.</summary>
    /// <returns>A string value indicating the unique ID of the color frame source.</returns>
    public extern string Id { [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string value indicating the display name of the color frame source.</summary>
    /// <returns>A string value indicating the display name of the color frame source.</returns>
    public extern string DisplayName { [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string value indicating the kind of physical device that generates the color frames for this source.</summary>
    /// <returns>A string value indicating the kind of physical device that generates the color frames for this source.</returns>
    public extern string DeviceKind { [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a boolean value indicating whether or not the source is available.</summary>
    /// <returns>A boolean value indicating whether or not the source is available.</returns>
    public extern bool Available { [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a boolean value indicating whether or not the source is active.</summary>
    /// <returns>A boolean value indicating whether or not the source is active.</returns>
    public extern bool Active { [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a boolean value indicating whether or not the source is the subject of controller mode.</summary>
    /// <returns>A boolean value indicating whether or not the source is the subject of controller mode.</returns>
    public extern bool IsControlled { [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a read-only collection of frame source properties.</summary>
    /// <returns>A read-only collection of frame source properties.</returns>
    public extern IMapView<string, object> Properties { [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] [return: HasVariant] get; }

    /// <summary>Gets a read-only collection of video profiles that are supported by the color frame source.</summary>
    /// <returns>A read-only collection of video profiles that are supported by the color frame source.</returns>
    public extern IVectorView<PerceptionVideoProfile> SupportedVideoProfiles { [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a read-only collection of video profiles that are currently available from the color frame source.</summary>
    /// <returns>A read-only collection of video profiles that are currently available from the color frame source.</returns>
    public extern IVectorView<PerceptionVideoProfile> AvailableVideoProfiles { [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a PerceptionVideoProfile object indicating the current video profile.</summary>
    /// <returns>A PerceptionVideoProfile object indicating the current video profile.</returns>
    public extern PerceptionVideoProfile VideoProfile { [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a CameraIntrinsics value specifying the intrinsic properties of the color frame source camera device.</summary>
    /// <returns>A CameraIntrinsics value specifying the intrinsic properties of the color frame source camera device.</returns>
    public extern CameraIntrinsics CameraIntrinsics { [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Attempts to acquire Controller Mode on the color frame source.</summary>
    /// <deprecated type="deprecate">PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.</deprecated>
    /// <returns>If the attempt is successful, this returns a PerceptionControlSession object that can be used to control properties of the color frame source. Otherwise, this returns null.</returns>
    [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern PerceptionControlSession AcquireControlSession();

    /// <summary>This method returns a boolean value indicating whether or not the color frame source can be controlled separately from another frame source.</summary>
    /// <deprecated type="deprecate">PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.</deprecated>
    /// <param name="targetId">A string representing the unique ID of the other frame source.</param>
    /// <returns>Returns true if the two sources can be controlled independently of one another, otherwise returns false.</returns>
    [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern bool CanControlIndependentlyFrom(string targetId);

    /// <summary>Checks whether or not the color frame source is correlated with the target entity. If the result is true, a transform matrix can be retrieved to change coordinate basis from this color frame source to the entity, or vice versa.</summary>
    /// <deprecated type="deprecate">PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.</deprecated>
    /// <param name="targetId">The unique ID of the target entity.</param>
    /// <returns>Returns true if a correlation exists, otherwise returns false.</returns>
    [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern bool IsCorrelatedWith(string targetId);

    [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern bool TryGetTransformTo(string targetId, out Matrix4x4 result);

    /// <summary>Attempts to get the intrinsic properties of the depth camera that is correlated with this color source.</summary>
    /// <deprecated type="deprecate">PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.</deprecated>
    /// <param name="correlatedDepthFrameSource">The depth frame source to try to get intrinsic properties of.</param>
    /// <returns>If the attempt is successful, this will return a read-only collection of PerceptionDepthCorrelatedCameraIntrinsics objects specifying the intrinsic properties of the camera used by the correlated depth frame source. Otherwise, this returns null.</returns>
    [RemoteAsync]
    [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncOperation<PerceptionDepthCorrelatedCameraIntrinsics> TryGetDepthCorrelatedCameraIntrinsicsAsync(
      PerceptionDepthFrameSource correlatedDepthFrameSource);

    /// <summary>Attempts to get a coordinate mapper that maps from color frame image space to depth frame space.</summary>
    /// <deprecated type="deprecate">PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.</deprecated>
    /// <param name="targetSourceId">The unique ID of the depth frame source to try to map to.</param>
    /// <param name="correlatedDepthFrameSource">The depth frame source to try to map to. This should be in a correlation group with the color frame source.</param>
    /// <returns>If the two sources are correlated, this method returns a PerceptionDepthCorrelatedCoordinateMapper. Otherwise, it returns null. This method returns asynchronously.</returns>
    [RemoteAsync]
    [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncOperation<PerceptionDepthCorrelatedCoordinateMapper> TryGetDepthCorrelatedCoordinateMapperAsync(
      string targetSourceId,
      PerceptionDepthFrameSource correlatedDepthFrameSource);

    /// <summary>Attempts to set a video profile on this color frame source. Requires an active Controller Mode control session on this frame source.</summary>
    /// <deprecated type="deprecate">PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.</deprecated>
    /// <param name="controlSession">A PerceptionControlSession representing active control of this frame source.</param>
    /// <param name="profile">The video profile to set.</param>
    /// <returns>This method returns an PerceptionFrameSourcePropertyChangeResult object asynchonously. If the control session was still active when the video profile was set, and if the video profile is supported and can be activated, this will be a result that indicates success.</returns>
    [RemoteAsync]
    [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncOperation<PerceptionFrameSourcePropertyChangeResult> TrySetVideoProfileAsync(
      PerceptionControlSession controlSession,
      PerceptionVideoProfile profile);

    /// <summary>Gets a frame reader that reads frames from this color frame source.</summary>
    /// <deprecated type="deprecate">PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.</deprecated>
    /// <returns>Returns a frame reader that reads frames from this color frame source.</returns>
    [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern PerceptionColorFrameReader OpenReader();

    /// <summary>Gets a string value that identifies the device on the system.</summary>
    /// <returns>The identifier.</returns>
    public extern string DeviceId { [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Creates a new color frame source watcher.</summary>
    /// <deprecated type="deprecate">PerceptionColorFrameSource.CreateWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation.CreateWatcher instead.</deprecated>
    /// <returns>A new color frame source watcher.</returns>
    [Deprecated("PerceptionColorFrameSource.CreateWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation.CreateWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern PerceptionColorFrameSourceWatcher CreateWatcher();

    /// <summary>Finds all color frame sources.</summary>
    /// <deprecated type="deprecate">PerceptionColorFrameSource.FindAllAsync may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation.FindAllAsync instead.</deprecated>
    /// <returns>When the method completes, it asynchronously returns a list of color frame sources.</returns>
    [Deprecated("PerceptionColorFrameSource.FindAllAsync may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation.FindAllAsync instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<PerceptionColorFrameSource>> FindAllAsync();

    /// <summary>Finds an color frame source by looking up its unique ID.</summary>
    /// <deprecated type="deprecate">PerceptionColorFrameSource.FromIdAsync may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation.FromIdAsync instead.</deprecated>
    /// <param name="id">The unique ID of the color frame source.</param>
    /// <returns>When this method completes, it asynchronously returns a color frame source if one exists with the specified ID. Otherwise, this method asynchronously returns null.</returns>
    [Deprecated("PerceptionColorFrameSource.FromIdAsync may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation.FromIdAsync instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PerceptionColorFrameSource> FromIdAsync(
      string id);

    /// <summary>Requests access to use color frame sources.</summary>
    /// <deprecated type="deprecate">PerceptionColorFrameSource.RequestAccessAsync may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.</deprecated>
    /// <returns>When this method completes, it asynchronously returns a PerceptionFrameSourceAccessStatus indicating the result of the access request.</returns>
    [RemoteAsync]
    [Deprecated("PerceptionColorFrameSource.RequestAccessAsync may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncOperation<PerceptionFrameSourceAccessStatus> RequestAccessAsync();
  }
}
