// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.WebViewBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides a brush that renders the content that is currently hosted in a WebView control.</summary>
  [Static(typeof (IWebViewBrushStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WebViewBrush : TileBrush, IWebViewBrush
  {
    /// <summary>Initializes a new instance of the WebViewBrush class.</summary>
    [MethodImpl]
    public extern WebViewBrush();

    /// <summary>Gets or sets the name of the source WebView control that provides the HTML content.</summary>
    /// <returns>The Name or x:Name attribute of the WebView that provides the HTML content.</returns>
    public extern string SourceName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Causes the WebViewBrush to get updated source pixels from the associated WebView and its current content. This happens asynchronously.</summary>
    [MethodImpl]
    public extern void Redraw();

    /// <summary>Sets the source of the content for the WebViewBrush.</summary>
    /// <param name="source">The WebView hosting the HTML content that is the source for the brush.</param>
    [MethodImpl]
    public extern void SetSource(WebView source);

    /// <summary>Identifies the SourceName dependency property.</summary>
    /// <returns>The identifier for the SourceName dependency property.</returns>
    public static extern DependencyProperty SourceNameProperty { [MethodImpl] get; }
  }
}
