// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebView))]
  [Guid(2696241630, 24539, 17467, 185, 240, 92, 48, 246, 183, 161, 244)]
  [WebHostHidden]
  internal interface IWebViewStatics
  {
    IVector<Uri> AnyScriptNotifyUri { [Deprecated("AnyScriptNotifyUri is unavailable for releases beginning with Windows 8.1. Instead, list URIs under ApplicationContentUriRules in the package manifest. For more info, see the AnyScriptNotifyUri documentation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    DependencyProperty SourceProperty { get; }

    DependencyProperty AllowedScriptNotifyUrisProperty { [Deprecated("AllowedScriptNotifyUris is unavailable for releases beginning with Windows 8.1. Instead, list URIs under ApplicationContentUriRules in the package manifest. For more info, see the AllowedScriptNotifyUris documentation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    DependencyProperty DataTransferPackageProperty { [Deprecated("Use CaptureSelectedContentToDataPackageAsync instead of DataTransferPackage. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
