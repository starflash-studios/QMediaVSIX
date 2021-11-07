// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaCaptureSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;

namespace Windows.Media.Capture
{
  /// <summary>Contains read-only configuration settings for the MediaCapture object.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.MTA)]
  public sealed class MediaCaptureSettings : 
    IMediaCaptureSettings,
    IMediaCaptureSettings2,
    IMediaCaptureSettings3
  {
    /// <summary>Gets the DeviceInformation.Id of the microphone.</summary>
    /// <returns>The DeviceInformation.Id of the microphone.</returns>
    public extern string AudioDeviceId { [MethodImpl] get; }

    /// <summary>Gets the DeviceInformation.Id of the video camera.</summary>
    /// <returns>The DeviceInformation.Id of the video camera.</returns>
    public extern string VideoDeviceId { [MethodImpl] get; }

    /// <summary>Gets the streaming mode.</summary>
    /// <returns>The streaming mode.</returns>
    public extern StreamingCaptureMode StreamingCaptureMode { [MethodImpl] get; }

    /// <summary>Gets the stream that is used for photo capture.</summary>
    /// <returns>The stream that is used for photo capture.</returns>
    public extern PhotoCaptureSource PhotoCaptureSource { [MethodImpl] get; }

    /// <summary>Gets a value that indicates which video streams are independent of each other.</summary>
    /// <returns>A value of VideoDeviceCharacteristic that indicates which video streams are independent pf each other.</returns>
    public extern VideoDeviceCharacteristic VideoDeviceCharacteristic { [MethodImpl] get; }

    /// <summary>Gets a value that indicates if the capture device supports recording video and taking a photo at the same time.</summary>
    /// <returns>**true** if the capture device supports concurrently recording video and capturing a photo; otherwise, **false**.</returns>
    public extern bool ConcurrentRecordAndPhotoSupported { [MethodImpl] get; }

    /// <summary>Gets a value that indicates if the capture device supports recording video and taking a photo sequence at the same time.</summary>
    /// <returns>**true** if the capture device supports concurrently recording video and capturing a photo sequence; otherwise, **false**.</returns>
    public extern bool ConcurrentRecordAndPhotoSequenceSupported { [MethodImpl] get; }

    /// <summary>Gets a value that indicates if the device’s region requires that a sound be played when a photo or video is captured.</summary>
    /// <returns>**true** if the device’s region requires that a sound be played when a photo or video is captured; otherwise, **false**. An app may play a sound during photo or video capture even if it is not required by the device’s region.</returns>
    public extern bool CameraSoundRequiredForRegion { [MethodImpl] get; }

    /// <summary>Gets the horizontal 35mm equivalent focal length of the camera lens on the capture device.</summary>
    /// <returns>The horizontal 35mm equivalent focal length of the camera lens.</returns>
    public extern IReference<uint> Horizontal35mmEquivalentFocalLength { [MethodImpl] get; }

    /// <summary>Gets the pitch offset of the camera in degrees.</summary>
    /// <returns>The pitch offset in degrees.</returns>
    public extern IReference<int> PitchOffsetDegrees { [MethodImpl] get; }

    /// <summary>Gets the vertical 35mm equivalent focal length of the camera lens on the capture device.</summary>
    /// <returns>The vertical 35mm equivalent focal length of the camera lens.</returns>
    public extern IReference<uint> Vertical35mmEquivalentFocalLength { [MethodImpl] get; }

    /// <summary>Gets the media category of the media.</summary>
    /// <returns>The media category</returns>
    public extern MediaCategory MediaCategory { [MethodImpl] get; }

    /// <summary>Gets the audio processing mode.</summary>
    /// <returns>The audio processing mode.</returns>
    public extern AudioProcessing AudioProcessing { [MethodImpl] get; }

    /// <summary>Gets an IDirect3DDevice representing the Direct3D device instance being used by the associated MediaCapture object.</summary>
    /// <returns>An IDirect3DDevice representing the Direct3D device instance being used by the associated MediaCapture object.</returns>
    public extern IDirect3DDevice Direct3D11Device { [MethodImpl] get; }
  }
}
