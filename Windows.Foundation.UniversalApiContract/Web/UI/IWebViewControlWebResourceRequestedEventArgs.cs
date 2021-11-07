// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.IWebViewControlWebResourceRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web.Http;

namespace Windows.Web.UI
{
  [ExclusiveTo(typeof (WebViewControlWebResourceRequestedEventArgs))]
  [Guid(1154896461, 21924, 19851, 137, 28, 147, 29, 142, 37, 212, 46)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IWebViewControlWebResourceRequestedEventArgs
  {
    Deferral GetDeferral();

    HttpRequestMessage Request { get; }

    HttpResponseMessage Response { set; get; }
  }
}
