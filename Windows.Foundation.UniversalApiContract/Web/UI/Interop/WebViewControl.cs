// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.Interop.WebViewControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI;
using Windows.Web.Http;

namespace Windows.Web.UI.Interop
{
  /// <summary>This class is an implementation of an IWebViewControl.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class WebViewControl : 
    IWebViewControl,
    IWebViewControlSite,
    IWebViewControl2,
    IWebViewControlSite2
  {
    /// <summary>Gets or sets the URI source of the HTML content to display in the control.</summary>
    /// <returns>The URI source of the HTML content to display in the control.</returns>
    public extern Uri Source { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the title of the page currently displayed in the control.</summary>
    /// <returns>The page title.</returns>
    public extern string DocumentTitle { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether there is at least one page in the backward navigation history.</summary>
    /// <returns>**true** if the control can navigate backward; otherwise, **false**.</returns>
    public extern bool CanGoBack { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether there is at least one page in the forward navigation history.</summary>
    /// <returns>**true** if the IWebViewControl can navigate forward; otherwise, **false**.</returns>
    public extern bool CanGoForward { [MethodImpl] get; }

    /// <summary>Gets or sets the color to use as the control background when the HTML content does not specify a color.</summary>
    /// <returns>The background color.</returns>
    public extern Color DefaultBackgroundColor { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the control contains an element that supports full screen.</summary>
    /// <returns>A value that indicates whether the IWebViewControl contains an element that supports full screen.</returns>
    public extern bool ContainsFullScreenElement { [MethodImpl] get; }

    /// <summary>Gets a WebViewControlSettings object that contains properties to enable or disable IWebViewControl features.</summary>
    /// <returns>A WebViewControlSettings object that contains properties to enable or disable IWebViewControl features.</returns>
    public extern WebViewControlSettings Settings { [MethodImpl] get; }

    /// <summary>Gets a collection of permission requests that are waiting to be granted or denied.</summary>
    /// <returns>A collection of WebViewDeferredPermissionRequest objects that are waiting to be granted or denied.</returns>
    public extern IVectorView<WebViewControlDeferredPermissionRequest> DeferredPermissionRequests { [MethodImpl] get; }

    /// <summary>Navigates the IWebViewControl to the next page in the navigation history.</summary>
    [MethodImpl]
    public extern void GoForward();

    /// <summary>Navigates the IWebViewControl to the previous page in the navigation history.</summary>
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

    /// <summary>Creates an image of the current control contents and writes it to the specified stream.</summary>
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
    /// <returns>The URI created by combining and normalizing the contentIdentifier and relativePath.</returns>
    [MethodImpl]
    public extern Uri BuildLocalStreamUri(string contentIdentifier, string relativePath);

    /// <summary>Returns the deferred permission request with the specified Id.</summary>
    /// <param name="id">The Id of the deferred permission request.</param>
    /// <param name="result">The deferred permission request with the specified Id.</param>
    [MethodImpl]
    public extern void GetDeferredPermissionRequestById(
      uint id,
      out WebViewControlDeferredPermissionRequest result);

    /// <summary>An event that is triggered before the control navigates to new content.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlNavigationStartingEventArgs> NavigationStarting;

    /// <summary>An event that is triggered when the control has started loading new content.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlContentLoadingEventArgs> ContentLoading;

    /// <summary>An event that is triggered when the control has finished parsing the current HTML content.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlDOMContentLoadedEventArgs> DOMContentLoaded;

    /// <summary>An event that is triggered when the control has finished loading the current content or if the navigation has failed.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlNavigationCompletedEventArgs> NavigationCompleted;

    /// <summary>An event that is triggered before a frame in the control navigates to new content.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlNavigationStartingEventArgs> FrameNavigationStarting;

    /// <summary>An event that is triggered when a frame in the control has finished parsing its current HTML content.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlContentLoadingEventArgs> FrameContentLoading;

    /// <summary>An event that is triggered when a frame in the control has finished parsing its current HTML content.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlDOMContentLoadedEventArgs> FrameDOMContentLoaded;

    /// <summary>An event that is triggered when a frame in the control has finished loading its content.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlNavigationCompletedEventArgs> FrameNavigationCompleted;

    /// <summary>An event that is triggered when the content contained in the control passes a string to the app using `window.external.notify`.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlScriptNotifyEventArgs> ScriptNotify;

    /// <summary>An event that is triggered periodically while the control executes JavaScript, letting you halt the script.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlLongRunningScriptDetectedEventArgs> LongRunningScriptDetected;

    /// <summary>An event that is triggered when the control shows a warning page for content that was reported as unsafe by SmartScreen Filter.</summary>
    public extern event TypedEventHandler<IWebViewControl, object> UnsafeContentWarningDisplaying;

    /// <summary>An event that is triggered when the control attempts to download an unsupported file.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlUnviewableContentIdentifiedEventArgs> UnviewableContentIdentified;

    /// <summary>An event that is triggered when an action in the control requires that permission to be granted.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlPermissionRequestedEventArgs> PermissionRequested;

    /// <summary>An event that is triggered when an attempt is made to navigate to a URI using a scheme that the control doesn't support.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlUnsupportedUriSchemeIdentifiedEventArgs> UnsupportedUriSchemeIdentified;

    /// <summary>An event that is triggered when a user performs an action in the control that causes content to be opened in a new window.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlNewWindowRequestedEventArgs> NewWindowRequested;

    /// <summary>An event that is triggered when the status of whether the control currently contains a full screen element or not changes.</summary>
    public extern event TypedEventHandler<IWebViewControl, object> ContainsFullScreenElementChanged;

    /// <summary>An event that is fired when an HTTP request is made.</summary>
    public extern event TypedEventHandler<IWebViewControl, WebViewControlWebResourceRequestedEventArgs> WebResourceRequested;

    /// <summary>Gets the process that the control is hosted in.</summary>
    /// <returns>The process that the control is hosted in.</returns>
    public extern WebViewControlProcess Process { [MethodImpl] get; }

    /// <summary>Gets or sets the scale of the window.</summary>
    /// <returns>The scale of the window.</returns>
    public extern double Scale { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the bounds of the control.</summary>
    /// <returns>The bounds of the control.</returns>
    public extern Rect Bounds { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates if this control is invisible.</summary>
    /// <returns>Value that indicates if this control is invisible.</returns>
    public extern bool IsVisible { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Closes the control.</summary>
    [MethodImpl]
    public extern void Close();

    /// <summary>Move the focus.</summary>
    /// <param name="reason">The reason.</param>
    [MethodImpl]
    public extern void MoveFocus(WebViewControlMoveFocusReason reason);

    /// <summary>An event that is triggered when a focus move is requested.</summary>
    public extern event TypedEventHandler<WebViewControl, WebViewControlMoveFocusRequestedEventArgs> MoveFocusRequested;

    /// <summary>An event that is triggered when the accelerator key is pressed.</summary>
    public extern event TypedEventHandler<WebViewControl, WebViewControlAcceleratorKeyPressedEventArgs> AcceleratorKeyPressed;

    /// <summary>Injects a script into a WebViewControl just after ContentLoading but before any other script is run on the page.</summary>
    /// <param name="script">
    /// </param>
    [MethodImpl]
    public extern void AddInitializeScript(string script);

    /// <summary>Informs your app when the WebViewControl receives focus (due to the user clicking inside/outside the WebViewControl). Use in combination with the LostFocus event and programmatic focus changes using the WebViewControl.MoveFocus method.</summary>
    public extern event TypedEventHandler<WebViewControl, object> GotFocus;

    /// <summary>Informs your app when the WebViewControl loses focus. May be initiated by the user clicking inside/outside the WebViewControl or by a programmatic focus change, such as the app calling SetFocus on a window that is not the WebViewControl or a MoveFocus method call.</summary>
    public extern event TypedEventHandler<WebViewControl, object> LostFocus;
  }
}
