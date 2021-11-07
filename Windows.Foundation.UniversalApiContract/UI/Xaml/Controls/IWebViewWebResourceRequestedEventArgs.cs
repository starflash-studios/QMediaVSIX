// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewWebResourceRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web.Http;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (WebViewWebResourceRequestedEventArgs))]
  [Guid(931996150, 51071, 23947, 143, 48, 147, 201, 157, 247, 148, 53)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IWebViewWebResourceRequestedEventArgs
  {
    HttpRequestMessage Request { get; }

    HttpResponseMessage Response { get; set; }

    Deferral GetDeferral();
  }
}
