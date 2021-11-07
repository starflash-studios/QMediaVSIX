// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpExpectationHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(1290110413, 15001, 17327, 162, 230, 236, 35, 47, 234, 150, 88)]
  [ExclusiveTo(typeof (HttpExpectationHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpExpectationHeaderValue
  {
    string Name { get; }

    string Value { get; set; }

    IVector<HttpNameValueHeaderValue> Parameters { get; }
  }
}
