// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBox8
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TextBox))]
  [Guid(515297319, 791, 23607, 138, 234, 247, 71, 174, 127, 4, 99)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ITextBox8
  {
    bool CanPasteClipboardContent { get; }

    bool CanUndo { get; }

    bool CanRedo { get; }

    FlyoutBase SelectionFlyout { get; set; }

    FlyoutBase ProofingMenuFlyout { get; }

    object Description { get; set; }

    event TypedEventHandler<TextBox, TextBoxSelectionChangingEventArgs> SelectionChanging;

    void Undo();

    void Redo();

    void PasteFromClipboard();

    void CopySelectionToClipboard();

    void CutSelectionToClipboard();

    void ClearUndoRedoHistory();
  }
}
