// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IAudioEncodingPropertiesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ExclusiveTo(typeof (AudioEncodingProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(212677420, 60393, 17703, 179, 109, 228, 42, 19, 207, 56, 219)]
  internal interface IAudioEncodingPropertiesStatics
  {
    AudioEncodingProperties CreateAac(
      uint sampleRate,
      uint channelCount,
      uint bitrate);

    AudioEncodingProperties CreateAacAdts(
      uint sampleRate,
      uint channelCount,
      uint bitrate);

    AudioEncodingProperties CreateMp3(
      uint sampleRate,
      uint channelCount,
      uint bitrate);

    AudioEncodingProperties CreatePcm(
      uint sampleRate,
      uint channelCount,
      uint bitsPerSample);

    AudioEncodingProperties CreateWma(
      uint sampleRate,
      uint channelCount,
      uint bitrate);
  }
}
