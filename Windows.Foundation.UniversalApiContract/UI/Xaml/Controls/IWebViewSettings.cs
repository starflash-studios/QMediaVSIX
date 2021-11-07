// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (WebViewSettings))]
  [Guid(491826509, 44022, 18309, 141, 243, 253, 235, 193, 39, 3, 1)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebViewSettings
  {
    bool IsJavaScriptEnabled { get; set; }

    bool IsIndexedDBEnabled { get; set; }
  }
}
