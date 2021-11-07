// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpCredentialsHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpCredentialsHeaderValue))]
  [Guid(3276587979, 21550, 16759, 166, 199, 182, 116, 206, 25, 63, 191)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpCredentialsHeaderValue
  {
    IVector<HttpNameValueHeaderValue> Parameters { get; }

    string Scheme { get; }

    string Token { get; }
  }
}
