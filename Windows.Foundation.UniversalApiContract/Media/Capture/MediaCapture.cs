// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaCapture
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.Media.Capture.Core;
using Windows.Media.Capture.Frames;
using Windows.Media.Devices;
using Windows.Media.Effects;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.WindowManagement;

namespace Windows.Media.Capture
{
  /// <summary>Provides functionality for capturing photos, audio, and videos from a capture device, such as a webcam.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IMediaCaptureStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  public sealed class MediaCapture : 
    IMediaCapture,
    IMediaCaptureVideoPreview,
    IMediaCapture2,
    IClosable,
    IMediaCapture3,
    IMediaCapture4,
    IMediaCapture5,
    IMediaCapture6,
    IMediaCapture7
  {
    /// <summary>Creates a new instance of the MediaCapture object.</summary>
    [MethodImpl]
    public extern MediaCapture();

    /// <summary>Initializes the MediaCapture object, using default settings.</summary>
    /// <returns>Returns a IAsyncAction object that is used to control the asynchronous operation.</returns>
    [Overload("InitializeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction InitializeAsync();

    /// <summary>Initializes the MediaCapture object.</summary>
    /// <param name="mediaCaptureInitializationSettings">The initialization settings.</param>
    /// <returns>Returns a IAsyncAction object that is used to control the asynchronous operation.</returns>
    [Overload("InitializeWithSettingsAsync")]
    [MethodImpl]
    public extern IAsyncAction InitializeAsync(
      MediaCaptureInitializationSettings mediaCaptureInitializationSettings);

    /// <summary>Starts recording asynchronously to a storage file.</summary>
    /// <param name="encodingProfile">The encoding profile for the recording.</param>
    /// <param name="file">The storage file where the image is saved.</param>
    /// <returns>Returns a IAsyncAction object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StartRecordToStorageFileAsync(
      MediaEncodingProfile encodingProfile,
      IStorageFile file);

    /// <summary>Starts recording to a random-access stream.</summary>
    /// <param name="encodingProfile">The encoding profile for the recording.</param>
    /// <param name="stream">The stream where the image data is written.</param>
    /// <returns>Returns a IAsyncAction object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StartRecordToStreamAsync(
      MediaEncodingProfile encodingProfile,
      IRandomAccessStream stream);

    /// <summary>Start recording to a custom media sink using the specified encoding profile.</summary>
    /// <param name="encodingProfile">The encoding profile to use for the recording.</param>
    /// <param name="customMediaSink">The media extension for the custom media sink.</param>
    /// <returns>An object that is used to control the asynchronous operation.</returns>
    [Overload("StartRecordToCustomSinkAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StartRecordToCustomSinkAsync(
      MediaEncodingProfile encodingProfile,
      IMediaExtension customMediaSink);

    /// <summary>Start recording to a custom media sink using the specified encoding profile and sink settings.</summary>
    /// <param name="encodingProfile">The encoding profile to use for the recording.</param>
    /// <param name="customSinkActivationId">The activatable class ID of the media extension for the custom media sink.</param>
    /// <param name="customSinkSettings">Contains properties of the media extension.</param>
    /// <returns>An object that is used to control the asynchronous operation.</returns>
    [Overload("StartRecordToCustomSinkIdAsync")]
    [MethodImpl]
    public extern IAsyncAction StartRecordToCustomSinkAsync(
      MediaEncodingProfile encodingProfile,
      string customSinkActivationId,
      IPropertySet customSinkSettings);

    /// <summary>Stops recording.</summary>
    /// <returns>Returns a IAsyncAction object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StopRecordAsync();

    /// <summary>Captures a photo to a storage file.</summary>
    /// <param name="type">The encoding properties for the output image.</param>
    /// <param name="file">The storage file where the image is saved.</param>
    /// <returns>Returns an IAsyncAction object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CapturePhotoToStorageFileAsync(
      ImageEncodingProperties type,
      IStorageFile file);

    /// <summary>Captures a photo to a random-access stream.</summary>
    /// <param name="type">The encoding properties for the output image.</param>
    /// <param name="stream">The stream where the image data is written.</param>
    /// <returns>Returns an IAsyncAction object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CapturePhotoToStreamAsync(
      ImageEncodingProperties type,
      IRandomAccessStream stream);

