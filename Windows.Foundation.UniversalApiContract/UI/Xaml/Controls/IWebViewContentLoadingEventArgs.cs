// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewContentLoadingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(1848213691, 39096, 16702, 129, 41, 151, 28, 111, 126, 76, 138)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebViewContentLoadingEventArgs))]
  internal interface IWebViewContentLoadingEventArgs
  {
    Uri Uri { get; }
  }
}
