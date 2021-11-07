// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichEditBoxStatics7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1509591439, 63585, 17370, 167, 206, 75, 156, 33, 216, 53, 249)]
  [ExclusiveTo(typeof (RichEditBox))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  internal interface IRichEditBoxStatics7
  {
    DependencyProperty ContentLinkForegroundColorProperty { get; }

    DependencyProperty ContentLinkBackgroundColorProperty { get; }

    DependencyProperty ContentLinkProvidersProperty { get; }

    DependencyProperty HandwritingViewProperty { get; }

    DependencyProperty IsHandwritingViewEnabledProperty { get; }
  }
}
