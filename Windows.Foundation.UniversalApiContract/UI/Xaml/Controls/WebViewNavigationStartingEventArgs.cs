// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.WebViewNavigationStartingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the WebView.NavigationStarting and FrameNavigationStarting events.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class WebViewNavigationStartingEventArgs : IWebViewNavigationStartingEventArgs
  {
    /// <summary>Gets the Uniform Resource Identifier (URI) of the content the WebView is loading.</summary>
    /// <returns>The Uniform Resource Identifier (URI) of the content.</returns>
    public extern Uri Uri { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating whether to cancel the WebView navigation.</summary>
    /// <returns>**true** to cancel the navigation; otherwise, **false**.</returns>
    public extern bool Cancel { [MethodImpl] get; [MethodImpl] set; }
  }
}
