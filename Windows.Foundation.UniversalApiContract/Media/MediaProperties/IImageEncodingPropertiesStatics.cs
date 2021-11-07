// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IImageEncodingPropertiesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [Guid(628910300, 35737, 17310, 170, 89, 145, 58, 54, 22, 18, 151)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ImageEncodingProperties))]
  internal interface IImageEncodingPropertiesStatics
  {
    ImageEncodingProperties CreateJpeg();

    ImageEncodingProperties CreatePng();

    ImageEncodingProperties CreateJpegXR();
  }
}
