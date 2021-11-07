// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpExpectationHeaderValueFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(1319269835, 54590, 18536, 136, 86, 30, 33, 165, 3, 13, 192)]
  [ExclusiveTo(typeof (HttpExpectationHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpExpectationHeaderValueFactory
  {
    HttpExpectationHeaderValue CreateFromName(string name);

    HttpExpectationHeaderValue CreateFromNameWithValue(
      string name,
      string value);
  }
}
