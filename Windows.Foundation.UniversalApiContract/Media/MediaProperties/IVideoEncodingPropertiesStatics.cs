// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IVideoEncodingPropertiesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ExclusiveTo(typeof (VideoEncodingProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1021398340, 7621, 17371, 159, 56, 235, 235, 249, 1, 82, 203)]
  internal interface IVideoEncodingPropertiesStatics
  {
    VideoEncodingProperties CreateH264();

    VideoEncodingProperties CreateMpeg2();

    VideoEncodingProperties CreateUncompressed(
      string subtype,
      uint width,
      uint height);
  }
}
