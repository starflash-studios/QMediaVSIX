// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewNavigationStartingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2496366184, 33639, 17365, 145, 187, 150, 235, 163, 126, 199, 132)]
  [ExclusiveTo(typeof (WebViewNavigationStartingEventArgs))]
  [WebHostHidden]
  internal interface IWebViewNavigationStartingEventArgs
  {
    Uri Uri { get; }

    bool Cancel { get; set; }
  }
}
