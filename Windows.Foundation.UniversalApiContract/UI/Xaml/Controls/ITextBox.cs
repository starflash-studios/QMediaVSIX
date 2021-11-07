// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3834600075, 7679, 17234, 161, 244, 229, 22, 81, 78, 200, 130)]
  [ExclusiveTo(typeof (TextBox))]
  internal interface ITextBox
  {
    string Text { get; set; }

    string SelectedText { get; set; }

    int SelectionLength { get; set; }

    int SelectionStart { get; set; }

    int MaxLength { get; set; }

    bool IsReadOnly { get; set; }

    bool AcceptsReturn { get; set; }

    TextAlignment TextAlignment { get; set; }

    TextWrapping TextWrapping { get; set; }

    bool IsSpellCheckEnabled { get; set; }

    bool IsTextPredictionEnabled { get; set; }

    InputScope InputScope { get; set; }

    event TextChangedEventHandler TextChanged;

    event RoutedEventHandler SelectionChanged;

    event ContextMenuOpeningEventHandler ContextMenuOpening;

    void Select(int start, int length);

    void SelectAll();

    Rect GetRectFromCharacterIndex(int charIndex, bool trailingEdge);
  }
}
