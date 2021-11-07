// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.WebViewControlWebResourceRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web.Http;

namespace Windows.Web.UI
{
  /// <summary>Provides data to the Windows.Web.UI.IWebViewControl.WebResourceRequested event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class WebViewControlWebResourceRequestedEventArgs : 
    IWebViewControlWebResourceRequestedEventArgs
  {
    /// <summary>Gets a deferral.</summary>
    /// <returns>An asynchronous operation that completes with the deferral.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();

    /// <summary>Gets the intercepted HTTP request.</summary>
    /// <returns>The intercepted HTTP request.</returns>
    public extern HttpRequestMessage Request { [MethodImpl] get; }

    /// <summary>Gets or sets the HTTP response that will be sent to the Windows.Web.UI.IWebViewControl</summary>
    /// <returns>The HTML response.</returns>
    public extern HttpResponseMessage Response { [MethodImpl] set; [MethodImpl] get; }
  }
}
