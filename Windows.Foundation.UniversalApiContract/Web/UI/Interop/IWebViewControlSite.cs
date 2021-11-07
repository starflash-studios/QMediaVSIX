// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.Interop.IWebViewControlSite
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI.Interop
{
  [Guid(322914246, 4828, 18584, 189, 71, 4, 150, 125, 230, 72, 186)]
  [ExclusiveTo(typeof (WebViewControl))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IWebViewControlSite
  {
    WebViewControlProcess Process { get; }

    double Scale { set; get; }

    Rect Bounds { set; get; }

    bool IsVisible { set; get; }

    void Close();

    void MoveFocus(WebViewControlMoveFocusReason reason);

    event TypedEventHandler<WebViewControl, WebViewControlMoveFocusRequestedEventArgs> MoveFocusRequested;

    event TypedEventHandler<WebViewControl, WebViewControlAcceleratorKeyPressedEventArgs> AcceleratorKeyPressed;
  }
}
