// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.Interop.IWebViewControlProcess
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI.Interop
{
  [ExclusiveTo(typeof (WebViewControlProcess))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(46605292, 39126, 16970, 182, 62, 198, 19, 108, 54, 160, 242)]
  internal interface IWebViewControlProcess
  {
    uint ProcessId { get; }

    string EnterpriseId { get; }

    bool IsPrivateNetworkClientServerCapabilityEnabled { get; }

    [RemoteAsync]
    IAsyncOperation<WebViewControl> CreateWebViewControlAsync(
      long hostWindowHandle,
      Rect bounds);

    IVectorView<WebViewControl> GetWebViewControls();

    void Terminate();

    event TypedEventHandler<WebViewControlProcess, object> ProcessExited;
  }
}
