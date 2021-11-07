// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebView4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (WebView))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3800187836, 26611, 17962, 180, 224, 59, 191, 108, 61, 171, 11)]
  [WebHostHidden]
  internal interface IWebView4
  {
    WebViewExecutionMode ExecutionMode { get; }

    IVector<WebViewDeferredPermissionRequest> DeferredPermissionRequests { get; }

    WebViewSettings Settings { get; }

    event TypedEventHandler<WebView, WebViewUnsupportedUriSchemeIdentifiedEventArgs> UnsupportedUriSchemeIdentified;

    event TypedEventHandler<WebView, WebViewNewWindowRequestedEventArgs> NewWindowRequested;

    event TypedEventHandler<WebView, WebViewPermissionRequestedEventArgs> PermissionRequested;

    void AddWebAllowedObject(string name, object pObject);

    WebViewDeferredPermissionRequest DeferredPermissionRequestById(
      uint id);
  }
}
