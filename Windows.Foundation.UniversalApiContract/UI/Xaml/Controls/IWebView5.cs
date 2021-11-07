// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebView5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(2358805670, 12091, 19029, 164, 99, 132, 68, 194, 9, 93, 0)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (WebView))]
  internal interface IWebView5
  {
    DependencyObject XYFocusLeft { get; set; }

    DependencyObject XYFocusRight { get; set; }

    DependencyObject XYFocusUp { get; set; }

    DependencyObject XYFocusDown { get; set; }
  }
}
