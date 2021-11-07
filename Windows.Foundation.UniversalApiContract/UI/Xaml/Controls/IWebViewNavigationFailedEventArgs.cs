// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewNavigationFailedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (WebViewNavigationFailedEventArgs))]
  [WebHostHidden]
  [Guid(2936627354, 4764, 16752, 158, 156, 226, 205, 240, 37, 220, 164)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebViewNavigationFailedEventArgs
  {
    Uri Uri { get; }

    WebErrorStatus WebErrorStatus { get; }
  }
}
