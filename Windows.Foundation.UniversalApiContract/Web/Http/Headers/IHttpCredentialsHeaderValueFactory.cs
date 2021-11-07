// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpCredentialsHeaderValueFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(4062027409, 19740, 16770, 191, 209, 52, 71, 10, 98, 249, 80)]
  [ExclusiveTo(typeof (HttpCredentialsHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpCredentialsHeaderValueFactory
  {
    HttpCredentialsHeaderValue CreateFromScheme(string scheme);

    HttpCredentialsHeaderValue CreateFromSchemeWithToken(
      string scheme,
      string token);
  }
}
