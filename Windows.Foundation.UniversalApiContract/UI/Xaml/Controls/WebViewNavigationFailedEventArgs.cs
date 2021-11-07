// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.WebViewNavigationFailedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the WebView.NavigationFailed event.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WebViewNavigationFailedEventArgs : IWebViewNavigationFailedEventArgs
  {
    /// <summary>Gets the URI that the WebView attempted to navigate to.</summary>
    /// <returns>The attempted navigation target.</returns>
    public extern Uri Uri { [MethodImpl] get; }

    /// <summary>Gets the error that occurred when navigation failed.</summary>
    /// <returns>The navigation error.</returns>
    public extern WebErrorStatus WebErrorStatus { [MethodImpl] get; }
  }
}
