// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichTextBlock
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
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RichTextBlock))]
  [WebHostHidden]
  [Guid(3858758114, 47464, 18919, 151, 212, 140, 202, 42, 195, 174, 124)]
  internal interface IRichTextBlock
  {
    double FontSize { get; set; }

    FontFamily FontFamily { get; set; }

    FontWeight FontWeight { get; set; }

    FontStyle FontStyle { get; set; }

    FontStretch FontStretch { get; set; }

    Brush Foreground { get; set; }

    TextWrapping TextWrapping { get; set; }

    TextTrimming TextTrimming { get; set; }

    TextAlignment TextAlignment { get; set; }

    BlockCollection Blocks { get; }

    Thickness Padding { get; set; }

    double LineHeight { get; set; }

    LineStackingStrategy LineStackingStrategy { get; set; }

    int CharacterSpacing { get; set; }

    RichTextBlockOverflow OverflowContentTarget { get; set; }

    bool IsTextSelectionEnabled { get; set; }

    bool HasOverflowContent { get; }

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

    TextPointer GetPositionFromPoint(Point point);

    bool Focus(FocusState value);

    double TextIndent { get; set; }
  }
}
