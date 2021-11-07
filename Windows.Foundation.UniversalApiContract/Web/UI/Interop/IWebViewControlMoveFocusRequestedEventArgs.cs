// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.Interop.IWebViewControlMoveFocusRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI.Interop
{
  [ExclusiveTo(typeof (WebViewControlMoveFocusRequestedEventArgs))]
  [Guid(1797927949, 19408, 16478, 183, 193, 30, 114, 164, 146, 244, 70)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IWebViewControlMoveFocusRequestedEventArgs
  {
    WebViewControlMoveFocusReason Reason { get; }
  }
}
