// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.AudioDeviceController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;

namespace Windows.Media.Devices
{
  /// <summary>Controls device settings on the microphone.</summary>
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  public sealed class AudioDeviceController : IAudioDeviceController, IMediaDeviceController
  {
    /// <summary>Mutes or unmutes the microphone.</summary>
    /// <returns>True if the microphone is muted; false otherwise.</returns>
    public extern bool Muted { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the volume of the microphone.</summary>
    /// <returns>The volume of the microphone. The value ranges from 0.0 (silent) to 100.0 (full volume).</returns>
    public extern float VolumePercent { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets a list of the supported encoding properties for the device.</summary>
    /// <param name="mediaStreamType">The type of media stream for which to get the properties.</param>
    /// <returns>A list of the supported encoding properties.</returns>
    [MethodImpl]
    public extern IVectorView<IMediaEncodingProperties> GetAvailableMediaStreamProperties(
      MediaStreamType mediaStreamType);

    /// <summary>Gets the encoding properties for the specified media stream type for the device.</summary>
    /// <param name="mediaStreamType">The type of media stream for which to get the properties.</param>
    /// <returns>The encoding properties.</returns>
    [MethodImpl]
    public extern IMediaEncodingProperties GetMediaStreamProperties(
      MediaStreamType mediaStreamType);

    /// <summary>Sets the encoding properties asynchronously for the specified media stream type for the device.</summary>
    /// <param name="mediaStreamType">The type of media stream for which to set the properties.</param>
    /// <param name="mediaEncodingProperties">The encoding properties to set.</param>
    /// <returns>An IAsyncAction object that is used to control the asynchronous operation.</returns>
    [MethodImpl]
    public extern IAsyncAction SetMediaStreamPropertiesAsync(
      MediaStreamType mediaStreamType,
      IMediaEncodingProperties mediaEncodingProperties);
  }
}
