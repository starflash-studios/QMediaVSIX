// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.IWebViewControlNewWindowRequestedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (WebViewControlNewWindowRequestedEventArgs))]
  [Guid(3040631974, 10926, 19452, 146, 185, 195, 14, 146, 180, 128, 152)]
  internal interface IWebViewControlNewWindowRequestedEventArgs2
  {
    IWebViewControl NewWindow { get; set; }

    Deferral GetDeferral();
  }
}
