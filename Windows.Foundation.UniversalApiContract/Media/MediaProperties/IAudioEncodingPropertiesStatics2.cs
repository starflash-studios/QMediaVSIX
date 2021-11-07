// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IAudioEncodingPropertiesStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (AudioEncodingProperties))]
  [Guid(1955148143, 30624, 17213, 142, 213, 64, 64, 40, 14, 134, 101)]
  internal interface IAudioEncodingPropertiesStatics2
  {
    AudioEncodingProperties CreateAlac(
      uint sampleRate,
      uint channelCount,
      uint bitsPerSample);

    AudioEncodingProperties CreateFlac(
      uint sampleRate,
      uint channelCount,
      uint bitsPerSample);
  }
}