    /// <summary>Adds an audio or video effect.</summary>
    /// <deprecated type="deprecate">AddEffectAsync might not be available in future versions of Windows. Starting with Windows Threshold, use AddAudioEffectAsync and AddVideoEffectAsync instead</deprecated>
    /// <param name="mediaStreamType">Specifies the streams to which the effect will be applied.</param>
    /// <param name="effectActivationID">The class identifier of the activatable runtime class that implements the effect. The runtime class must implement the IMediaExtension interface.</param>
    /// <param name="effectSettings">Configuration parameters for the effect.</param>
    /// <returns>Returns an IAsyncAction object that is used to control the asynchronous operation.</returns>
    [Deprecated("AddEffectAsync might not be available in future versions of Windows. Starting with Windows Threshold, use AddAudioEffectAsync and AddVideoEffectAsync instead", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncAction AddEffectAsync(
      MediaStreamType mediaStreamType,
      string effectActivationID,
      IPropertySet effectSettings);

    /// <summary>Removes all audio and video effects from a stream.</summary>
    /// <param name="mediaStreamType">The stream from which to remove the effects.</param>
    /// <returns>Returns a IAsyncAction object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ClearEffectsAsync(MediaStreamType mediaStreamType);

    /// <summary>Sets an encoding property.</summary>
    /// <param name="mediaStreamType">The type of media data the stream represents, such as video or audio.</param>
    /// <param name="propertyId">The encoding property to set.</param>
    /// <param name="propertyValue">The new value of the encoding property.</param>
    [MethodImpl]
    public extern void SetEncoderProperty(
      MediaStreamType mediaStreamType,
      Guid propertyId,
      object propertyValue);

    /// <summary>Gets the value of an encoding property.</summary>
    /// <param name="mediaStreamType">Specifies the stream to query for the encoding property.</param>
    /// <param name="propertyId">The encoding property to retrieve.</param>
    /// <returns>Returns the value of the encoding property.</returns>
    [MethodImpl]
    public extern object GetEncoderProperty(MediaStreamType mediaStreamType, Guid propertyId);

    /// <summary>Raised when an error occurs during media capture.</summary>
    public extern event MediaCaptureFailedEventHandler Failed;

    /// <summary>Occurs when the record limit is exceeded.</summary>
    public extern event RecordLimitationExceededEventHandler RecordLimitationExceeded;

    /// <summary>Gets the configuration settings for the MediaCapture object.</summary>
    /// <returns>A MediaCaptureSettings object that contains the settings.</returns>
    public extern MediaCaptureSettings MediaCaptureSettings { [MethodImpl] get; }

    /// <summary>Gets an object that controls settings for the microphone.</summary>
    /// <returns>An AudioDeviceController object that controls settings for the microphone.</returns>
    public extern AudioDeviceController AudioDeviceController { [MethodImpl] get; }

    /// <summary>Gets an object that controls settings for the video camera.</summary>
    /// <returns>A VideoDeviceController object.</returns>
    public extern VideoDeviceController VideoDeviceController { [MethodImpl] get; }

    /// <summary>Enables or disables horizontal mirroring of the video preview stream. This is not the preferred method for mirroring. See the Remarks section below for details.</summary>
    /// <param name="value">True to enable mirroring; false to disable mirroring.</param>
    [MethodImpl]
    public extern void SetPreviewMirroring(bool value);

    /// <summary>Queries whether the video stream is mirrored horizontally.</summary>
    /// <returns>True if mirroring is enabled; false otherwise.</returns>
    [MethodImpl]
    public extern bool GetPreviewMirroring();

    /// <summary>Rotates the video preview stream.</summary>
    /// <param name="value">The amount by which to rotate the video.</param>
    [MethodImpl]
    public extern void SetPreviewRotation(VideoRotation value);

    /// <summary>Gets the rotation of the video preview stream.</summary>
    /// <returns>The amount by which the video preview stream is rotated.</returns>
    [MethodImpl]
    public extern VideoRotation GetPreviewRotation();

    /// <summary>Rotates the recorded video.</summary>
    /// <param name="value">The amount by which to rotate the video.</param>
    [MethodImpl]
    public extern void SetRecordRotation(VideoRotation value);

    /// <summary>Gets the rotation of the recorded video.</summary>
    /// <returns>The amount by which the recorded video is rotated.</returns>
    [MethodImpl]
    public extern VideoRotation GetRecordRotation();

    /// <summary>Starts preview.</summary>
    /// <returns>Returns a IAsyncAction object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StartPreviewAsync();

    /// <summary>Starts sending a preview stream to a custom media sink using the specified encoding profile.</summary>
    /// <param name="encodingProfile">The encoding profile to use for the recording.</param>
    /// <param name="customMediaSink">The media extension for the custom media sink.</param>
    /// <returns>An object that is used to control the asynchronous operation.</returns>
    [Overload("StartPreviewToCustomSinkAsync")]
    [MethodImpl]
    public extern IAsyncAction StartPreviewToCustomSinkAsync(
      MediaEncodingProfile encodingProfile,
      IMediaExtension customMediaSink);

    /// <summary>Starts sending a preview stream to a custom media sink using the specified encoding profile and sink settings.</summary>
    /// <param name="encodingProfile">The encoding profile to use for the recording.</param>
    /// <param name="customSinkActivationId">The activatable class ID of the media extension for the custom media sink.</param>
    /// <param name="customSinkSettings">Contains properties of the media extension.</param>
    /// <returns>An object that is used to control the asynchronous operation.</returns>
    [Overload("StartPreviewToCustomSinkIdAsync")]
    [MethodImpl]
    public extern IAsyncAction StartPreviewToCustomSinkAsync(
      MediaEncodingProfile encodingProfile,
      string customSinkActivationId,
      IPropertySet customSinkSettings);

    /// <summary>Stops preview.</summary>
    /// <returns>Returns a IAsyncAction object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StopPreviewAsync();

    /// <summary>Initializes the low lag recording using the specified file to store the recording. This method provides the LowLagMediaRecording object used to managed the recording.</summary>
    /// <param name="encodingProfile">The encoding profile for the recording.</param>
    /// <param name="file">The storage file where the image is saved.</param>
    /// <returns>When this method completes, a LowLagMediaRecording object is returned which can be used to start the photo capture.</returns>
    [MethodImpl]
    public extern IAsyncOperation<LowLagMediaRecording> PrepareLowLagRecordToStorageFileAsync(
      MediaEncodingProfile encodingProfile,
      IStorageFile file);

    /// <summary>Initializes the low lag recording using the specified random-access stream to store the recording. This method provides the LowLagMediaRecording object used to managed the recording.</summary>
    /// <param name="encodingProfile">The encoding profile for the recording.</param>
    /// <param name="stream">The stream where the image data is written.</param>
    /// <returns>When this method completes, a LowLagMediaRecording object is returned which can be used to start the photo capture.</returns>
    [MethodImpl]
    public extern IAsyncOperation<LowLagMediaRecording> PrepareLowLagRecordToStreamAsync(
      MediaEncodingProfile encodingProfile,
      IRandomAccessStream stream);

    /// <summary>Initializes the low lag recording using the specified custom sink to store the recording. This method provides the LowLagMediaRecording object used to managed the capture.</summary>
    /// <param name="encodingProfile">The encoding profile to use for the recording.</param>
    /// <param name="customMediaSink">The media extension for the custom media sink.</param>
    /// <returns>When this method completes, a LowLagMediaRecording object is returned which can be used to start the photo capture.</returns>
    [Overload("PrepareLowLagRecordToCustomSinkAsync")]
    [MethodImpl]
    public extern IAsyncOperation<LowLagMediaRecording> PrepareLowLagRecordToCustomSinkAsync(
      MediaEncodingProfile encodingProfile,
      IMediaExtension customMediaSink);

    /// <summary>Initializes the low lag recording using the specified custom sink to store the recording. This method provides the LowLagMediaRecording object used to managed the recording.</summary>
    /// <param name="encodingProfile">The encoding profile to use for the recording.</param>
    /// <param name="customSinkActivationId">The activatable class ID of the media extension for the custom media sink.</param>
    /// <param name="customSinkSettings">Contains properties of the media extension.</param>
    /// <returns>When this method completes, a LowLagMediaRecording object is returned which can be used to start the photo capture.</returns>
    [Overload("PrepareLowLagRecordToCustomSinkIdAsync")]
    [MethodImpl]
    public extern IAsyncOperation<LowLagMediaRecording> PrepareLowLagRecordToCustomSinkAsync(
      MediaEncodingProfile encodingProfile,
      string customSinkActivationId,
      IPropertySet customSinkSettings);

    /// <summary>Initializes the low shutter lag photo capture and provides the LowLagPhotoCapture object used to manage the recording.</summary>
    /// <param name="type">The encoding profile used for the image.</param>
    /// <returns>When this method completes, a LowLagPhotoCapture object is returned which can be used to start the photo capture.</returns>
    [MethodImpl]
    public extern IAsyncOperation<LowLagPhotoCapture> PrepareLowLagPhotoCaptureAsync(
      ImageEncodingProperties type);

    /// <summary>Initializes the low shutter lag photo sequence capture and provides the LowLagPhotoSequenceCapture object used to manage the recording.</summary>
    /// <param name="type">The encoding profile used for the image.</param>
    /// <returns>When this method completes, a LowLagPhotoSequenceCapture object is returned which can be used to start the photo sequence capture.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<LowLagPhotoSequenceCapture> PrepareLowLagPhotoSequenceCaptureAsync(
      ImageEncodingProperties type);

    /// <summary>Asynchronously sets the media encoding properties.</summary>
    /// <param name="mediaStreamType">The type of media data the stream represents, such as video or audio.</param>
    /// <param name="mediaEncodingProperties">The properties for the media encoding.</param>
    /// <param name="encoderProperties">The properties for the encoder.</param>
    /// <returns>Object that is used to control the asynchronous operation.</returns>
    [MethodImpl]
    public extern IAsyncAction SetEncodingPropertiesAsync(
      MediaStreamType mediaStreamType,
      IMediaEncodingProperties mediaEncodingProperties,
      MediaPropertySet encoderProperties);

    [MethodImpl]
    public extern void Close();

    /// <summary>Initializes the variable photo sequence capture and provides the VariablePhotoSequenceCapture object used to manage the recording.</summary>
    /// <param name="type">The encoding profile used for the image.</param>
    /// <returns>When this method completes, a VariablePhotoSequenceCapture object is returned which can be used to start the photo sequence capture.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VariablePhotoSequenceCapture> PrepareVariablePhotoSequenceCaptureAsync(
      ImageEncodingProperties type);

