// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.WebViewControlNewWindowRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI
{
  /// <summary>Provides data for the NewWindowRequested event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class WebViewControlNewWindowRequestedEventArgs : 
    IWebViewControlNewWindowRequestedEventArgs,
    IWebViewControlNewWindowRequestedEventArgs2
  {
    /// <summary>Gets the Uniform Resource Identifier (URI) of the content the IWebViewControl is attempting to navigate to.</summary>
    /// <returns>The Uniform Resource Identifier (URI) of the content the IWebViewControl is attempting to navigate to.</returns>
    public extern Uri Uri { [MethodImpl] get; }

    /// <summary>Gets the Uniform Resource Identifier (URI) of the content where the navigation was initiated.</summary>
    /// <returns>The Uniform Resource Identifier (URI) of the content where the navigation was initiated.</returns>
    public extern Uri Referrer { [MethodImpl] get; }

    /// <summary>Gets or sets a value that marks the routed event as handled.</summary>
    /// <returns>**true** to mark the routed event handled. **false** to leave the routed event unhandled, which permits the event to potentially route further and be acted on by other handlers. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Provides a new `WebViewControl` as the target for a `window.open` script call from inside the requesting `WebViewControl`. The content in target webview is always considered cross-origin to the content in opener webview and vice versa and subject to cross-origin restrictions. The `WebViewControl` provided in the `NewWindow` property must be new, running on the same process as the opener webview and cannot have been navigated. If `NewWindow` is set, then the provided `WebViewControl` is used.</summary>
    /// <returns>
    /// </returns>
    public extern IWebViewControl NewWindow { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a deferral.</summary>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
