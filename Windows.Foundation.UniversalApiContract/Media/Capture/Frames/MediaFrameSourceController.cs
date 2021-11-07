// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.MediaFrameSourceController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;

namespace Windows.Media.Capture.Frames
{
  /// <summary>Allows you to get and set properties of a MediaFrameSource and to get a VideoDeviceController, which provides camera controls such as exposure, focus, and zoom.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class MediaFrameSourceController : 
    IMediaFrameSourceController,
    IMediaFrameSourceController2,
    IMediaFrameSourceController3
  {
    /// <summary>Asynchronously gets an object that contains the value of a MediaFrameSource property, if the property value is successfully retrieved, and describes the result status of the get operation.</summary>
    /// <param name="propertyId">The identifier of the media frame source property to be retrieved.</param>
    /// <returns>An asynchronous operation that returns a MediaFrameSourceGetPropertyResult upon completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaFrameSourceGetPropertyResult> GetPropertyAsync(
      string propertyId);

    /// <summary>Asynchronously sets the value of a MediaFrameSource property and returns a MediaFrameSourceSetPropertyStatus object describing the result status of the set operation.</summary>
    /// <param name="propertyId">The identifier of the media frame source property to be set.</param>
    /// <param name="propertyValue">The value of the media frame source property to be set.</param>
    /// <returns>An asynchronous operation that returns a MediaFrameSourceSetPropertyStatus upon completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaFrameSourceSetPropertyStatus> SetPropertyAsync(
      string propertyId,
      [Variant] object propertyValue);

    /// <summary>Gets a VideoDeviceController for a MediaFrameSource, which provides camera controls such as exposure, focus, and zoom.</summary>
    /// <returns>A VideoDeviceController for the media frame source.</returns>
    public extern VideoDeviceController VideoDeviceController { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaFrameSourceGetPropertyResult> GetPropertyByExtendedIdAsync(
      byte[] extendedPropertyId,
      IReference<uint> maxPropertyValueSize);

    /// <summary>Asynchronously sets the value of the property with the specified ID on a MediaFrameSource, using an extended ID with custom header information.</summary>
    /// <param name="extendedPropertyId">A byte array containing the extended identifier data.</param>
    /// <param name="propertyValue">A byte array containing the value to be set for the property.</param>
    /// <returns>An asynchronous operation that, upon successful completion, returns a MediaFrameSourceSetPropertyStatus value indicating the status of the operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaFrameSourceSetPropertyStatus> SetPropertyByExtendedIdAsync(
      byte[] extendedPropertyId,
      byte[] propertyValue);

    /// <summary>Gets an AudioDeviceController for a MediaFrameSource, which provides controls such as setting the volume level or muting the audio device.</summary>
    /// <returns>An AudioDeviceController for the media frame source.</returns>
    public extern AudioDeviceController AudioDeviceController { [MethodImpl] get; }
  }
}
