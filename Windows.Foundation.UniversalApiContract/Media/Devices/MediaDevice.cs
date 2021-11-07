// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.MediaDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Provides methods used to select devices for capturing and rendering audio, and for capturing video.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [Static(typeof (IMediaDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  public static class MediaDevice
  {
    /// <summary>Returns the identifier string of a device for capturing audio.</summary>
    /// <returns>The identifier string of the audio capture device.</returns>
    [MethodImpl]
    public static extern string GetAudioCaptureSelector();

    /// <summary>Returns the identifier string of a device for rendering audio.</summary>
    /// <returns>The identifier string of the audio rendering device.</returns>
    [MethodImpl]
    public static extern string GetAudioRenderSelector();

    /// <summary>Returns the identifier string of a device for capturing video.</summary>
    /// <returns>The identifier string of the video capture device.</returns>
    [MethodImpl]
    public static extern string GetVideoCaptureSelector();

    /// <summary>Returns the identifier string of the default device for capturing audio in the specified role.</summary>
    /// <param name="role">The specified audio device role (console, media, or communications).</param>
    /// <returns>The identifier string of the default device.</returns>
    [MethodImpl]
    public static extern string GetDefaultAudioCaptureId(AudioDeviceRole role);

    /// <summary>Returns the identifier string of the default device for rendering audio in the specified role.</summary>
    /// <param name="role">The specified audio device role (console, media, or communications).</param>
    /// <returns>The identifier string of the default device.</returns>
    [MethodImpl]
    public static extern string GetDefaultAudioRenderId(AudioDeviceRole role);

    /// <summary>Raised when the default audio capture device is changed.</summary>
    public static extern event TypedEventHandler<object, DefaultAudioCaptureDeviceChangedEventArgs> DefaultAudioCaptureDeviceChanged;

    /// <summary>Raised when the default audio render device is changed.</summary>
    public static extern event TypedEventHandler<object, DefaultAudioRenderDeviceChangedEventArgs> DefaultAudioRenderDeviceChanged;
  }
}
