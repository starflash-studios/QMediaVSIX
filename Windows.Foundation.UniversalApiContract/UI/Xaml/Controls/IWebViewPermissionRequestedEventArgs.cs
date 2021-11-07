// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewPermissionRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3672035280, 28190, 18239, 176, 190, 176, 36, 4, 214, 168, 109)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (WebViewPermissionRequestedEventArgs))]
  internal interface IWebViewPermissionRequestedEventArgs
  {
    WebViewPermissionRequest PermissionRequest { get; }
  }
}
