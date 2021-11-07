// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.IWebViewControlUnsupportedUriSchemeIdentifiedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI
{
  [ExclusiveTo(typeof (WebViewControlUnsupportedUriSchemeIdentifiedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(3820493124, 58620, 17372, 148, 202, 249, 128, 243, 11, 197, 29)]
  internal interface IWebViewControlUnsupportedUriSchemeIdentifiedEventArgs
  {
    Uri Uri { get; }

    bool Handled { get; set; }
  }
}
