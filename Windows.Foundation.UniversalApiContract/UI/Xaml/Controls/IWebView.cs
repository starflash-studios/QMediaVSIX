// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Navigation;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1482869830, 8061, 18331, 146, 166, 222, 120, 88, 254, 141, 84)]
  [ExclusiveTo(typeof (WebView))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebView
  {
    Uri Source { get; set; }

    IVector<Uri> AllowedScriptNotifyUris { [Deprecated("AllowedScriptNotifyUris is unavailable for releases beginning with Windows 8.1. Instead, list URIs under ApplicationContentUriRules in the package manifest. For more info, see the AllowedScriptNotifyUris documentation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("AllowedScriptNotifyUris is unavailable for releases beginning with Windows 8.1. Instead, list URIs under ApplicationContentUriRules in the package manifest. For more info, see the AllowedScriptNotifyUris documentation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; }

    DataPackage DataTransferPackage { [Deprecated("Use CaptureSelectedContentToDataPackageAsync instead of DataTransferPackage. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    event LoadCompletedEventHandler LoadCompleted;

    event NotifyEventHandler ScriptNotify;

    event WebViewNavigationFailedEventHandler NavigationFailed;

    [Deprecated("Use InvokeScriptAsync instead of InvokeScript. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    string InvokeScript(string scriptName, string[] arguments);

    void Navigate(Uri source);

    void NavigateToString(string text);
  }
}
