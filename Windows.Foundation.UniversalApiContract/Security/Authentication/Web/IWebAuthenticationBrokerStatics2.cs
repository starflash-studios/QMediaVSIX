// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.IWebAuthenticationBrokerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web
{
  [ExclusiveTo(typeof (WebAuthenticationBroker))]
  [Guid(1942879134, 5351, 16858, 169, 113, 170, 244, 65, 11, 98, 30)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebAuthenticationBrokerStatics2
  {
    [Overload("AuthenticateAndContinue")]
    void AuthenticateAndContinue(Uri requestUri);

    [Overload("AuthenticateWithCallbackUriAndContinue")]
    void AuthenticateAndContinue(Uri requestUri, Uri callbackUri);

    [Overload("AuthenticateWithCallbackUriContinuationDataAndOptionsAndContinue")]
    void AuthenticateAndContinue(
      Uri requestUri,
      Uri callbackUri,
      ValueSet continuationData,
      WebAuthenticationOptions options);

    [Overload("AuthenticateSilentlyAsync")]
    [RemoteAsync]
    IAsyncOperation<WebAuthenticationResult> AuthenticateSilentlyAsync(
      Uri requestUri);

    [RemoteAsync]
    [Overload("AuthenticateSilentlyWithOptionsAsync")]
    IAsyncOperation<WebAuthenticationResult> AuthenticateSilentlyAsync(
      Uri requestUri,
      WebAuthenticationOptions options);
  }
}
