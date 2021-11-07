// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpDateOrDeltaHeaderValueStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpDateOrDeltaHeaderValue))]
  [Guid(2082888104, 26226, 20112, 154, 154, 243, 151, 102, 247, 245, 118)]
  internal interface IHttpDateOrDeltaHeaderValueStatics
  {
    HttpDateOrDeltaHeaderValue Parse(string input);

    bool TryParse(
      string input,
      out HttpDateOrDeltaHeaderValue dateOrDeltaHeaderValue);
  }
}
