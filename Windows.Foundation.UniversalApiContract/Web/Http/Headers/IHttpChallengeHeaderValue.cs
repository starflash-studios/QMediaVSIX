// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpChallengeHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(959668655, 3965, 18464, 159, 221, 162, 185, 86, 238, 174, 171)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpChallengeHeaderValue))]
  internal interface IHttpChallengeHeaderValue
  {
    IVector<HttpNameValueHeaderValue> Parameters { get; }

    string Scheme { get; }

    string Token { get; }
  }
}
