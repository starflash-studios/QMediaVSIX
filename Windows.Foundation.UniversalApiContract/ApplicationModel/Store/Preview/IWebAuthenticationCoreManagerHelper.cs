// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.IWebAuthenticationCoreManagerHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;
using Windows.Security.Credentials;
using Windows.UI.Xaml;

namespace Windows.ApplicationModel.Store.Preview
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(111478053, 59157, 16675, 146, 118, 157, 111, 134, 91, 165, 95)]
  [ExclusiveTo(typeof (WebAuthenticationCoreManagerHelper))]
  internal interface IWebAuthenticationCoreManagerHelper
  {
    [Overload("RequestTokenWithUIElementHostingAsync")]
    [RemoteAsync]
    IAsyncOperation<WebTokenRequestResult> RequestTokenWithUIElementHostingAsync(
      WebTokenRequest request,
      UIElement uiElement);

    [Overload("RequestTokenWithUIElementHostingAndWebAccountAsync")]
    [RemoteAsync]
    IAsyncOperation<WebTokenRequestResult> RequestTokenWithUIElementHostingAsync(
      WebTokenRequest request,
      WebAccount webAccount,
      UIElement uiElement);
  }
}
