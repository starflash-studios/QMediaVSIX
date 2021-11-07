// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.Interop.IWebViewControlSite2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI.Interop
{
  [Guid(3510316607, 18670, 18224, 130, 67, 210, 237, 12, 5, 96, 106)]
  [ExclusiveTo(typeof (WebViewControl))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IWebViewControlSite2
  {
    event TypedEventHandler<WebViewControl, object> GotFocus;

    event TypedEventHandler<WebViewControl, object> LostFocus;
  }
}
