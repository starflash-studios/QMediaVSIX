// Decompiled with JetBrains decompiler
// Type: Windows.Media.Transcoding.IMediaTranscoder2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;
using Windows.Media.MediaProperties;
using Windows.Storage.Streams;

namespace Windows.Media.Transcoding
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaTranscoder))]
  [Guid(1079188852, 13792, 20228, 133, 116, 202, 139, 196, 229, 160, 130)]
  internal interface IMediaTranscoder2
  {
    IAsyncOperation<PrepareTranscodeResult> PrepareMediaStreamSourceTranscodeAsync(
      IMediaSource source,
      IRandomAccessStream destination,
      MediaEncodingProfile profile);

    MediaVideoProcessingAlgorithm VideoProcessingAlgorithm { set; get; }
  }
}
