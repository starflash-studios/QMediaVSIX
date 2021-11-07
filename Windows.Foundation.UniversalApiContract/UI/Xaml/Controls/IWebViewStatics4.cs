// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (WebView))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1152489392, 46918, 16627, 153, 54, 78, 187, 255, 107, 71, 184)]
  internal interface IWebViewStatics4
  {
    WebViewExecutionMode DefaultExecutionMode { get; }

    [RemoteAsync]
    IAsyncAction ClearTemporaryWebDataAsync();
  }
}
