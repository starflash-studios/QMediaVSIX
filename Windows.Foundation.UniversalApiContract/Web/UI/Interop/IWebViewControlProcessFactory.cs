// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.Interop.IWebViewControlProcessFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI.Interop
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(1203133689, 41682, 17724, 176, 151, 246, 119, 157, 75, 142, 2)]
  [ExclusiveTo(typeof (WebViewControlProcess))]
  internal interface IWebViewControlProcessFactory
  {
    WebViewControlProcess CreateWithOptions(
      WebViewControlProcessOptions processOptions);
  }
}
