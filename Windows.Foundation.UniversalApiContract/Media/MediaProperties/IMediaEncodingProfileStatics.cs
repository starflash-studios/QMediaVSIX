// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IMediaEncodingProfileStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media.MediaProperties
{
  [Guid(427767084, 11998, 19013, 168, 150, 129, 122, 72, 84, 248, 254)]
  [ExclusiveTo(typeof (MediaEncodingProfile))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaEncodingProfileStatics
  {
    MediaEncodingProfile CreateM4a(AudioEncodingQuality quality);

    MediaEncodingProfile CreateMp3(AudioEncodingQuality quality);

    MediaEncodingProfile CreateWma(AudioEncodingQuality quality);

    MediaEncodingProfile CreateMp4(VideoEncodingQuality quality);

    MediaEncodingProfile CreateWmv(VideoEncodingQuality quality);

    [RemoteAsync]
    IAsyncOperation<MediaEncodingProfile> CreateFromFileAsync(
      IStorageFile file);

    [RemoteAsync]
    IAsyncOperation<MediaEncodingProfile> CreateFromStreamAsync(
      IRandomAccessStream stream);
  }
}
