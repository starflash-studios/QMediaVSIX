// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebView6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(952949058, 9526, 18044, 162, 17, 175, 53, 156, 59, 79, 218)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (WebView))]
  [WebHostHidden]
  internal interface IWebView6
  {
    event TypedEventHandler<WebView, WebViewSeparateProcessLostEventArgs> SeparateProcessLost;
  }
}
