// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IMediaDeviceController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;

namespace Windows.Media.Devices
{
  /// <summary>Controls device settings on a video camera or microphone.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4143510990, 8346, 18683, 134, 252, 212, 69, 120, 243, 23, 230)]
  public interface IMediaDeviceController
  {
    /// <summary>Gets a list of the supported encoding properties for the device.</summary>
    /// <param name="mediaStreamType">The type of media stream for which to get the properties.</param>
    /// <returns>A list of the supported encoding properties.</returns>
    IVectorView<IMediaEncodingProperties> GetAvailableMediaStreamProperties(
      MediaStreamType mediaStreamType);

    /// <summary>Gets the encoding properties for the specified media stream type for the device.</summary>
    /// <param name="mediaStreamType">The type of media stream for which to get the properties.</param>
    /// <returns>The encoding properties.</returns>
    IMediaEncodingProperties GetMediaStreamProperties(
      MediaStreamType mediaStreamType);

    /// <summary>Sets the encoding properties asynchronously for the specified media stream type for the device.</summary>
    /// <param name="mediaStreamType">The type of media stream for which to set the properties.</param>
    /// <param name="mediaEncodingProperties">The encoding properties to set.</param>
    /// <returns>An IAsyncAction object that is used to control the asynchronous operation.</returns>
    IAsyncAction SetMediaStreamPropertiesAsync(
      MediaStreamType mediaStreamType,
      IMediaEncodingProperties mediaEncodingProperties);
  }
}
