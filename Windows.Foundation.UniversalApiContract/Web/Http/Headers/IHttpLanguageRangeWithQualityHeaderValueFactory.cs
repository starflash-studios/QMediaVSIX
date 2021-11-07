// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpLanguageRangeWithQualityHeaderValueFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(2075670896, 30735, 19587, 159, 228, 220, 48, 135, 246, 189, 85)]
  [ExclusiveTo(typeof (HttpLanguageRangeWithQualityHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpLanguageRangeWithQualityHeaderValueFactory
  {
    HttpLanguageRangeWithQualityHeaderValue CreateFromLanguageRange(
      string languageRange);

    HttpLanguageRangeWithQualityHeaderValue CreateFromLanguageRangeWithQuality(
      string languageRange,
      double quality);
  }
}
