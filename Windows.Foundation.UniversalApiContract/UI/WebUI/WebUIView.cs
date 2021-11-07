// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUIView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.Web;
using Windows.Web.Http;
using Windows.Web.UI;

namespace Windows.UI.WebUI
{
  /// <summary>Represents a view (window) of the app to the application background script.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Static(typeof (IWebUIViewStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class WebUIView : IWebUIView, IWebViewControl, IWebViewControl2
  {
    /// <summary>
    /// </summary>
    /// <returns>
    /// </returns>
    public extern int ApplicationViewId { [MethodImpl] get; }

    /// <summary>Occurs when the view has been closed.</summary>
    public extern event TypedEventHandler<WebUIView, object> Closed;

    /// <summary>Occurs when the view is activated.</summary>
    public extern event TypedEventHandler<WebUIView, IActivatedEventArgs> Activated;

    /// <summary>
    /// </summary>
    /// <returns>
    /// </returns>
    public extern bool IgnoreApplicationContentUriRulesNavigationRestrictions { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the URI source of the HTML content to display in the control.</summary>
    /// <returns>The URI source of the HTML content to display in the control.</returns>
    public extern Uri Source { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the title of the page currently displayed in the view.</summary>
    /// <returns>The page title.</returns>
    public extern string DocumentTitle { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether there is at least one page in the backward navigation history.</summary>
    /// <returns>**true** if the view can navigate backward; otherwise, **false**.</returns>
    public extern bool CanGoBack { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether there is at least one page in the forward navigation history.</summary>
    /// <returns>**true** if the view can navigate forward; otherwise, **false**.</returns>
    public extern bool CanGoForward { [MethodImpl] get; }

    /// <summary>Gets or sets the color to use as the view background when the HTML content does not specify a color.</summary>
    /// <returns>The default background color to use when the HTML content does not specify a color.</returns>
    public extern Color DefaultBackgroundColor { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the view contains an element that supports full screen.</summary>
    /// <returns>**true** if the view contains an element that supports full screen display; otherwise, **false**.</returns>
    public extern bool ContainsFullScreenElement { [MethodImpl] get; }

    /// <summary>Gets a WebViewControlSettings object that contains properties to enable or disable IWebViewControl features.</summary>
    /// <returns>A WebViewControlSettings object that contains properties to enable or disable IWebViewControl features.</returns>
    public extern WebViewControlSettings Settings { [MethodImpl] get; }

    /// <summary>Gets a collection of permission requests that are waiting to be granted or denied.</summary>
    /// <returns>A collection of WebViewDeferredPermissionRequest objects that are waiting to be granted or denied.</returns>
    public extern IVectorView<WebViewControlDeferredPermissionRequest> DeferredPermissionRequests { [MethodImpl] get; }

    /// <summary>Navigates to the next page in the navigation history.</summary>
    [MethodImpl]
    public extern void GoForward();

    /// <summary>Navigates to the previous page in the navigation history.</summary>
    [MethodImpl]
    public extern void GoBack();

    /// <summary>Reloads the current content in the control.</summary>
    [MethodImpl]
    public extern void Refresh();

    /// <summary>Halts the current control navigation or download.</summary>
    [MethodImpl]
    public extern void Stop();

    [MethodImpl]
    public extern void Navigate(Uri source);

    /// <summary>Loads the specified HTML content as a new document.</summary>
    /// <param name="text">The HTML content to display in the control.</param>
    [MethodImpl]
    public extern void NavigateToString(string text);

    [MethodImpl]
    public extern void NavigateToLocalStreamUri(Uri source, IUriToStreamResolver streamResolver);

    /// <summary>Navigates the control to a URI with a POST request and HTTP headers.</summary>
    /// <param name="requestMessage">The request.</param>
    [MethodImpl]
    public extern void NavigateWithHttpRequestMessage(HttpRequestMessage requestMessage);

    [MethodImpl]
    public extern IAsyncOperation<string> InvokeScriptAsync(
      string scriptName,
      IIterable<string> arguments);

    /// <summary>Creates an image of the current view contents and writes it to the specified stream.</summary>
    /// <param name="stream">The stream to write the image to.</param>
    /// <returns>An asynchronous action to await the capture operation.</returns>
    [MethodImpl]
    public extern IAsyncAction CapturePreviewToStreamAsync(IRandomAccessStream stream);

    /// <summary>Asynchronously gets a DataPackage that contains the selected content within the control.</summary>
    /// <returns>When this method completes, it returns the selected content as a DataPackage.</returns>
    [MethodImpl]
    public extern IAsyncOperation<DataPackage> CaptureSelectedContentToDataPackageAsync();

    /// <summary>Creates a URI that you can pass to NavigateToLocalStreamUri</summary>
    /// <param name="contentIdentifier">A unique identifier for the content the URI is referencing. This defines the root of the URI.</param>
    /// <param name="relativePath">The path to the resource, relative to the root.</param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern Uri BuildLocalStreamUri(string contentIdentifier, string relativePath);

    /// <summary>Returns the deferred permission request with the specified Id.</summary>
    /// <param name="id">The Id of the deferred permission request.</param>
    /// <param name="result">The deferred permission request with the specified Id.</param>
    [MethodImpl]
    public extern void GetDeferredPermissionRequestById(
      uint id,
      out WebViewControlDeferredPermissionRequest result);

    /// <summary>Occurs before the control navigates to new content.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlNavigationStartingEventArgs> NavigationStarting;

    /// <summary>Occurs when the view starts loading new content.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlContentLoadingEventArgs> ContentLoading;

    /// <summary>An event that is triggered when the view has finished parsing the current HTML content.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlDOMContentLoadedEventArgs> DOMContentLoaded;

    /// <summary>Occurs when the control has finished loading the current content or if the navigation has failed.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlNavigationCompletedEventArgs> NavigationCompleted;

    /// <summary>Occurs just before the view navigates to new content.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlNavigationStartingEventArgs> FrameNavigationStarting;

    /// <summary>Occurs when a frame in the view begins loading new content.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlContentLoadingEventArgs> FrameContentLoading;

    /// <summary>Occurs when a frame in the view has finished parsing its current HTML content.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlDOMContentLoadedEventArgs> FrameDOMContentLoaded;

    /// <summary>Occurs when the control has finished loading the current content or if the navigation has failed.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlNavigationCompletedEventArgs> FrameNavigationCompleted;

    /// <summary>Occurs when the content contained in the control passes a string to the app using JavaScript.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlScriptNotifyEventArgs> ScriptNotify;

    /// <summary>An event that is triggered periodically while the control executes JavaScript, letting you halt the script.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlLongRunningScriptDetectedEventArgs> LongRunningScriptDetected;

    /// <summary>Occurs when the control shows a warning page for content that was reported as unsafe by SmartScreen Filter.</summary>
    public extern event TypedEventHandler<IWebViewControl, object> UnsafeContentWarningDisplaying;

    /// <summary>An event that is triggered when the control attempts to download an unsupported file.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlUnviewableContentIdentifiedEventArgs> UnviewableContentIdentified;

    /// <summary>Occurs when an action in the control requires that permission to be granted.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlPermissionRequestedEventArgs> PermissionRequested;

    /// <summary>Occurs when an attempt is made to navigate to a URI using a scheme that the control doesn't support.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlUnsupportedUriSchemeIdentifiedEventArgs> UnsupportedUriSchemeIdentified;

    /// <summary>Occurs when a user performs an action in the control that causes content to be opened in a new window.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlNewWindowRequestedEventArgs> NewWindowRequested;

    /// <summary>Occurs when the status of whether the view currently contains a full screen element or not changes.</summary>
    public extern event TypedEventHandler<IWebViewControl, object> ContainsFullScreenElementChanged;

    /// <summary>An event that is fired when an HTTP request is made.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlWebResourceRequestedEventArgs> WebResourceRequested;

    /// <summary>
    /// </summary>
    /// <param name="script">
    /// </param>
    [MethodImpl]
    public extern void AddInitializeScript(string script);

    /// <summary>
    /// </summary>
    /// <returns>
    /// </returns>
    [Overload("CreateAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebUIView> CreateAsync();

    [Overload("CreateWithUriAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebUIView> CreateAsync(Uri uri);
  }
}
