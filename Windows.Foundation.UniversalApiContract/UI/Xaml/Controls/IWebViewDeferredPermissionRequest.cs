// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewDeferredPermissionRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (WebViewDeferredPermissionRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2749154401, 29520, 19770, 143, 185, 64, 238, 236, 39, 70, 194)]
  internal interface IWebViewDeferredPermissionRequest
  {
    Uri Uri { get; }

    WebViewPermissionType PermissionType { get; }

    uint Id { get; }

    void Allow();

    void Deny();
  }
}
