// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAutoSuggestBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(272538387, 13312, 18966, 144, 185, 105, 18, 191, 6, 151, 79)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AutoSuggestBox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAutoSuggestBox
  {
    double MaxSuggestionListHeight { get; set; }

    bool IsSuggestionListOpen { get; set; }

    string TextMemberPath { get; set; }

    string Text { get; set; }

    bool UpdateTextOnSelect { get; set; }

    string PlaceholderText { get; set; }

    object Header { get; set; }

    bool AutoMaximizeSuggestionArea { get; set; }

    Style TextBoxStyle { get; set; }

    event TypedEventHandler<AutoSuggestBox, AutoSuggestBoxSuggestionChosenEventArgs> SuggestionChosen;

    event TypedEventHandler<AutoSuggestBox, AutoSuggestBoxTextChangedEventArgs> TextChanged;
  }
}
