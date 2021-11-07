// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IHandwritingViewStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 720896)]
  [ExclusiveTo(typeof (HandwritingView))]
  [Guid(751850212, 55043, 20867, 161, 190, 126, 40, 93, 249, 120, 217)]
  internal interface IHandwritingViewStatics2
  {
    DependencyProperty IsSwitchToKeyboardEnabledProperty { get; }

    DependencyProperty IsCommandBarOpenProperty { get; }
  }
}
