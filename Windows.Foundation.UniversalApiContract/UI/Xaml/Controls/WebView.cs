// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.WebView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Navigation;
using Windows.Web;
using Windows.Web.Http;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides a control that hosts HTML content in an app.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IWebViewStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWebViewStatics4), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IWebViewStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWebViewStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Activatable(typeof (IWebViewFactory4), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWebViewStatics5), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class WebView : 
    FrameworkElement,
    IWebView,
    IWebView2,
    IWebView3,
    IWebView4,
    IWebView5,
    IWebView6,
    IWebView7
  {
    /// <summary>Initializes a new instance of the WebView class with the specified execution mode.</summary>
    /// <param name="executionMode">A value of the enumeration that indicates whether the WebView hosts content on the UI thread or a non-UI thread.</param>
    [MethodImpl]
    public extern WebView(WebViewExecutionMode executionMode);

    /// <summary>Initializes a new instance of the WebView class.</summary>
    [MethodImpl]
    public extern WebView();

    /// <summary>Gets or sets the Uniform Resource Identifier (URI) source of the HTML content to display in the WebView control.</summary>
    /// <returns>The Uniform Resource Identifier (URI) source of the HTML content to display in the WebView control.</returns>
    public extern Uri Source { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a safe list of URIs that are permitted to fire ScriptNotify events to this WebView.</summary>
    /// <returns>The safe list of URIs that are permitted to fire ScriptNotify events.</returns>
    public extern IVector<Uri> AllowedScriptNotifyUris { [Deprecated("AllowedScriptNotifyUris is unavailable for releases beginning with Windows 8.1. Instead, list URIs under ApplicationContentUriRules in the package manifest. For more info, see the AllowedScriptNotifyUris documentation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("AllowedScriptNotifyUris is unavailable for releases beginning with Windows 8.1. Instead, list URIs under ApplicationContentUriRules in the package manifest. For more info, see the AllowedScriptNotifyUris documentation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Gets a clipboard DataPackage as passed to the WebView.</summary>
    /// <returns>A clipboard data package.</returns>
    public extern DataPackage DataTransferPackage { [Deprecated("Use CaptureSelectedContentToDataPackageAsync instead of DataTransferPackage. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Occurs when top-level navigation completes and the content loads into the WebView control or when an error occurs during loading.</summary>
    public extern event LoadCompletedEventHandler LoadCompleted;

    /// <summary>Occurs when the content contained in the WebView control passes a string to the application by using JavaScript.</summary>
    public extern event NotifyEventHandler ScriptNotify;

    /// <summary>Occurs when the WebView cannot complete the navigation attempt.</summary>
    public extern event WebViewNavigationFailedEventHandler NavigationFailed;

    /// <summary>Executes the specified script function from the currently loaded HTML, with specific arguments.</summary>
    /// <deprecated type="deprecate">Use InvokeScriptAsync instead of InvokeScript. For more info, see MSDN.</deprecated>
    /// <param name="scriptName">The name of the script function to invoke.</param>
    /// <param name="arguments">A string array that packages arguments to the script function.</param>
    /// <returns>The result of the script invocation.</returns>
    [Deprecated("Use InvokeScriptAsync instead of InvokeScript. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern string InvokeScript(string scriptName, string[] arguments);

    [MethodImpl]
    public extern void Navigate(Uri source);

    /// <summary>Loads the specified HTML content as a new document.</summary>
    /// <param name="text">The HTML content to display in the WebView control.</param>
    [MethodImpl]
    public extern void NavigateToString(string text);

    /// <summary>Gets a value that indicates whether there is at least one page in the backward navigation history.</summary>
    /// <returns>**true** if the WebView can navigate backward; otherwise, **false**.</returns>
    public extern bool CanGoBack { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether there is at least one page in the forward navigation history.</summary>
    /// <returns>**true** if the WebView can navigate forward; otherwise, **false**.</returns>
    public extern bool CanGoForward { [MethodImpl] get; }

    /// <summary>Gets the title of the page currently displayed in the WebView.</summary>
    /// <returns>The page title.</returns>
    public extern string DocumentTitle { [MethodImpl] get; }

    /// <summary>Occurs before the WebView navigates to new content.</summary>
    public extern event TypedEventHandler<WebView, WebViewNavigationStartingEventArgs> NavigationStarting;

    /// <summary>Occurs when the WebView has started loading new content.</summary>
    public extern event TypedEventHandler<WebView, WebViewContentLoadingEventArgs> ContentLoading;

    /// <summary>Occurs when the WebView has finished parsing the current HTML content.</summary>
    public extern event TypedEventHandler<WebView, WebViewDOMContentLoadedEventArgs> DOMContentLoaded;

    /// <summary>Navigates the WebView to the next page in the navigation history.</summary>
    [MethodImpl]
    public extern void GoForward();

    /// <summary>Navigates the WebView to the previous page in the navigation history.</summary>
    [MethodImpl]
    public extern void GoBack();

    /// <summary>Reloads the current content in the WebView.</summary>
    [MethodImpl]
    public extern void Refresh();

    /// <summary>Halts the current WebView navigation or download.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>Creates an image of the current WebView contents and writes it to the specified stream.</summary>
    /// <param name="stream">The stream to write the image to.</param>
    /// <returns>An asynchronous action to await the capture operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CapturePreviewToStreamAsync(IRandomAccessStream stream);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> InvokeScriptAsync(
      string scriptName,
      IIterable<string> arguments);

    /// <summary>Asynchronously gets a DataPackage that contains the selected content within the WebView.</summary>
    /// <returns>When this method completes, it returns the selected content as a DataPackage.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DataPackage> CaptureSelectedContentToDataPackageAsync();

    [MethodImpl]
    public extern void NavigateToLocalStreamUri(Uri source, IUriToStreamResolver streamResolver);

    /// <summary>Creates a URI that you can pass to NavigateToLocalStreamUri.</summary>
    /// <param name="contentIdentifier">A unique identifier for the content the URI is referencing. This defines the root of the URI.</param>
    /// <param name="relativePath">The path to the resource, relative to the root.</param>
    /// <returns>The URI created by combining and normalizing the *contentIdentifier* and *relativePath*.</returns>
    [MethodImpl]
    public extern Uri BuildLocalStreamUri(string contentIdentifier, string relativePath);

    /// <summary>Gets or sets the color to use as the WebView background when the HTML content does not specify a color.</summary>
    /// <returns>The background color.</returns>
    public extern Color DefaultBackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the WebView has finished loading the current content or if navigation has failed.</summary>
    public extern event TypedEventHandler<WebView, WebViewNavigationCompletedEventArgs> NavigationCompleted;

    /// <summary>Occurs before a frame in the WebView navigates to new content.</summary>
    public extern event TypedEventHandler<WebView, WebViewNavigationStartingEventArgs> FrameNavigationStarting;

    /// <summary>Occurs when a frame in the WebView has started loading new content.</summary>
    public extern event TypedEventHandler<WebView, WebViewContentLoadingEventArgs> FrameContentLoading;

    /// <summary>Occurs when a frame in the WebView has finished parsing its current HTML content.</summary>
    public extern event TypedEventHandler<WebView, WebViewDOMContentLoadedEventArgs> FrameDOMContentLoaded;

    /// <summary>Occurs when a frame in the WebView has finished loading its content.</summary>
    public extern event TypedEventHandler<WebView, WebViewNavigationCompletedEventArgs> FrameNavigationCompleted;

    /// <summary>Occurs periodically while the WebView executes JavaScript, letting you halt the script.</summary>
    public extern event TypedEventHandler<WebView, WebViewLongRunningScriptDetectedEventArgs> LongRunningScriptDetected;

    /// <summary>Occurs when the WebView shows a warning page for content that was reported as unsafe by SmartScreen Filter.</summary>
    public extern event TypedEventHandler<WebView, object> UnsafeContentWarningDisplaying;

    /// <summary>Occurs when the WebView attempts to download an unsupported file.</summary>
    public extern event TypedEventHandler<WebView, WebViewUnviewableContentIdentifiedEventArgs> UnviewableContentIdentified;

    /// <summary>Navigates the WebView to a URI with a POST request and HTTP headers.</summary>
    /// <param name="requestMessage">The details of the HTTP request.</param>
    [MethodImpl]
    public extern void NavigateWithHttpRequestMessage(HttpRequestMessage requestMessage);

    /// <summary>Sets the input focus to the WebView.</summary>
    /// <param name="value">A value that indicates how the focus was set.</param>
    /// <returns>**true** if focus was set; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool Focus(FocusState value);

    /// <summary>Gets a value that indicates whether the WebView contains an element that supports full screen.</summary>
    /// <returns>**true** if the WebView contains an element that supports full screen; otherwise, **false**.</returns>
    public extern bool ContainsFullScreenElement { [MethodImpl] get; }

    /// <summary>Occurs when the status of whether the WebView currently contains a full screen element or not changes.</summary>
    public extern event TypedEventHandler<WebView, object> ContainsFullScreenElementChanged;

    /// <summary>Gets a value that indicates whether the WebView hosts content on the UI thread or a non-UI thread.</summary>
    /// <returns>A value of the enumeration that specifies whether the WebView hosts content on the UI thread or a non-UI thread.</returns>
    public extern WebViewExecutionMode ExecutionMode { [MethodImpl] get; }

    /// <summary>Gets a collection of permission requests that are waiting to be granted or denied.</summary>
    /// <returns>A collection of WebViewDeferredPermissionRequest objects that are waiting to be granted or denied.</returns>
    public extern IVector<WebViewDeferredPermissionRequest> DeferredPermissionRequests { [MethodImpl] get; }

    /// <summary>Gets a WebViewSettings object that contains properties to enable or disable WebView features.</summary>
    /// <returns>A WebViewSettings object that contains properties to enable or disable WebView features.</returns>
    public extern WebViewSettings Settings { [MethodImpl] get; }

    /// <summary>Occurs when an attempt is made to navigate to a Uniform Resource Identifier (URI) using a scheme that WebView doesn't support.</summary>
    public extern event TypedEventHandler<WebView, WebViewUnsupportedUriSchemeIdentifiedEventArgs> UnsupportedUriSchemeIdentified;

    /// <summary>Occurs when a user performs an action in a WebView that causes content to be opened in a new window.</summary>
    public extern event TypedEventHandler<WebView, WebViewNewWindowRequestedEventArgs> NewWindowRequested;

    /// <summary>Occurs when an action in a WebView requires that permission be granted.</summary>
    public extern event TypedEventHandler<WebView, WebViewPermissionRequestedEventArgs> PermissionRequested;

    /// <summary>Adds a native Windows Runtime object as a global parameter to the top level document inside of a WebView.</summary>
    /// <param name="name">The name of the object to expose to the document in the WebView.</param>
    /// <param name="pObject">The object to expose to the document in the WebView.</param>
    [MethodImpl]
    public extern void AddWebAllowedObject(string name, object pObject);

    /// <summary>Returns the deferred permission request with the specified Id.</summary>
    /// <param name="id">The Id of the deferred permission request.</param>
    /// <returns>The deferred permission request with the specified Id.</returns>
    [MethodImpl]
    public extern WebViewDeferredPermissionRequest DeferredPermissionRequestById(
      uint id);

    /// <summary>Gets or sets the object that gets focus when a user presses the Directional Pad (D-pad) left.</summary>
    /// <returns>The object that gets focus when a user presses the Directional Pad (D-pad).</returns>
    public extern DependencyObject XYFocusLeft { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the object that gets focus when a user presses the Directional Pad (D-pad) right.</summary>
    /// <returns>The object that gets focus when a user presses the Directional Pad (D-pad).</returns>
    public extern DependencyObject XYFocusRight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the object that gets focus when a user presses the Directional Pad (D-pad) up.</summary>
    /// <returns>The object that gets focus when a user presses the Directional Pad (D-pad).</returns>
    public extern DependencyObject XYFocusUp { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the object that gets focus when a user presses the Directional Pad (D-pad) down.</summary>
    /// <returns>The object that gets focus when a user presses the Directional Pad (D-pad).</returns>
    public extern DependencyObject XYFocusDown { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when a WebView runs with an ExecutionMode of **SeparateProcess**, and the separate process is lost.</summary>
    public extern event TypedEventHandler<WebView, WebViewSeparateProcessLostEventArgs> SeparateProcessLost;

    /// <summary>Occurs when an HTTP request has been made.</summary>
    public extern event TypedEventHandler<WebView, WebViewWebResourceRequestedEventArgs> WebResourceRequested;

    /// <summary>Identifies the XYFocusLeft dependency property.</summary>
    /// <returns>The identifier for the XYFocusLeft dependency property.</returns>
    public static extern DependencyProperty XYFocusLeftProperty { [MethodImpl] get; }

    /// <summary>Identifies the XYFocusRight dependency property.</summary>
    /// <returns>The identifier for the XYFocusRight dependency property.</returns>
    public static extern DependencyProperty XYFocusRightProperty { [MethodImpl] get; }

    /// <summary>Identifies the XYFocusUp dependency property.</summary>
    /// <returns>The identifier for the XYFocusUp dependency property.</returns>
    public static extern DependencyProperty XYFocusUpProperty { [MethodImpl] get; }

    /// <summary>Identifies the XYFocusDown dependency property.</summary>
    /// <returns>The identifier for the XYFocusDown dependency property.</returns>
    public static extern DependencyProperty XYFocusDownProperty { [MethodImpl] get; }

    /// <summary>Gets the default threading behavior of WebView instances in the current app.</summary>
    /// <returns>The default threading behavior of WebView instances in the current app.</returns>
    public static extern WebViewExecutionMode DefaultExecutionMode { [MethodImpl] get; }

    /// <summary>Clears the WebView 's cache and **IndexedDB** data.</summary>
    /// <returns>An asynchronous action to await the clear operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ClearTemporaryWebDataAsync();

    /// <summary>Identifies the ContainsFullScreenElement dependency property.</summary>
    /// <returns>The identifier for the ContainsFullScreenElement dependency property.</returns>
    public static extern DependencyProperty ContainsFullScreenElementProperty { [MethodImpl] get; }

    /// <summary>Identifies the CanGoBack dependency property.</summary>
    /// <returns>The identifier for the CanGoBack dependency property.</returns>
    public static extern DependencyProperty CanGoBackProperty { [MethodImpl] get; }

    /// <summary>Identifies the CanGoForward dependency property.</summary>
    /// <returns>The identifier for the CanGoForward dependency property.</returns>
    public static extern DependencyProperty CanGoForwardProperty { [MethodImpl] get; }

    /// <summary>Identifies the DocumentTitle dependency property.</summary>
    /// <returns>The identifier of the DocumentTitle dependency property.</returns>
    public static extern DependencyProperty DocumentTitleProperty { [MethodImpl] get; }

    /// <summary>Identifies the DefaultBackgroundColor dependency property.</summary>
    /// <returns>The identifier for the DefaultBackgroundColor dependency property.</returns>
    public static extern DependencyProperty DefaultBackgroundColorProperty { [MethodImpl] get; }

    /// <summary>Gets a value that you can use to set the AllowedScriptNotifyUris property to indicate that any page can fire ScriptNotify events to this WebView.</summary>
    /// <returns>The safe list of URIs that are permitted to fire ScriptNotify events.</returns>
    public static extern IVector<Uri> AnyScriptNotifyUri { [Deprecated("AnyScriptNotifyUri is unavailable for releases beginning with Windows 8.1. Instead, list URIs under ApplicationContentUriRules in the package manifest. For more info, see the AnyScriptNotifyUri documentation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Identifies the Source dependency property.</summary>
    /// <returns>The identifier for the Source dependency property.</returns>
    public static extern DependencyProperty SourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the AllowedScriptNotifyUris dependency property.</summary>
    /// <returns>The identifier for the AllowedScriptNotifyUris dependency property.</returns>
    public static extern DependencyProperty AllowedScriptNotifyUrisProperty { [Deprecated("AllowedScriptNotifyUris is unavailable for releases beginning with Windows 8.1. Instead, list URIs under ApplicationContentUriRules in the package manifest. For more info, see the AllowedScriptNotifyUris documentation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Identifies the DataTransferPackage dependency property.</summary>
    /// <returns>The identifier for the DataTransferPackage dependency property.</returns>
    public static extern DependencyProperty DataTransferPackageProperty { [Deprecated("Use CaptureSelectedContentToDataPackageAsync instead of DataTransferPackage. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
