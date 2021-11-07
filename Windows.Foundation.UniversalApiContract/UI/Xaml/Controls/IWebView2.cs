// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebView2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.Web;
using Windows.Web.Http;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3565254046, 16127, 17506, 130, 61, 253, 82, 249, 186, 76, 200)]
  [ExclusiveTo(typeof (WebView))]
  internal interface IWebView2
  {
    bool CanGoBack { get; }

    bool CanGoForward { get; }

    string DocumentTitle { get; }

    event TypedEventHandler<WebView, WebViewNavigationStartingEventArgs> NavigationStarting;

    event TypedEventHandler<WebView, WebViewContentLoadingEventArgs> ContentLoading;

    event TypedEventHandler<WebView, WebViewDOMContentLoadedEventArgs> DOMContentLoaded;

    void GoForward();

    void GoBack();

    void Refresh();

    void Stop();

    [RemoteAsync]
    IAsyncAction CapturePreviewToStreamAsync(IRandomAccessStream stream);

    [RemoteAsync]
    IAsyncOperation<string> InvokeScriptAsync(
      string scriptName,
      IIterable<string> arguments);

    [RemoteAsync]
    IAsyncOperation<DataPackage> CaptureSelectedContentToDataPackageAsync();

    void NavigateToLocalStreamUri(Uri source, IUriToStreamResolver streamResolver);

    Uri BuildLocalStreamUri(string contentIdentifier, string relativePath);

    Color DefaultBackgroundColor { get; set; }

    event TypedEventHandler<WebView, WebViewNavigationCompletedEventArgs> NavigationCompleted;

    event TypedEventHandler<WebView, WebViewNavigationStartingEventArgs> FrameNavigationStarting;

    event TypedEventHandler<WebView, WebViewContentLoadingEventArgs> FrameContentLoading;

    event TypedEventHandler<WebView, WebViewDOMContentLoadedEventArgs> FrameDOMContentLoaded;

    event TypedEventHandler<WebView, WebViewNavigationCompletedEventArgs> FrameNavigationCompleted;

    event TypedEventHandler<WebView, WebViewLongRunningScriptDetectedEventArgs> LongRunningScriptDetected;

    event TypedEventHandler<WebView, object> UnsafeContentWarningDisplaying;

    event TypedEventHandler<WebView, WebViewUnviewableContentIdentifiedEventArgs> UnviewableContentIdentified;

    void NavigateWithHttpRequestMessage(HttpRequestMessage requestMessage);

    bool Focus(FocusState value);
  }
}
