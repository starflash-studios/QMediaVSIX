// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the WebView.NavigationCompleted and FrameNavigationCompleted events.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class WebViewNavigationCompletedEventArgs : IWebViewNavigationCompletedEventArgs
  {
    /// <summary>Gets the Uniform Resource Identifier (URI) of the WebView content.</summary>
    /// <returns>The Uniform Resource Identifier (URI) of the content.</returns>
    public extern Uri Uri { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the navigation completed successfully.</summary>
    /// <returns>**true** if the navigation completed successfully; otherwise, **false**.</returns>
    public extern bool IsSuccess { [MethodImpl] get; }

    /// <summary>If the navigation was unsuccessful, gets a value that indicates why</summary>
    /// <returns>A value that explains an unsuccessful navigation.</returns>
    public extern WebErrorStatus WebErrorStatus { [MethodImpl] get; }
  }
}
