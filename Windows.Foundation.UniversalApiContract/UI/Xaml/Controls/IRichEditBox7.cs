// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichEditBox7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2550961130, 9247, 20330, 165, 57, 157, 24, 92, 140, 241, 138)]
  [ExclusiveTo(typeof (RichEditBox))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  internal interface IRichEditBox7
  {
    SolidColorBrush ContentLinkForegroundColor { get; set; }

    SolidColorBrush ContentLinkBackgroundColor { get; set; }

    ContentLinkProviderCollection ContentLinkProviders { get; set; }

    HandwritingView HandwritingView { get; set; }

    bool IsHandwritingViewEnabled { get; set; }

    event TypedEventHandler<RichEditBox, ContentLinkChangedEventArgs> ContentLinkChanged;

    event TypedEventHandler<RichEditBox, ContentLinkInvokedEventArgs> ContentLinkInvoked;
  }
}
