// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.WebViewControlPermissionState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI
{
  /// <summary>Defines constants that specify the state of a IWebViewControl.PermissionRequested event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum WebViewControlPermissionState
  {
    /// <summary>The state of the permission request can't be determined.</summary>
    Unknown,
    /// <summary>WebViewPermissionRequest.Defer was called. The permission request is deferred.</summary>
    Defer,
    /// <summary>WebViewPermissionRequest.Allow was called. The permission request is allowed.</summary>
    Allow,
    /// <summary>WebViewPermissionRequest.Deny was called. The permission request is denied.</summary>
    Deny,
  }
}
