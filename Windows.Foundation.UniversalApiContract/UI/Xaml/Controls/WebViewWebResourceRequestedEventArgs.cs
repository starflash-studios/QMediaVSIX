// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.WebViewWebResourceRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web.Http;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the WebView.WebResourceRequested event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class WebViewWebResourceRequestedEventArgs : IWebViewWebResourceRequestedEventArgs
  {
    /// <summary>Gets the web resource request.</summary>
    /// <returns>The web resource request.</returns>
    public extern HttpRequestMessage Request { [MethodImpl] get; }

    /// <summary>Gets or sets the response to the web resource request.</summary>
    /// <returns>The response to the web resource request.</returns>
    public extern HttpResponseMessage Response { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a deferral object for managing the work done in the WebResourceRequested event handler.</summary>
    /// <returns>A deferral object.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
