// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.IWebViewControlPermissionRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI
{
  [ExclusiveTo(typeof (WebViewControlPermissionRequest))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(3854336876, 61999, 16610, 149, 178, 119, 41, 248, 64, 235, 127)]
  internal interface IWebViewControlPermissionRequest
  {
    uint Id { get; }

    Uri Uri { get; }

    WebViewControlPermissionType PermissionType { get; }

    WebViewControlPermissionState State { get; }

    void Defer();

    void Allow();

    void Deny();
  }
}
