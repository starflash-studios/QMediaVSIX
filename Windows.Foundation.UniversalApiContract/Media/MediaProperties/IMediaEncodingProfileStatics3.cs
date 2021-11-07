// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IMediaEncodingProfileStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [Guid(2430256554, 53110, 17044, 169, 237, 26, 20, 32, 245, 31, 107)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (MediaEncodingProfile))]
  internal interface IMediaEncodingProfileStatics3
  {
    MediaEncodingProfile CreateAlac(AudioEncodingQuality quality);

    MediaEncodingProfile CreateFlac(AudioEncodingQuality quality);

    MediaEncodingProfile CreateHevc(VideoEncodingQuality quality);
  }
}
