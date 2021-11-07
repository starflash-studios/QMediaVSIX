// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.RichEditTextDocument
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Text
{
  /// <summary>Represents a rich text document that can be loaded, saved, and edited.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RichEditTextDocument : 
    ITextDocument2,
    ITextDocument3,
    ITextDocument4,
    ITextDocument
  {
    /// <summary>Gets or sets a value that indicates whether trailing white space is taken into account when text is aligned.</summary>
    /// <returns>**true** if trailing whitespace is taken into account when text is aligned; **false** if trailing whitespace is ignored. The default is **false**.</returns>
    public extern bool AlignmentIncludesTrailingWhitespace { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether character spacing is applied to the last character in a line.</summary>
    /// <returns>**true** if spacing is applied to the last character in a line of text; otherwise, **false**. The default is **false**.</returns>
    public extern bool IgnoreTrailingCharacterSpacing { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Empties the undo and redo buffers.</summary>
    [MethodImpl]
    public extern void ClearUndoRedoHistory();

    /// <summary>Sets the RichEditBox content to the specified MathML.</summary>
    /// <param name="value">The MathML content for the RichEditBox.</param>
    [MethodImpl]
    public extern void SetMath(string value);

    /// <summary>Retrieves the RichEditBox content as MathML.</summary>
    /// <param name="value">The RichEditBox content as MathML.</param>
    [MethodImpl]
    public extern void GetMath(out string value);

    /// <summary>Configures a RichEditBox to interpret input based on the specified math mode.</summary>
    /// <param name="mode">Specifies whether a RichEditBox interprets input as  (MathML ) or text.</param>
    [MethodImpl]
    public extern void SetMathMode(RichEditMathMode mode);

    /// <summary>Gets or sets the caret type.</summary>
    /// <returns>The caret type.</returns>
    public extern CaretType CaretType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the default tab spacing.</summary>
    /// <returns>The default tab spacing.</returns>
    public extern float DefaultTabStop { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the active text selection.</summary>
    /// <returns>The active text selection.</returns>
    public extern ITextSelection Selection { [MethodImpl] get; }

    /// <summary>Gets or sets the maximum number of actions that can be stored in the undo queue.</summary>
    /// <returns>The maximum number of undo actions.</returns>
    public extern uint UndoLimit { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Determines whether document content can be copied to the Clipboard.</summary>
    /// <returns>**true** if copying to the Clipboard is allowed; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool CanCopy();

    /// <summary>Determines whether the Clipboard has content that can be pasted into the document.</summary>
    /// <returns>**true** if the Clipboard has content that can be pasted into the document; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool CanPaste();

    /// <summary>Determines whether one or more redo operations exist.</summary>
    /// <returns>**true** if one or more redo operations exist; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool CanRedo();

    /// <summary>Determines whether one or more undo operations exist.</summary>
    /// <returns>**true** if one or more undo operations exist; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool CanUndo();

    /// <summary>Decrements an internal counter that controls whether text updates are displayed immediately or batched.</summary>
    /// <returns>The value of the internal counter.</returns>
    [MethodImpl]
    public extern int ApplyDisplayUpdates();

    /// <summary>Increments an internal counter that controls whether text updates are displayed immediately or batched.</summary>
    /// <returns>The value of the internal counter.</returns>
    [MethodImpl]
    public extern int BatchDisplayUpdates();

    /// <summary>Turns on undo grouping.</summary>
    [MethodImpl]
    public extern void BeginUndoGroup();

    /// <summary>Turns off undo grouping.</summary>
    [MethodImpl]
    public extern void EndUndoGroup();

    /// <summary>Retrieves the default character formatting attributes of the document.</summary>
    /// <returns>The default character formatting attributes.</returns>
    [MethodImpl]
    public extern ITextCharacterFormat GetDefaultCharacterFormat();

    /// <summary>Retrieves the default paragraph formatting attributes of the document.</summary>
    /// <returns>The default paragraph formatting attributes.</returns>
    [MethodImpl]
    public extern ITextParagraphFormat GetDefaultParagraphFormat();

    /// <summary>Retrieves a new text range for the active story of the document.</summary>
    /// <param name="startPosition">The starting position of the new text range, relative to the beginning of the story.</param>
    /// <param name="endPosition">The ending position of the new text range.</param>
    /// <returns>The new text range.</returns>
    [MethodImpl]
    public extern ITextRange GetRange(int startPosition, int endPosition);

    /// <summary>Retrieves the degenerate (empty) text range at, or nearest to, a particular point on the screen.</summary>
    /// <param name="point">The location of the point on the screen, in screen coordinates.</param>
    /// <param name="options">The alignment type of the specified *point*.</param>
    /// <returns>The new text range.</returns>
    [MethodImpl]
    public extern ITextRange GetRangeFromPoint(Point point, PointOptions options);

    /// <summary>Gets the text in the active story (document).</summary>
    /// <param name="options">The text retrieval options.</param>
    /// <param name="value">The text in the active story.</param>
    [MethodImpl]
    public extern void GetText(TextGetOptions options, out string value);

    /// <summary>Loads a document from a stream.</summary>
    /// <param name="options">The text options to use for the loading the document.</param>
    /// <param name="value">The random access stream that contains the document.</param>
    [MethodImpl]
    public extern void LoadFromStream(TextSetOptions options, IRandomAccessStream value);

    /// <summary>Reverses the most recent undo operation.</summary>
    [MethodImpl]
    public extern void Redo();

    /// <summary>Saves the document to a stream.</summary>
    /// <param name="options">The text options for saving the document.</param>
    /// <param name="value">The random access stream for saving the document.</param>
    [MethodImpl]
    public extern void SaveToStream(TextGetOptions options, IRandomAccessStream value);

    /// <summary>Sets the default character formatting attributes of the document.</summary>
    /// <param name="value">The new default character formatting attributes.</param>
    [MethodImpl]
    public extern void SetDefaultCharacterFormat(ITextCharacterFormat value);

    /// <summary>Sets the default paragraph formatting attributes of the document.</summary>
    /// <param name="value">The default paragraph formatting attributes.</param>
    [MethodImpl]
    public extern void SetDefaultParagraphFormat(ITextParagraphFormat value);

    /// <summary>Sets the text of the document.</summary>
    /// <param name="options">Options that control how the text is inserted into the document.</param>
    /// <param name="value">The new text.</param>
    [MethodImpl]
    public extern void SetText(TextSetOptions options, string value);

    /// <summary>Undoes the most recent undo group.</summary>
    [MethodImpl]
    public extern void Undo();
  }
}
