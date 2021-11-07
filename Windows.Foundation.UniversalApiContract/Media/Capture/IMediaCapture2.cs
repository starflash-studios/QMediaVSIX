// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCapture2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media.Capture
{
  [Guid(2630255200, 32161, 16451, 182, 82, 33, 184, 135, 141, 175, 249)]
  [ExclusiveTo(typeof (MediaCapture))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaCapture2
  {
    IAsyncOperation<LowLagMediaRecording> PrepareLowLagRecordToStorageFileAsync(
      MediaEncodingProfile encodingProfile,
      IStorageFile file);

    IAsyncOperation<LowLagMediaRecording> PrepareLowLagRecordToStreamAsync(
      MediaEncodingProfile encodingProfile,
      IRandomAccessStream stream);

    [Overload("PrepareLowLagRecordToCustomSinkAsync")]
    IAsyncOperation<LowLagMediaRecording> PrepareLowLagRecordToCustomSinkAsync(
      MediaEncodingProfile encodingProfile,
      IMediaExtension customMediaSink);

    [Overload("PrepareLowLagRecordToCustomSinkIdAsync")]
    IAsyncOperation<LowLagMediaRecording> PrepareLowLagRecordToCustomSinkAsync(
      MediaEncodingProfile encodingProfile,
      string customSinkActivationId,
      IPropertySet customSinkSettings);

    IAsyncOperation<LowLagPhotoCapture> PrepareLowLagPhotoCaptureAsync(
      ImageEncodingProperties type);

    [RemoteAsync]
    IAsyncOperation<LowLagPhotoSequenceCapture> PrepareLowLagPhotoSequenceCaptureAsync(
      ImageEncodingProperties type);

    IAsyncAction SetEncodingPropertiesAsync(
      MediaStreamType mediaStreamType,
      IMediaEncodingProperties mediaEncodingProperties,
      MediaPropertySet encoderProperties);
  }
}
