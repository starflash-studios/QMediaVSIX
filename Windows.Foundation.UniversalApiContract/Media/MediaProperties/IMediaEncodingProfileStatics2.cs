// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IMediaEncodingProfileStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [Guid(3465406287, 27380, 17032, 143, 226, 121, 173, 241, 247, 154, 67)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaEncodingProfile))]
  internal interface IMediaEncodingProfileStatics2
  {
    MediaEncodingProfile CreateWav(AudioEncodingQuality quality);

    MediaEncodingProfile CreateAvi(VideoEncodingQuality quality);
  }
}
