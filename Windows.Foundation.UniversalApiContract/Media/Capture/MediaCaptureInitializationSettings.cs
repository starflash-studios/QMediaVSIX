// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaCaptureInitializationSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture.Frames;
using Windows.Media.Core;
using Windows.Security.Credentials;

namespace Windows.Media.Capture
{
  /// <summary>Contains initialization settings for the MediaCapture object which are passed to the MediaCapture.InitializeAsync method.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class MediaCaptureInitializationSettings : 
    IMediaCaptureInitializationSettings,
    IMediaCaptureInitializationSettings2,
    IMediaCaptureInitializationSettings3,
    IMediaCaptureInitializationSettings4,
    IMediaCaptureInitializationSettings5,
    IMediaCaptureInitializationSettings6,
    IMediaCaptureInitializationSettings7
  {
    /// <summary>Creates a new instance of the MediaCaptureInitializationSettings object.</summary>
    [MethodImpl]
    public extern MediaCaptureInitializationSettings();

    /// <summary>Gets the DeviceInformation.Id of the microphone.</summary>
    /// <returns>The DeviceInformation.Id of the microphone.</returns>
    public extern string AudioDeviceId { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the DeviceInformation.Id of the video camera.</summary>
    /// <returns>The DeviceInformation.Id of the video camera.</returns>
    public extern string VideoDeviceId { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the streaming mode.</summary>
    /// <returns>The streaming mode.</returns>
    public extern StreamingCaptureMode StreamingCaptureMode { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the stream that is used for photo capture.</summary>
    /// <returns>The stream that is used for photo capture.</returns>
    public extern PhotoCaptureSource PhotoCaptureSource { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or set the media category.</summary>
    /// <returns>The media category.</returns>
    public extern MediaCategory MediaCategory { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a value that specifies the audio processing mode.</summary>
    /// <returns>The audio processing mode.</returns>
    public extern AudioProcessing AudioProcessing { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the audio source for the capture operation.</summary>
    /// <returns>The audio source for the capture operation.</returns>
    public extern IMediaSource AudioSource { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the video source for the capture operation.</summary>
    /// <returns>The video source for the capture operation.</returns>
    public extern IMediaSource VideoSource { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the video profile which provides hints to the driver to allow it to optimize for different capture scenarios.</summary>
    /// <returns>The video profile.</returns>
    public extern MediaCaptureVideoProfile VideoProfile { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the media description for preview video.</summary>
    /// <returns>The media description for preview video.</returns>
    public extern MediaCaptureVideoProfileMediaDescription PreviewMediaDescription { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the media description for video recording.</summary>
    /// <returns>The media description for video capture.</returns>
    public extern MediaCaptureVideoProfileMediaDescription RecordMediaDescription { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the media description for photo capture.</summary>
    /// <returns>The media description for photo capture.</returns>
    public extern MediaCaptureVideoProfileMediaDescription PhotoMediaDescription { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the MediaFrameSourceGroup with which the MediaCapture should be initialized. This property defines a set of media frame sources that can be used simultaneously.</summary>
    /// <returns>The MediaFrameSourceGroup with which the MediaCapture should be initialized.</returns>
    public extern MediaFrameSourceGroup SourceGroup { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an object that specifies the sharing mode for the MediaCapture.</summary>
    /// <returns>An object that specifies the sharing mode for the MediaCapture.</returns>
    public extern MediaCaptureSharingMode SharingMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an object specifying the preferred memory location for storing frames acquired from a MediaFrameSource used by the MediaCapture.</summary>
    /// <returns>An object specifying preferred the memory location for storing frames acquired from a MediaFrameSource.</returns>
    public extern MediaCaptureMemoryPreference MemoryPreference { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value indicating whether the system should always play a shutter sound when a photo is captured.</summary>
    /// <returns>True if the system should always play a shutter sound; otherwise, false.</returns>
    public extern bool AlwaysPlaySystemShutterSound { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the PasswordCredential object representing the credentials used to access the remote capture device to be initialized.</summary>
    /// <returns>The credentials used to access the remote capture device.</returns>
    public extern PasswordCredential DeviceUriPasswordCredential { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the URI of the remote capture device to be initialized.</summary>
    /// <returns>The URI of the remote capture device to be initialized.</returns>
    public extern Uri DeviceUri { [MethodImpl] get; [MethodImpl] set; }
  }
}
