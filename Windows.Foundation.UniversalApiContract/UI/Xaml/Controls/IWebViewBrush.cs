// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (WebViewBrush))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1088974709, 3316, 19314, 164, 214, 207, 93, 21, 120, 1, 22)]
  internal interface IWebViewBrush
  {
    string SourceName { get; set; }

    void Redraw();

    void SetSource(WebView source);
  }
}
