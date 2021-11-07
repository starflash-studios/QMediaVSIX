// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.IWebViewControlNewWindowRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (WebViewControlNewWindowRequestedEventArgs))]
  [Guid(1039420347, 41252, 18133, 160, 131, 208, 44, 172, 223, 245, 173)]
  internal interface IWebViewControlNewWindowRequestedEventArgs
  {
    Uri Uri { get; }

    Uri Referrer { get; }

    bool Handled { get; set; }
  }
}
