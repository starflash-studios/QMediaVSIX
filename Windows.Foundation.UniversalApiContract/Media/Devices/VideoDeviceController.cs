// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.VideoDeviceController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.Media.Devices.Core;
using Windows.Media.MediaProperties;

namespace Windows.Media.Devices
{
  /// <summary>Controls device settings on the camera.</summary>
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [DualApiPartition(version = 100794368)]
  public sealed class VideoDeviceController : 
    IVideoDeviceController,
    IMediaDeviceController,
    IAdvancedVideoCaptureDeviceController,
    IAdvancedVideoCaptureDeviceController2,
    IAdvancedVideoCaptureDeviceController3,
    IAdvancedVideoCaptureDeviceController4,
    IAdvancedVideoCaptureDeviceController5,
    IAdvancedVideoCaptureDeviceController6,
    IAdvancedVideoCaptureDeviceController7,
    IAdvancedVideoCaptureDeviceController8,
    IAdvancedVideoCaptureDeviceController9,
    IAdvancedVideoCaptureDeviceController10
  {
    /// <summary>Gets a MediaDeviceControl object that can be used to get or set the brightness level on the camera.</summary>
    /// <returns>A MediaDeviceControl object that provides methods to get and set the brightness.</returns>
    public extern MediaDeviceControl Brightness { [MethodImpl] get; }

    /// <summary>Gets a MediaDeviceControl object that can be used to get or set the contrast level on the camera.</summary>
    /// <returns>A MediaDeviceControl object that provides methods to get and set the contrast.</returns>
    public extern MediaDeviceControl Contrast { [MethodImpl] get; }

    /// <summary>Gets a MediaDeviceControl object that can be used to get or set the camera's hue setting.</summary>
    /// <returns>A MediaDeviceControl object that provides methods to get and set the hue.</returns>
    public extern MediaDeviceControl Hue { [MethodImpl] get; }

    /// <summary>Gets a MediaDeviceControl object that can be used to get or set the white balance on the camera.</summary>
    /// <returns>A MediaDeviceControl object that provides methods to get and set the white balance.</returns>
    public extern MediaDeviceControl WhiteBalance { [MethodImpl] get; }

    /// <summary>Gets a MediaDeviceControl object that can be used to get or set the whether back-light compensation is enabled on the camera.</summary>
    /// <returns>A MediaDeviceControl object that provides methods to get and set the back-light compensation.</returns>
    public extern MediaDeviceControl BacklightCompensation { [MethodImpl] get; }

    /// <summary>Gets a MediaDeviceControl object that can be used to get or set the camera's pan setting.</summary>
    /// <returns>A MediaDeviceControl object that provides methods to get and set the pan.</returns>
    public extern MediaDeviceControl Pan { [MethodImpl] get; }

    /// <summary>Gets a MediaDeviceControl object that can be used to get or set the camera's tilt setting.</summary>
    /// <returns>A MediaDeviceControl object that provides methods to get and set the tilt.</returns>
    public extern MediaDeviceControl Tilt { [MethodImpl] get; }

    /// <summary>Gets a MediaDeviceControl object that can be used to get or set the camera's zoom setting.</summary>
    /// <returns>A MediaDeviceControl object that provides methods to get and set the zoom.</returns>
    public extern MediaDeviceControl Zoom { [MethodImpl] get; }

    /// <summary>Gets a MediaDeviceControl object that can be used to get or set the camera's roll setting.</summary>
    /// <returns>A MediaDeviceControl object that provides methods to get and set the roll.</returns>
    public extern MediaDeviceControl Roll { [MethodImpl] get; }

    /// <summary>Gets a MediaDeviceControl object that can be used to get or set the camera's exposure time.</summary>
    /// <returns>A MediaDeviceControl object that provides methods to get and set the exposure time.</returns>
    public extern MediaDeviceControl Exposure { [MethodImpl] get; }

    /// <summary>Gets a MediaDeviceControl object that can be used to get or set the camera's focus setting.</summary>
    /// <returns>A MediaDeviceControl object that provides methods to get and set the focus.</returns>
    public extern MediaDeviceControl Focus { [MethodImpl] get; }

    /// <summary>Sets the local power line frequency.</summary>
    /// <param name="value">The power line frequency.</param>
    /// <returns>Returns true if the method succeeded, or false otherwise.</returns>
    [MethodImpl]
    public extern bool TrySetPowerlineFrequency(PowerlineFrequency value);

    /// <summary>Gets the local power line frequency.</summary>
    /// <param name="value">The power line frequency.</param>
    /// <returns>Returns true if the method succeeded, or false otherwise.</returns>
    [MethodImpl]
    public extern bool TryGetPowerlineFrequency(out PowerlineFrequency value);

    /// <summary>Gets a list of the supported encoding properties for the video device.</summary>
    /// <param name="mediaStreamType">The type of media stream for which to get the properties.</param>
    /// <returns>A list of the supported encoding properties.</returns>
    [MethodImpl]
    public extern IVectorView<IMediaEncodingProperties> GetAvailableMediaStreamProperties(
      MediaStreamType mediaStreamType);

    /// <summary>Gets the encoding properties for the specified media stream type for the video device.</summary>
    /// <param name="mediaStreamType">The type of media stream for which to get the properties.</param>
    /// <returns>The encoding properties.</returns>
    [MethodImpl]
    public extern IMediaEncodingProperties GetMediaStreamProperties(
      MediaStreamType mediaStreamType);

    /// <summary>Sets the encoding properties asynchronously for the specified media stream type for the video device.</summary>
    /// <param name="mediaStreamType">The type of media stream for which to set the properties.</param>
    /// <param name="mediaEncodingProperties">The encoding properties to set.</param>
    /// <returns>An IAsyncAction object that is used to control the asynchronous operation.</returns>
    [MethodImpl]
    public extern IAsyncAction SetMediaStreamPropertiesAsync(
      MediaStreamType mediaStreamType,
      IMediaEncodingProperties mediaEncodingProperties);

    /// <summary>Sets the value of the property with the specified ID on the capture device driver. You can use this method to set properties that are specific to a particular camera.</summary>
    /// <param name="propertyId">The identifier of the property for which the value is set.</param>
    /// <param name="propertyValue">The new value of the property.</param>
    [MethodImpl]
    public extern void SetDeviceProperty(string propertyId, [Variant] object propertyValue);

    /// <summary>Gets the value of the property with the specified ID from the capture device driver. You can use this method to query properties that are specific to a particular camera.</summary>
    /// <param name="propertyId">The identifier of the property for which the value is retrieved.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    [return: Variant]
    public extern object GetDeviceProperty(string propertyId);

    /// <summary>Gets the low shutter lag photo sequence control for this video device.</summary>
    /// <returns>The photo sequence control.</returns>
    public extern LowLagPhotoSequenceControl LowLagPhotoSequence { [MethodImpl] get; }

    /// <summary>Gets the low shutter lag photo control for this video device.</summary>
    /// <returns>The low shutter lag photo control.</returns>
    public extern LowLagPhotoControl LowLagPhoto { [MethodImpl] get; }

    /// <summary>Gets the scene mode control for this video device.</summary>
    /// <returns>The scene mode control.</returns>
    public extern SceneModeControl SceneModeControl { [MethodImpl] get; }

    /// <summary>Gets the torch control for this video device.</summary>
    /// <returns>The torch control.</returns>
    public extern TorchControl TorchControl { [MethodImpl] get; }

    /// <summary>Gets the flash control for this video device.</summary>
    /// <returns>The flash control.</returns>
    public extern FlashControl FlashControl { [MethodImpl] get; }

    /// <summary>Gets the white balance control for this video device.</summary>
    /// <returns>The white balance control.</returns>
    public extern WhiteBalanceControl WhiteBalanceControl { [MethodImpl] get; }

    /// <summary>Gets the exposure control for this video device.</summary>
    /// <returns>The exposure control.</returns>
    public extern ExposureControl ExposureControl { [MethodImpl] get; }

    /// <summary>Gets the focus control for this video device.</summary>
    /// <returns>The focus control.</returns>
    public extern FocusControl FocusControl { [MethodImpl] get; }

    /// <summary>Gets the exposure compensation control for this video device.</summary>
    /// <returns>The exposure compensation control</returns>
    public extern ExposureCompensationControl ExposureCompensationControl { [MethodImpl] get; }

    /// <summary>Gets the ISO film speed control for this video device.</summary>
    /// <returns>The ISO film speed control.</returns>
    public extern IsoSpeedControl IsoSpeedControl { [MethodImpl] get; }

    /// <summary>Gets the regions of interest control for this video device.</summary>
    /// <returns>The regions of interest control.</returns>
    public extern RegionsOfInterestControl RegionsOfInterestControl { [MethodImpl] get; }

    /// <summary>Gets or sets the primary use for the device.</summary>
    /// <returns>The primary use for the device.</returns>
    public extern CaptureUse PrimaryUse { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the VariablePhotoSequenceController associated with the VideoDeviceController.</summary>
    /// <returns>The VariablePhotoSequenceController associated with the VideoDeviceController.</returns>
    public extern VariablePhotoSequenceController VariablePhotoSequenceController { [MethodImpl] get; }

    /// <summary>Gets the photo confirmation control for this video device.</summary>
    /// <returns>The photo confirmation control for this video device.</returns>
    public extern PhotoConfirmationControl PhotoConfirmationControl { [MethodImpl] get; }

    /// <summary>Gets the ZoomControl associated with the VideoDeviceController.</summary>
    /// <returns>The ZoomControl associated with the VideoDeviceController.</returns>
    public extern ZoomControl ZoomControl { [MethodImpl] get; }

    /// <summary>Gets the ExposurePriorityVideoControl associated with the VideoDeviceController.</summary>
    /// <returns>The ExposurePriorityVideoControl associated with the VideoDeviceController.</returns>
    public extern ExposurePriorityVideoControl ExposurePriorityVideoControl { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates the optimizations the capture device should use to prioritize high quality picture, low latency, or low power consumption during video capture.</summary>
    /// <returns>A value that indicates the optimizations the capture device should use.</returns>
    public extern MediaCaptureOptimization DesiredOptimization { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the HdrVideoControl associated with the VideoDeviceController. This allows you to enable and disable High Dynamic Range (HDR) video capture mode on devices that support it.</summary>
    /// <returns>The HdrVideoControl associated with the VideoDeviceController.</returns>
    public extern HdrVideoControl HdrVideoControl { [MethodImpl] get; }

    /// <summary>Gets the OpticalImageStabilizationControl associated with the VideoDeviceController.</summary>
    /// <returns>The OpticalImageStabilizationControl associated with the VideoDeviceController.</returns>
    public extern OpticalImageStabilizationControl OpticalImageStabilizationControl { [MethodImpl] get; }

    /// <summary>Gets the advanced photo capture control for this video device.</summary>
    /// <returns>The advanced photo capture control</returns>
    public extern AdvancedPhotoControl AdvancedPhotoControl { [MethodImpl] get; }

    /// <summary>Gets a string containing the identifier for the video device controller.</summary>
    /// <returns>The identifier for the video device controller.</returns>
    public extern string Id { [MethodImpl] get; }

    [MethodImpl]
    public extern VideoDeviceControllerGetDevicePropertyResult GetDevicePropertyById(
      string propertyId,
      IReference<uint> maxPropertyValueSize);

    /// <summary>Sets the value of the property with the specified ID from the capture device driver, using an extended ID with custom header information and providing the value as an object.</summary>
    /// <param name="propertyId">A byte array containing the extended identifier data.</param>
    /// <param name="propertyValue">An object representing the data to be assigned to the specified property.</param>
    /// <returns>A VideoDeviceControllerSetDevicePropertyStatus object describing the status of the operation.</returns>
    [MethodImpl]
    public extern VideoDeviceControllerSetDevicePropertyStatus SetDevicePropertyById(
      string propertyId,
      [Variant] object propertyValue);

    [MethodImpl]
    public extern VideoDeviceControllerGetDevicePropertyResult GetDevicePropertyByExtendedId(
      byte[] extendedPropertyId,
      IReference<uint> maxPropertyValueSize);

    /// <summary>Sets the value of the property with the specified ID from the capture device driver, using an extended ID with custom header information and providing the value as a byte array.</summary>
    /// <param name="extendedPropertyId">A byte array containing the extended identifier data.</param>
    /// <param name="propertyValue">A byte array containing the data to be assigned to the specified property.</param>
    /// <returns>A VideoDeviceControllerSetDevicePropertyStatus object describing the status of the operation.</returns>
    [MethodImpl]
    public extern VideoDeviceControllerSetDevicePropertyStatus SetDevicePropertyByExtendedId(
      byte[] extendedPropertyId,
      byte[] propertyValue);

    /// <summary>Gets the VideoTemporalDenoisingControl associated with the VideoDeviceController. This allows you to enable and disable temporal denoising, which uses image data from adjacent frames to reduce the appearance of noise in captured video, on devices that support it.</summary>
    /// <returns>The VideoTemporalDenoisingControl associated with the VideoDeviceController.</returns>
    public extern VideoTemporalDenoisingControl VideoTemporalDenoisingControl { [MethodImpl] get; }

    /// <summary>Gets the infrared torch control for selected video device.</summary>
    /// <returns>The infrared torch control.</returns>
    public extern InfraredTorchControl InfraredTorchControl { [MethodImpl] get; }

    public extern PanelBasedOptimizationControl PanelBasedOptimizationControl { [MethodImpl] get; }

    public extern DigitalWindowControl DigitalWindowControl { [MethodImpl] get; }

    public extern CameraOcclusionInfo CameraOcclusionInfo { [MethodImpl] get; }
  }
}
