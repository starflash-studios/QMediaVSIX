// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.Interop.IWebViewControlProcessOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI.Interop
{
  [ExclusiveTo(typeof (WebViewControlProcessOptions))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(483029671, 15318, 18470, 130, 97, 108, 129, 137, 80, 93, 137)]
  internal interface IWebViewControlProcessOptions
  {
    string EnterpriseId { set; get; }

    WebViewControlProcessCapabilityState PrivateNetworkClientServerCapability { set; get; }
  }
}
