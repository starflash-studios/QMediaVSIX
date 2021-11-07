// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.ITextDocument
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Text
{
  /// <summary>Provides access to the content of a document, providing a way to load and save the document to a stream, retrieve text ranges, get the active selection, set default formatting attributes, and so on.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3203288539, 37042, 16524, 162, 246, 10, 10, 195, 30, 51, 228)]
  public interface ITextDocument
  {
    /// <summary>Gets or sets the caret type.</summary>
    /// <returns>The caret type.</returns>
    CaretType CaretType { get; set; }

    /// <summary>Gets or sets the default tab spacing.</summary>
    /// <returns>The new default tab spacing. The default value is 36.0 points, or 0.5 inches.</returns>
    float DefaultTabStop { get; set; }

    /// <summary>Gets the active text selection.</summary>
    /// <returns>The active text selection.</returns>
    ITextSelection Selection { get; }

    /// <summary>Gets or sets the maximum number of actions that can be stored in the undo queue.</summary>
    /// <returns>The maximum number of undo actions.</returns>
    uint UndoLimit { get; set; }

    /// <summary>Determines whether document content can be copied to the Clipboard.</summary>
    /// <returns>True if copying to the Clipboard is allowed; otherwise false.</returns>
    bool CanCopy();

    /// <summary>Determines whether the Clipboard has content that can be pasted into the document.</summary>
    /// <returns>True if the Clipboard has content that can be pasted into the document; otherwise false.</returns>
    bool CanPaste();

    /// <summary>Determines whether one or more redo operations exist.</summary>
    /// <returns>True if one or more redo operations exist; otherwise false.</returns>
    bool CanRedo();

    /// <summary>Determines whether one or more undo operations exist.</summary>
    /// <returns>True if one or more undo operations exist; otherwise false.</returns>
    bool CanUndo();

    /// <summary>Decrements an internal counter that controls whether text updates are displayed immediately or batched.</summary>
    /// <returns>The value of the internal counter.</returns>
    int ApplyDisplayUpdates();

    /// <summary>Increments an internal counter that controls whether text updates are displayed immediately or batched.</summary>
    /// <returns>The value of the internal counter.</returns>
    int BatchDisplayUpdates();

    /// <summary>Turns on undo grouping.</summary>
    void BeginUndoGroup();

    /// <summary>Turns off undo grouping.</summary>
    void EndUndoGroup();

    /// <summary>Retrieves the default character formatting attributes of the document.</summary>
    /// <returns>The default character formatting attributes.</returns>
    ITextCharacterFormat GetDefaultCharacterFormat();

    /// <summary>Retrieves the default paragraph formatting attributes of the document.</summary>
    /// <returns>The default paragraph formatting attributes.</returns>
    ITextParagraphFormat GetDefaultParagraphFormat();

    /// <summary>Retrieves a new text range for the active story of the document.</summary>
    /// <param name="startPosition">The starting position of the new text range, relative to the beginning of the story.</param>
    /// <param name="endPosition">The ending position of the new text range.</param>
    /// <returns>The new text range.</returns>
    ITextRange GetRange(int startPosition, int endPosition);

    /// <summary>Retrieves the degenerate (empty) text range at, or nearest to, a particular point on the screen.</summary>
    /// <param name="point">The location of the point on the screen, in screen coordinates.</param>
    /// <param name="options">The alignment type of the specified *point*.</param>
    /// <returns>The text range object.</returns>
    ITextRange GetRangeFromPoint(Point point, PointOptions options);

    /// <summary>Gets the text in the active story (document).</summary>
    /// <param name="options">The text retrieval options.</param>
    /// <param name="value">The text in the active story.</param>
    void GetText(TextGetOptions options, out string value);

    /// <summary>Loads a document from a stream.</summary>
    /// <param name="options">The text options to use for the loading the document.</param>
    /// <param name="value">The random access stream that contains the document.</param>
    void LoadFromStream(TextSetOptions options, IRandomAccessStream value);

    /// <summary>Reverses the most recent undo operation.</summary>
    void Redo();

    /// <summary>Saves the document to a stream.</summary>
    /// <param name="options">The text options for saving the document.</param>
    /// <param name="value">The random access stream for saving the document.</param>
    void SaveToStream(TextGetOptions options, IRandomAccessStream value);

    /// <summary>Sets the default character formatting attributes of the document.</summary>
    /// <param name="value">The new default character formatting attributes.</param>
    void SetDefaultCharacterFormat(ITextCharacterFormat value);

    /// <summary>Sets the default paragraph formatting attributes of the document.</summary>
    /// <param name="value">The default paragraph formatting attributes.</param>
    void SetDefaultParagraphFormat(ITextParagraphFormat value);

    /// <summary>Sets the text of the document.</summary>
    /// <param name="options">Options controlling how the text is inserted into the document.</param>
    /// <param name="value">The new text.</param>
    void SetText(TextSetOptions options, string value);

    /// <summary>Undoes the most recent undo group.</summary>
    void Undo();
  }
}
