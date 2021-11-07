// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpTransferCodingHeaderValueStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1790478634, 6808, 19762, 169, 6, 116, 112, 169, 135, 92, 229)]
  [ExclusiveTo(typeof (HttpTransferCodingHeaderValue))]
  internal interface IHttpTransferCodingHeaderValueStatics
  {
    HttpTransferCodingHeaderValue Parse(string input);

    bool TryParse(
      string input,
      out HttpTransferCodingHeaderValue transferCodingHeaderValue);
  }
}
