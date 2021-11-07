// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.WebViewNavigationFailedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents the method that will handle the WebView.NavigationFailed  event.</summary>
  /// <param name="sender">The object where the event handler is attached.</param>
  /// <param name="e">The event data.</param>
  [Guid(2736697313, 16860, 18424, 174, 34, 151, 6, 200, 241, 67, 212)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void WebViewNavigationFailedEventHandler(
    object sender,
    WebViewNavigationFailedEventArgs e);
}
