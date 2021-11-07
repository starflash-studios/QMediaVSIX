// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewNavigationCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (WebViewNavigationCompletedEventArgs))]
  [Guid(300347915, 60327, 17600, 136, 155, 237, 235, 106, 6, 77, 221)]
  internal interface IWebViewNavigationCompletedEventArgs
  {
    Uri Uri { get; }

    bool IsSuccess { get; }

    WebErrorStatus WebErrorStatus { get; }
  }
}
