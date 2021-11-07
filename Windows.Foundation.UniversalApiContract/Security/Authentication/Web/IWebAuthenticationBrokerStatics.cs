// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.IWebAuthenticationBrokerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web
{
  [ExclusiveTo(typeof (WebAuthenticationBroker))]
  [Guid(789880602, 58995, 16565, 188, 34, 32, 26, 104, 100, 163, 123)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebAuthenticationBrokerStatics
  {
    [RemoteAsync]
    [Overload("AuthenticateWithCallbackUriAsync")]
    IAsyncOperation<WebAuthenticationResult> AuthenticateAsync(
      WebAuthenticationOptions options,
      Uri requestUri,
      Uri callbackUri);

    [RemoteAsync]
    [Overload("AuthenticateWithoutCallbackUriAsync")]
    IAsyncOperation<WebAuthenticationResult> AuthenticateAsync(
      WebAuthenticationOptions options,
      Uri requestUri);

    Uri GetCurrentApplicationCallbackUri();
  }
}
