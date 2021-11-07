// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpMediaTypeWithQualityHeaderValueFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(1282220276, 37975, 17638, 163, 35, 209, 34, 185, 88, 120, 11)]
  [ExclusiveTo(typeof (HttpMediaTypeWithQualityHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpMediaTypeWithQualityHeaderValueFactory
  {
    HttpMediaTypeWithQualityHeaderValue CreateFromMediaType(
      string mediaType);

    HttpMediaTypeWithQualityHeaderValue CreateFromMediaTypeWithQuality(
      string mediaType,
      double quality);
  }
}
