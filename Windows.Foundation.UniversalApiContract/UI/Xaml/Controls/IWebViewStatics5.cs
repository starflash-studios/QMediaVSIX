// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewStatics5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (WebView))]
  [Guid(144750801, 20618, 19896, 151, 239, 15, 165, 5, 225, 158, 194)]
  [WebHostHidden]
  internal interface IWebViewStatics5
  {
    DependencyProperty XYFocusLeftProperty { get; }

    DependencyProperty XYFocusRightProperty { get; }

    DependencyProperty XYFocusUpProperty { get; }

    DependencyProperty XYFocusDownProperty { get; }
  }
}
