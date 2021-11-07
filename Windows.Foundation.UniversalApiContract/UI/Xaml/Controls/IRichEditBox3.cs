// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichEditBox3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(1796711522, 64438, 20479, 153, 145, 147, 153, 203, 156, 11, 144)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RichEditBox))]
  internal interface IRichEditBox3
  {
    event TypedEventHandler<RichEditBox, TextCompositionStartedEventArgs> TextCompositionStarted;

    event TypedEventHandler<RichEditBox, TextCompositionChangedEventArgs> TextCompositionChanged;

    event TypedEventHandler<RichEditBox, TextCompositionEndedEventArgs> TextCompositionEnded;

    TextReadingOrder TextReadingOrder { get; set; }

    CandidateWindowAlignment DesiredCandidateWindowAlignment { get; set; }

    event TypedEventHandler<RichEditBox, CandidateWindowBoundsChangedEventArgs> CandidateWindowBoundsChanged;

    event TypedEventHandler<RichEditBox, RichEditBoxTextChangingEventArgs> TextChanging;
  }
}
