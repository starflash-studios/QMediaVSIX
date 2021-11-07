// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpMediaTypeWithQualityHeaderValueStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(1527188697, 46432, 20424, 152, 53, 126, 108, 10, 101, 123, 36)]
  [ExclusiveTo(typeof (HttpMediaTypeWithQualityHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpMediaTypeWithQualityHeaderValueStatics
  {
    HttpMediaTypeWithQualityHeaderValue Parse(string input);

    bool TryParse(
      string input,
      out HttpMediaTypeWithQualityHeaderValue mediaTypeWithQualityHeaderValue);
  }
}
