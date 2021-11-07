// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebView3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (WebView))]
  [Guid(3298261147, 46233, 19817, 181, 194, 174, 157, 93, 109, 89, 78)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebView3
  {
    bool ContainsFullScreenElement { get; }

    event TypedEventHandler<WebView, object> ContainsFullScreenElementChanged;
  }
}
