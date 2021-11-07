// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.IWebViewControlDeferredPermissionRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (WebViewControlDeferredPermissionRequest))]
  [Guid(753093088, 55129, 17500, 153, 38, 137, 149, 41, 143, 21, 43)]
  internal interface IWebViewControlDeferredPermissionRequest
  {
    uint Id { get; }

    Uri Uri { get; }

    WebViewControlPermissionType PermissionType { get; }

    void Allow();

    void Deny();
  }
}
