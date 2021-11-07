// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewUnviewableContentIdentifiedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2596147540, 14064, 17000, 141, 136, 18, 30, 237, 244, 94, 106)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebViewUnviewableContentIdentifiedEventArgs))]
  [WebHostHidden]
  internal interface IWebViewUnviewableContentIdentifiedEventArgs2
  {
    string MediaType { get; }
  }
}
