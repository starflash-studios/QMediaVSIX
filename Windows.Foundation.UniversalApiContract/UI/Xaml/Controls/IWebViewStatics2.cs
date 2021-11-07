// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(841975680, 59410, 18027, 158, 80, 142, 159, 236, 36, 1, 138)]
  [ExclusiveTo(typeof (WebView))]
  [WebHostHidden]
  internal interface IWebViewStatics2
  {
    DependencyProperty CanGoBackProperty { get; }

    DependencyProperty CanGoForwardProperty { get; }

    DependencyProperty DocumentTitleProperty { get; }

    DependencyProperty DefaultBackgroundColorProperty { get; }
  }
}
