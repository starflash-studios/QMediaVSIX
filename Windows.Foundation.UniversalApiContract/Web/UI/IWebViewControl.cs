// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.IWebViewControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI;
using Windows.Web.Http;

namespace Windows.Web.UI
{
  /// <summary>Provides a control that hosts HTML content in an app.</summary>
  [Guid(1066537750, 48240, 19418, 145, 54, 201, 67, 112, 137, 159, 171)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public interface IWebViewControl
  {
    /// <summary>Gets or sets the Uniform Resource Identifier (URI) source of the HTML content to display in the IWebViewControl.</summary>
    /// <returns>The Uniform Resource Identifier (URI) source of the HTML content to display in the IWebViewControl.</returns>
    Uri Source { get; set; }

    /// <summary>Gets the title of the page currently displayed in the IWebViewControl.</summary>
    /// <returns>The page title.</returns>
    string DocumentTitle { get; }

    /// <summary>Gets a value that indicates whether there is at least one page in the backward navigation history.</summary>
    /// <returns>**true** if the IWebViewControl can navigate backward; otherwise, **false**.</returns>
    bool CanGoBack { get; }

    /// <summary>Gets a value that indicates whether there is at least one page in the forward navigation history.</summary>
    /// <returns>**true** if the IWebViewControl can navigate forward; otherwise, **false**.</returns>
    bool CanGoForward { get; }

    /// <summary>Gets or sets the color to use as the IWebViewControl background when the HTML content does not specify a color.</summary>
    /// <returns>The background color.</returns>
    Color DefaultBackgroundColor { set; get; }

    /// <summary>Gets a value that indicates whether the IWebViewControl contains an element that supports full screen.</summary>
    /// <returns>A value that indicates whether the IWebViewControl contains an element that supports full screen.</returns>
    bool ContainsFullScreenElement { get; }

    /// <summary>Gets a WebViewControlSettings object that contains properties to enable or disable IWebViewControl features.</summary>
    /// <returns>A WebViewControlSettings object that contains properties to enable or disable IWebViewControl features.</returns>
    WebViewControlSettings Settings { get; }

    /// <summary>Gets a collection of permission requests that are waiting to be granted or denied.</summary>
    /// <returns>A collection of WebViewDeferredPermissionRequest objects that are waiting to be granted or denied.</returns>
    IVectorView<WebViewControlDeferredPermissionRequest> DeferredPermissionRequests { get; }

    /// <summary>Navigates the IWebViewControl to the next page in the navigation history.</summary>
    void GoForward();

    /// <summary>Navigates the IWebViewControl to the previous page in the navigation history.</summary>
    void GoBack();

    /// <summary>Reloads the current content in the IWebViewControl.</summary>
    void Refresh();

    /// <summary>Halts the current IWebViewControl navigation or download.</summary>
    void Stop();

    void Navigate(Uri source);

    /// <summary>Loads the specified HTML content as a new document.</summary>
    /// <param name="text">The HTML content to display in the IWebViewControl.</param>
    void NavigateToString(string text);

    void NavigateToLocalStreamUri(Uri source, IUriToStreamResolver streamResolver);

    /// <summary>Navigates the IWebViewControl to a URI with a POST request and HTTP headers.</summary>
    /// <param name="requestMessage">The details of the HTTP request.</param>
    void NavigateWithHttpRequestMessage(HttpRequestMessage requestMessage);

    [RemoteAsync]
    IAsyncOperation<string> InvokeScriptAsync(
      string scriptName,
      IIterable<string> arguments);

    /// <summary>Creates an image of the current IWebViewControl contents and writes it to the specified stream.</summary>
    /// <param name="stream">The stream to write the image to.</param>
    /// <returns>An asynchronous action to await the capture operation.</returns>
    [RemoteAsync]
    IAsyncAction CapturePreviewToStreamAsync(IRandomAccessStream stream);

    /// <summary>Asynchronously gets a DataPackage that contains the selected content within the IWebViewControl.</summary>
    /// <returns>When this method completes, it returns the selected content as a DataPackage.</returns>
    [RemoteAsync]
    IAsyncOperation<DataPackage> CaptureSelectedContentToDataPackageAsync();

    /// <summary>Creates a URI that you can pass to NavigateToLocalStreamUri</summary>
    /// <param name="contentIdentifier">A unique identifier for the content the URI is referencing. This defines the root of the URI.</param>
    /// <param name="relativePath">The path to the resource, relative to the root.</param>
    /// <returns>The URI created by combining and normalizing the contentIdentifier and relativePath.</returns>
    Uri BuildLocalStreamUri(string contentIdentifier, string relativePath);

    /// <summary>Returns the deferred permission request with the specified Id.</summary>
    /// <param name="id">The Id of the deferred permission request.</param>
    /// <param name="result">The deferred permission request with the specified Id.</param>
    void GetDeferredPermissionRequestById(
      uint id,
      out WebViewControlDeferredPermissionRequest result);

    /// <summary>Occurs before the IWebViewControl navigates to new content.</summary>
    event TypedEventHandler<IWebViewControl, WebViewControlNavigationStartingEventArgs> NavigationStarting;

    /// <summary>Occurs when the IWebViewControl has started loading new content.</summary>
    event TypedEventHandler<IWebViewControl, WebViewControlContentLoadingEventArgs> ContentLoading;

    /// <summary>Occurs when the IWebViewControl has finished parsing the current HTML content.</summary>
    event TypedEventHandler<IWebViewControl, WebViewControlDOMContentLoadedEventArgs> DOMContentLoaded;

    /// <summary>Occurs when the IWebViewControl has finished loading the current content or if navigation has failed.</summary>
    event TypedEventHandler<IWebViewControl, WebViewControlNavigationCompletedEventArgs> NavigationCompleted;

    /// <summary>Occurs before a frame in the IWebViewControl navigates to new content.</summary>
    event TypedEventHandler<IWebViewControl, WebViewControlNavigationStartingEventArgs> FrameNavigationStarting;

    /// <summary>Occurs when a frame in the IWebViewControl has finished parsing its current HTML content.</summary>
    event TypedEventHandler<IWebViewControl, WebViewControlContentLoadingEventArgs> FrameContentLoading;

    /// <summary>Occurs when a frame in the IWebViewControl has finished parsing its current HTML content.</summary>
    event TypedEventHandler<IWebViewControl, WebViewControlDOMContentLoadedEventArgs> FrameDOMContentLoaded;

    /// <summary>Occurs when a frame in the IWebViewControl has finished loading its content.</summary>
    event TypedEventHandler<IWebViewControl, WebViewControlNavigationCompletedEventArgs> FrameNavigationCompleted;

    /// <summary>Occurs when the content contained in the IWebViewControl passes a string to the application by using JavaScript.</summary>
    event TypedEventHandler<IWebViewControl, WebViewControlScriptNotifyEventArgs> ScriptNotify;

    /// <summary>Occurs periodically while the IWebViewControl executes JavaScript, letting you halt the script.</summary>
    event TypedEventHandler<IWebViewControl, WebViewControlLongRunningScriptDetectedEventArgs> LongRunningScriptDetected;

    /// <summary>Occurs when the IWebViewControl shows a warning page for content that was reported as unsafe by SmartScreen Filter.</summary>
    event TypedEventHandler<IWebViewControl, object> UnsafeContentWarningDisplaying;

    /// <summary>Occurs when the IWebViewControl attempts to download an unsupported file.</summary>
    event TypedEventHandler<IWebViewControl, WebViewControlUnviewableContentIdentifiedEventArgs> UnviewableContentIdentified;

    /// <summary>Occurs when an action in an IWebViewControl requires that permission be granted.</summary>
    event TypedEventHandler<IWebViewControl, WebViewControlPermissionRequestedEventArgs> PermissionRequested;

    /// <summary>Occurs when an attempt is made to navigate to a Uniform Resource Identifier (URI) using a scheme that IWebViewControl doesn't support.</summary>
    event TypedEventHandler<IWebViewControl, WebViewControlUnsupportedUriSchemeIdentifiedEventArgs> UnsupportedUriSchemeIdentified;

    /// <summary>Occurs when a user performs an action in the IWebViewControl that causes content to be opened in a new window.</summary>
    event TypedEventHandler<IWebViewControl, WebViewControlNewWindowRequestedEventArgs> NewWindowRequested;

    /// <summary>Occurs when the status of whether the IWebViewControl currently contains a full screen element or not changes.</summary>
    event TypedEventHandler<IWebViewControl, object> ContainsFullScreenElementChanged;

    /// <summary>Allows the interception of an HTTP request. This event is triggered every time an HTTP request is made.</summary>
    event TypedEventHandler<IWebViewControl, WebViewControlWebResourceRequestedEventArgs> WebResourceRequested;
  }
}
