// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpLanguageRangeWithQualityHeaderValueStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(625074502, 62216, 18165, 182, 149, 66, 245, 64, 36, 236, 104)]
  [ExclusiveTo(typeof (HttpLanguageRangeWithQualityHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpLanguageRangeWithQualityHeaderValueStatics
  {
    HttpLanguageRangeWithQualityHeaderValue Parse(
      string input);

    bool TryParse(
      string input,
      out HttpLanguageRangeWithQualityHeaderValue languageRangeWithQualityHeaderValue);
  }
}
