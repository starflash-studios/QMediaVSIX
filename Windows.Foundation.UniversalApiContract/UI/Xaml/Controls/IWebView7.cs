// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebView7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(661683243, 1071, 21331, 144, 33, 85, 205, 6, 88, 95, 223)]
  [WebHostHidden]
  [ExclusiveTo(typeof (WebView))]
  internal interface IWebView7
  {
    event TypedEventHandler<WebView, WebViewWebResourceRequestedEventArgs> WebResourceRequested;
  }
}
