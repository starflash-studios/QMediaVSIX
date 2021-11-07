// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBlock
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TextBlock))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2922222193, 15178, 17916, 132, 104, 247, 148, 149, 72, 244, 213)]
  [WebHostHidden]
  internal interface ITextBlock
  {
    double FontSize { get; set; }

    FontFamily FontFamily { get; set; }

    FontWeight FontWeight { get; set; }

    FontStyle FontStyle { get; set; }

    FontStretch FontStretch { get; set; }

    int CharacterSpacing { get; set; }

    Brush Foreground { get; set; }

    TextWrapping TextWrapping { get; set; }

    TextTrimming TextTrimming { get; set; }

    TextAlignment TextAlignment { get; set; }

    string Text { get; set; }

    InlineCollection Inlines { get; }

    Thickness Padding { get; set; }

    double LineHeight { get; set; }

    LineStackingStrategy LineStackingStrategy { get; set; }

    bool IsTextSelectionEnabled { get; set; }

    string SelectedText { get; }

    TextPointer ContentStart { get; }

    TextPointer ContentEnd { get; }

    TextPointer SelectionStart { get; }

    TextPointer SelectionEnd { get; }

    double BaselineOffset { get; }

    event RoutedEventHandler SelectionChanged;

    event ContextMenuOpeningEventHandler ContextMenuOpening;

    void SelectAll();

    void Select(TextPointer start, TextPointer end);

    bool Focus(FocusState value);
  }
}
