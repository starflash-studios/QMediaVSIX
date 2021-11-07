// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentCodingHeaderValueStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(2497208366, 63935, 17143, 170, 70, 237, 39, 42, 65, 226, 18)]
  [ExclusiveTo(typeof (HttpContentCodingHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpContentCodingHeaderValueStatics
  {
    HttpContentCodingHeaderValue Parse(string input);

    bool TryParse(
      string input,
      out HttpContentCodingHeaderValue contentCodingHeaderValue);
  }
}