    /// <summary>Occurs when the capture device changes focus.</summary>
    public extern event TypedEventHandler<MediaCapture, MediaCaptureFocusChangedEventArgs> FocusChanged;

    /// <summary>Occurs when a photo confirmation frame is captured.</summary>
    public extern event TypedEventHandler<MediaCapture, PhotoConfirmationCapturedEventArgs> PhotoConfirmationCaptured;

    /// <summary>Adds an audio effect to the capture pipeline.</summary>
    /// <param name="definition">The object containing the definition of the effect to be added.</param>
    /// <returns>An asynchronous operation that returns an IMediaExtension upon successful completion.</returns>
    [MethodImpl]
    public extern IAsyncOperation<IMediaExtension> AddAudioEffectAsync(
      IAudioEffectDefinition definition);

    /// <summary>Adds a video effect to the capture pipeline.</summary>
    /// <param name="definition">The object containing the definition of the effect to be added.</param>
    /// <param name="mediaStreamType">Specifies the streams to which the effect will be applied.</param>
    /// <returns>An asynchronous operation that returns an IMediaExtension upon successful completion.</returns>
    [MethodImpl]
    public extern IAsyncOperation<IMediaExtension> AddVideoEffectAsync(
      IVideoEffectDefinition definition,
      MediaStreamType mediaStreamType);

