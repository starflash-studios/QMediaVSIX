// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.IWebViewControlContentLoadingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI
{
  [Guid(2587872434, 47547, 16459, 162, 43, 102, 220, 205, 18, 80, 198)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (WebViewControlContentLoadingEventArgs))]
  internal interface IWebViewControlContentLoadingEventArgs
  {
    Uri Uri { get; }
  }
}
