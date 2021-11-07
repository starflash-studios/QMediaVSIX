// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaCaptureVideoProfile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Capture.Frames;

namespace Windows.Media.Capture
{
  /// <summary>Represents a video profile that indicates a configuration supported by the video capture device.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class MediaCaptureVideoProfile : 
    IMediaCaptureVideoProfile,
    IMediaCaptureVideoProfile2
  {
    /// <summary>Gets the unique identifier of the video profile.</summary>
    /// <returns>The unique identifier of the video profile.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets the device ID of the video device associated with the video profile.</summary>
    /// <returns>The device ID of the video device associated with the video profile.</returns>
    public extern string VideoDeviceId { [MethodImpl] get; }

    /// <summary>Gets a list of MediaCaptureVideoProfileMediaDescription objects that represent supported video device settings for video preview.</summary>
    /// <returns>A list of MediaCaptureVideoProfileMediaDescription objects that represent supported video device settings for video preview.</returns>
    public extern IVectorView<MediaCaptureVideoProfileMediaDescription> SupportedPreviewMediaDescription { [MethodImpl] get; }

    /// <summary>Gets a list of MediaCaptureVideoProfileMediaDescription objects that represent supported video device settings for video recording.</summary>
    /// <returns>A list of MediaCaptureVideoProfileMediaDescription objects that represent supported video device settings for video recording.</returns>
    public extern IVectorView<MediaCaptureVideoProfileMediaDescription> SupportedRecordMediaDescription { [MethodImpl] get; }

    /// <summary>Gets a list of MediaCaptureVideoProfileMediaDescription objects that represent supported video device settings for photo capture.</summary>
    /// <returns>A list of MediaCaptureVideoProfileMediaDescription objects that represent supported video device settings for photo capture.</returns>
    public extern IVectorView<MediaCaptureVideoProfileMediaDescription> SupportedPhotoMediaDescription { [MethodImpl] get; }

    /// <summary>Gets the list of MediaCaptureVideoProfile objects that can be used concurrently with this video profile.</summary>
    /// <returns>The list of MediaCaptureVideoProfile objects that can be used concurrently with this video profile.</returns>
    [MethodImpl]
    public extern IVectorView<MediaCaptureVideoProfile> GetConcurrency();

    /// <summary>Gets a read-only list of MediaFrameSourceInfo objects which provide details about the capabilities of a MediaFrameSource.</summary>
    /// <returns>A read-only list of MediaFrameSourceInfo objects.</returns>
    public extern IVectorView<MediaFrameSourceInfo> FrameSourceInfos { [MethodImpl] get; }

    /// <summary>Gets a read-only map of custom attributes provided by the capture device manufacturer.</summary>
    /// <returns>A read-only map of custom attributes.</returns>
    public extern IMapView<Guid, object> Properties { [MethodImpl] get; }
  }
}
