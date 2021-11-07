// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebTokenRequestFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1827804188, 4080, 19559, 184, 79, 153, 221, 190, 74, 114, 201)]
  [ExclusiveTo(typeof (WebTokenRequest))]
  internal interface IWebTokenRequestFactory
  {
    WebTokenRequest Create(
      WebAccountProvider provider,
      string scope,
      string clientId);

    WebTokenRequest CreateWithPromptType(
      WebAccountProvider provider,
      string scope,
      string clientId,
      WebTokenRequestPromptType promptType);

    WebTokenRequest CreateWithProvider(WebAccountProvider provider);

    WebTokenRequest CreateWithScope(WebAccountProvider provider, string scope);
  }
}
