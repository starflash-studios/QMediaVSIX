// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebTokenResponseFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Core
{
  [Guid(2875979768, 21584, 20214, 151, 247, 5, 43, 4, 49, 192, 240)]
  [ExclusiveTo(typeof (WebTokenResponse))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebTokenResponseFactory
  {
    WebTokenResponse CreateWithToken(string token);

    WebTokenResponse CreateWithTokenAndAccount(string token, WebAccount webAccount);

    WebTokenResponse CreateWithTokenAccountAndError(
      string token,
      WebAccount webAccount,
      WebProviderError error);
  }
}
