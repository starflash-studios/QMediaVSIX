// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.IWebViewControlNavigationCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI
{
  [Guid(541104408, 18965, 19526, 165, 93, 247, 158, 219, 11, 222, 139)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (WebViewControlNavigationCompletedEventArgs))]
  internal interface IWebViewControlNavigationCompletedEventArgs
  {
    Uri Uri { get; }

    bool IsSuccess { get; }

    WebErrorStatus WebErrorStatus { get; }
  }
}
