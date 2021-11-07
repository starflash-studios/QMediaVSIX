// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentRangeHeaderValueStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(2158184138, 5964, 20398, 130, 28, 19, 76, 210, 148, 170, 56)]
  [ExclusiveTo(typeof (HttpContentRangeHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpContentRangeHeaderValueStatics
  {
    HttpContentRangeHeaderValue Parse(string input);

    bool TryParse(
      string input,
      out HttpContentRangeHeaderValue contentRangeHeaderValue);
  }
}
