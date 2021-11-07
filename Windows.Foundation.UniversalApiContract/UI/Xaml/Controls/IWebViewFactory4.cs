// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewFactory4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2196614232, 61034, 19611, 163, 160, 147, 71, 167, 208, 239, 76)]
  [ExclusiveTo(typeof (WebView))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebViewFactory4
  {
    WebView CreateInstanceWithExecutionMode(WebViewExecutionMode executionMode);
  }
}