    /// <summary>Pauses an ongoing record operation.</summary>
    /// <param name="behavior">A value indicating whether the media capture hardware resources should be preserved or released while recording is paused.</param>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction PauseRecordAsync(MediaCapturePauseBehavior behavior);

    /// <summary>Resumes a paused recording operation.</summary>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ResumeRecordAsync();

    /// <summary>Occurs when the state of the camera stream changes.</summary>
    public extern event TypedEventHandler<MediaCapture, object> CameraStreamStateChanged;

    /// <summary>Gets the current stream state of the camera stream.</summary>
    /// <returns>The current stream state of the camera stream.</returns>
    public extern CameraStreamState CameraStreamState { [MethodImpl] get; }

    /// <summary>Gets a preview frame from the capture device.</summary>
    /// <returns>An asynchronous operation that returns a VideoFrame on successful completion.</returns>
    [Overload("GetPreviewFrameAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VideoFrame> GetPreviewFrameAsync();

    /// <summary>Gets a preview frame from the capture device, copied into the provided destination VideoFrame and converted into the destination frame's format.</summary>
    /// <param name="destination">The video frame into which the preview frame will be copied.</param>
    /// <returns>An asynchronous operation that returns a VideoFrame on successful completion.</returns>
    [Overload("GetPreviewFrameCopyAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VideoFrame> GetPreviewFrameAsync(
      VideoFrame destination);

    /// <summary>Occurs when the thermal status of the capture device changes.</summary>
    public extern event TypedEventHandler<MediaCapture, object> ThermalStatusChanged;

    /// <summary>Gets a value that indicates the current thermal status of the capture device.</summary>
    /// <returns>A value that indicates the current thermal status of the capture device.</returns>
    public extern MediaCaptureThermalStatus ThermalStatus { [MethodImpl] get; }

    /// <summary>Initializes the advanced photo capture and provides the AdvancedPhotoCapture object used to manage the recording.</summary>
    /// <param name="encodingProperties">The encoding properties used for the resulting image.</param>
    /// <returns>An asynchronous operation that returns an AdvancedPhotoCapture object on successful completion.</returns>
    [MethodImpl]
    public extern IAsyncOperation<AdvancedPhotoCapture> PrepareAdvancedPhotoCaptureAsync(
      ImageEncodingProperties encodingProperties);

    /// <summary>Removes the specified effect from the capture pipeline.</summary>
    /// <param name="effect">The effect to remove from the capture pipeline.</param>
    /// <returns>Returns an IAsyncAction object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RemoveEffectAsync(IMediaExtension effect);

    /// <summary>Pauses an ongoing media record operation and provides a MediaCapturePauseResult that can be used to help the user align the camera with the last captured frame when resuming recording.</summary>
    /// <param name="behavior">A value indicating whether the media capture hardware resources should be preserved or released while recording is paused.</param>
    /// <returns>An asynchronous action that returns a MediaCapturePauseResult upon completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaCapturePauseResult> PauseRecordWithResultAsync(
      MediaCapturePauseBehavior behavior);

    /// <summary>Asynchronously stops the media recording and provides a MediaCaptureStopResult that can be used to help the user align the camera with the last captured frame when restarting recording.</summary>
    /// <returns>An asynchronous action that returns a MediaCaptureStopResult upon completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaCaptureStopResult> StopRecordWithResultAsync();

    /// <summary>Gets a read-only dictionary of MediaFrameSource objects that can be used simultaneously to acquire media frames.</summary>
    /// <returns>A read-only dictionary of MediaFrameSource objects that can be used simultaneously to acquire media frames.</returns>
    public extern IMapView<string, MediaFrameSource> FrameSources { [MethodImpl] get; }

    /// <summary>Creates a MediaFrameReader that is used to acquire frames from a MediaFrameSource.</summary>
    /// <param name="inputSource">The media frame source from which the reader will acquire frames.</param>
    /// <returns>An asynchronous operation that returns a MediaFrameReader on completion.</returns>
    [Overload("CreateFrameReaderAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaFrameReader> CreateFrameReaderAsync(
      MediaFrameSource inputSource);

    /// <summary>Creates a MediaFrameReader that is used to acquire frames with the specified media encoding subtype from a MediaFrameSource.</summary>
    /// <param name="inputSource">The media frame source from which the reader will acquire frames.</param>
    /// <param name="outputSubtype">A string specifying the requested media encoding subtype for the frames acquired by the frame reader. This value must be one of the strings defined by the properties of the MediaEncodingSubtypes class.</param>
    /// <returns>An asynchronous operation that returns a MediaFrameReader on completion.</returns>
    [RemoteAsync]
    [Overload("CreateFrameReaderWithSubtypeAsync")]
    [MethodImpl]
    public extern IAsyncOperation<MediaFrameReader> CreateFrameReaderAsync(
      MediaFrameSource inputSource,
      string outputSubtype);

    /// <summary>Creates a MediaFrameReader that is used to acquire frames with the specified media encoding subtype and size from a MediaFrameSource.</summary>
    /// <param name="inputSource">The media frame source from which the reader will acquire frames.</param>
    /// <param name="outputSubtype">A string specifying the requested media encoding subtype for the frames acquired by the frame reader. This value must be one of the strings defined by the properties of the MediaEncodingSubtypes class.</param>
    /// <param name="outputSize">An object specifying the requested size for the frames acquired by the frame reader.</param>
    /// <returns>An asynchronous operation that returns a MediaFrameReader on completion.</returns>
    [Overload("CreateFrameReaderWithSubtypeAndSizeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaFrameReader> CreateFrameReaderAsync(
      MediaFrameSource inputSource,
      string outputSubtype,
      BitmapSize outputSize);

    /// <summary>Occurs when the exclusive control status of the capture device changes.</summary>
    public extern event TypedEventHandler<MediaCapture, MediaCaptureDeviceExclusiveControlStatusChangedEventArgs> CaptureDeviceExclusiveControlStatusChanged;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MultiSourceMediaFrameReader> CreateMultiSourceFrameReaderAsync(
      IIterable<MediaFrameSource> inputSources);

    /// <summary>Creates a new instance of the MediaCaptureRelativePanelWatcher class, which monitors the panel associated with the provided DisplayRegion, so that the app receives notifications when the relative location of the panel changes.</summary>
    /// <param name="captureMode">A value from the StreamingCaptureMode enumeration enumeration.</param>
    /// <param name="displayRegion">A DisplayRegion for which the associated panel is monitored for changes. Typically this display region will be the camera view finder UI element, so that the app is alerted if the relative location of the panel containing the view finder changes.</param>
    /// <returns>A new instance of the MediaCaptureRelativePanelWatcher class.</returns>
    [MethodImpl]
    public extern MediaCaptureRelativePanelWatcher CreateRelativePanelWatcher(
      StreamingCaptureMode captureMode,
      DisplayRegion displayRegion);

    /// <summary>Gets a boolean value indicating whether video profiles are supported by the specified video capture device.</summary>
    /// <param name="videoDeviceId">The identifier of the video device for which supported video profile support is queried. For information on getting the video device ID, see DeviceInformation.FindAllAsync.</param>
    /// <returns>True if video profiles are supported; otherwise, false.</returns>
    [MethodImpl]
    public static extern bool IsVideoProfileSupported(string videoDeviceId);

    /// <summary>Retrieves the list of all video profiles supported by the specified video capture device.</summary>
    /// <param name="videoDeviceId">The identifier of the video device for which supported video profiles are queried. For information on getting the video device ID, see DeviceInformation.FindAllAsync.</param>
    /// <returns>The list of video profiles supported by the specified video capture device.</returns>
    [MethodImpl]
    public static extern IVectorView<MediaCaptureVideoProfile> FindAllVideoProfiles(
      string videoDeviceId);

    /// <summary>Retrieves the list of video profiles supported by the specified video capture device that can be used while another profile is used on a different capture device.</summary>
    /// <param name="videoDeviceId">The identifier of the video device for which supported video profiles are queried. For information on getting the video device ID, see DeviceInformation.FindAllAsync.</param>
    /// <returns>The list of video profiles supported by the specified video capture device that support concurrency.</returns>
    [MethodImpl]
    public static extern IVectorView<MediaCaptureVideoProfile> FindConcurrentProfiles(
      string videoDeviceId);

    /// <summary>Retrieves the list of all video profiles supported by the specified video capture device that match the specified KnownVideoProfile value.</summary>
    /// <param name="videoDeviceId">The identifier of the video device for which supported video profiles are queried. For information on getting the video device ID, see DeviceInformation.FindAllAsync.</param>
    /// <param name="name">A value specifying one of the profile names known by the system.</param>
    /// <returns>The list of video profiles supported by the specified video capture device that match the specified known profile name.</returns>
    [MethodImpl]
    public static extern IVectorView<MediaCaptureVideoProfile> FindKnownVideoProfiles(
      string videoDeviceId,
      KnownVideoProfile name);
  }
}
