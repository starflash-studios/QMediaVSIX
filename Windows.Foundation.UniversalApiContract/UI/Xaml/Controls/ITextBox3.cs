// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBox3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TextBox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2112982076, 10278, 16990, 154, 148, 0, 183, 247, 63, 55, 86)]
  [WebHostHidden]
  internal interface ITextBox3
  {
    event TypedEventHandler<TextBox, TextCompositionStartedEventArgs> TextCompositionStarted;

    event TypedEventHandler<TextBox, TextCompositionChangedEventArgs> TextCompositionChanged;

    event TypedEventHandler<TextBox, TextCompositionEndedEventArgs> TextCompositionEnded;

    TextReadingOrder TextReadingOrder { get; set; }

    CandidateWindowAlignment DesiredCandidateWindowAlignment { get; set; }

    event TypedEventHandler<TextBox, CandidateWindowBoundsChangedEventArgs> CandidateWindowBoundsChanged;

    event TypedEventHandler<TextBox, TextBoxTextChangingEventArgs> TextChanging;
  }
}
