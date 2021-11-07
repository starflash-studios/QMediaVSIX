// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.RichEditTextRange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Text
{
  /// <summary>Represents a span of continuous text in a RichEditTextDocument, and provides editing and data-binding properties and methods that allow an app to select, examine, and change document content.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class RichEditTextRange : IRichEditTextRange, ITextRange
  {
    /// <summary>Gets or sets the content link information for this text range.</summary>
    /// <returns>The content link information for this text range.</returns>
    public extern ContentLinkInfo ContentLinkInfo { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the first character of the text range; that is, the character associated with the StartPosition property.</summary>
    /// <returns>The value of the first character in the text range.</returns>
    public extern char Character { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the character formatting attributes of the text range.</summary>
    /// <returns>The character formatting attributes.</returns>
    public extern ITextCharacterFormat CharacterFormat { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an ITextRange object with the formatted text of the specified range.</summary>
    /// <returns>The formatted text.</returns>
    public extern ITextRange FormattedText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the end character position of the text range.</summary>
    /// <returns>The end character position.</returns>
    public extern int EndPosition { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the gravity of the text range.</summary>
    /// <returns>The gravity of the text range.</returns>
    public extern RangeGravity Gravity { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the count of characters in the text range.</summary>
    /// <returns>The count of characters.</returns>
    public extern int Length { [MethodImpl] get; }

    /// <summary>Gets or sets the URL text associated with a text range.</summary>
    /// <returns>The URL as text.</returns>
    public extern string Link { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the paragraph formatting attributes of the text range.</summary>
    /// <returns>The paragraph formatting attributes.</returns>
    public extern ITextParagraphFormat ParagraphFormat { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the start position of the text range.</summary>
    /// <returns>The character position to set as the start position of the text range.</returns>
    public extern int StartPosition { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the count of characters in the story of the text range.</summary>
    /// <returns>The count of characters in the story.</returns>
    public extern int StoryLength { [MethodImpl] get; }

    /// <summary>Gets or sets the plain text of the text range.</summary>
    /// <returns>The plain text.</returns>
    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Determines whether the Clipboard contains content that can be pasted, using a specified format, into the current text range.</summary>
    /// <param name="format">The clipboard format. Zero represents the best format, which usually is Rich Text Format (RTF), but CF_UNICODETEXT and other formats are also possible. The default value is zero.</param>
    /// <returns>**true** if the Clipboard content can be pasted into the text range in the specified format; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool CanPaste(int format);

    /// <summary>Changes the case of letters in a text range.</summary>
    /// <param name="value">The new case of letters in the text range. The default value is **Lower**.</param>
    [MethodImpl]
    public extern void ChangeCase(LetterCase value);

    /// <summary>Collapses the text range into a degenerate point at either the beginning or end of the range.</summary>
    /// <param name="value">**true** to collapse at the start of the text range. **false** to collapse at the end of the range. The default is **true**.</param>
    [MethodImpl]
    public extern void Collapse(bool value);

    /// <summary>Copies the text of the text range to the Clipboard.</summary>
    [MethodImpl]
    public extern void Copy();

    /// <summary>Moves the text of the text range to the Clipboard.</summary>
    [MethodImpl]
    public extern void Cut();

    /// <summary>Deletes text from the text range.</summary>
    /// <param name="unit">The unit of text to delete.</param>
    /// <param name="count">The number of _unit_s to delete.</param>
    /// <returns>The number of _unit_s deleted. Deleting the text in a nondegenerate text range counts as one _unit_.</returns>
    [MethodImpl]
    public extern int Delete(TextRangeUnit unit, int count);

    /// <summary>Moves or extends the text range to the end of the nearest specified text unit. The text range is moved or extended forward in the document.</summary>
    /// <param name="unit">The unit by which to move the end position of the text range.</param>
    /// <param name="extend">**true** to extend the text range by moving just the end position of the range to the end of the specified unit. **false** to move both ends of the text range to the end of the specified unit. The default is **false**.</param>
    /// <returns>The number of character positions that the range was moved or extended, plus 1 if the text range collapsed to the start of the range. If the text range includes the final carriage return (CR) at the end of the story, and extend is false, the return value is set to –1 to indicate that the collapse occurred before the end of the range. This is because an insertion point cannot exist beyond the final CR.</returns>
    [MethodImpl]
    public extern int EndOf(TextRangeUnit unit, bool extend);

    /// <summary>Expands a text range to completely contain any partial text units.</summary>
    /// <param name="unit">The text unit to use to expand the range. The default value is **Word**.</param>
    /// <returns>The number of characters added to the text range, if the range was expanded to include a partially contained _unit_.</returns>
    [MethodImpl]
    public extern int Expand(TextRangeUnit unit);

    /// <summary>Searches for a particular text string in a range and, if found, selects the string.</summary>
    /// <param name="value">The text string to search for.</param>
    /// <param name="scanLength">The maximum number of characters to search. It can be one of the following.</param>
    /// <param name="options">The options to use when doing the text search.</param>
    /// <returns>The length of the matching text string, or zero if no matching string is found.</returns>
    [MethodImpl]
    public extern int FindText(string value, int scanLength, FindOptions options);

    /// <summary>Retrieves the Unicode Transformation Format (UTF)-32 character code of the character at the specified offset from the end of the text range.</summary>
    /// <param name="value">The character value.</param>
    /// <param name="offset">The offset from the end of the text range.</param>
    [MethodImpl]
    public extern void GetCharacterUtf32(out uint value, int offset);

    /// <summary>Creates a new object that is identical to this text range object.</summary>
    /// <returns>The duplicate text range object.</returns>
    [MethodImpl]
    public extern ITextRange GetClone();

    /// <summary>Retrieves the story index of the text unit (word, line, sentence, paragraph, and so on) at the starting character position of the text range.</summary>
    /// <param name="unit">The text unit that is indexed.</param>
    /// <returns>The index value. The value is zero if unit does not exist.</returns>
    [MethodImpl]
    public extern int GetIndex(TextRangeUnit unit);

    /// <summary>Retrieves the screen coordinates of a particular location in the text range.</summary>
    /// <param name="horizontalAlign">The horizontal position to retrieve, relative to the bounding rectangle of the text range.</param>
    /// <param name="verticalAlign">The vertical position to retrieve, relative to the bounding rectangle of the text range.</param>
    /// <param name="options">The options for retrieving the coordinates of the specified location in the text range.</param>
    /// <param name="point">A structure that receives the coordinates of the specified location in the text range, represented as an ordered pair of floating-point x- and y-coordinates that define a point in a two-dimensional plane.</param>
    [MethodImpl]
    public extern void GetPoint(
      HorizontalCharacterAlignment horizontalAlign,
      VerticalCharacterAlignment verticalAlign,
      PointOptions options,
      out Point point);

    /// <summary>Retrieves the bounding rectangle that encompasses the text range on the screen.</summary>
    /// <param name="options">A value that indicates the rectangle to retrieve.</param>
    /// <param name="rect">A structure that contains four floating-point numbers that represent the location and size of the bounding rectangle.</param>
    /// <param name="hit">The hit-test value for the text range.</param>
    [MethodImpl]
    public extern void GetRect(PointOptions options, out Rect rect, out int hit);

    /// <summary>Retrieves the text in a text range according to the specified conversion flags.</summary>
    /// <param name="options">The conversion flags that control how the text is retrieved.</param>
    /// <param name="value">The text in the text range.</param>
    [MethodImpl]
    public extern void GetText(TextGetOptions options, out string value);

    /// <summary>Retrieves the text in the text range according to the specified conversion flags, as a random access stream.</summary>
    /// <param name="options">The conversion flags that control how the text is retrieved. A value of default retrieves the plain text in the text range.</param>
    /// <param name="value">The text stream.</param>
    [MethodImpl]
    public extern void GetTextViaStream(TextGetOptions options, IRandomAccessStream value);

    /// <summary>Determines whether this range is in or at the same text as a specified range.</summary>
    /// <param name="range">Text that is compared to the current range.</param>
    /// <returns>The comparison result. The result can be **null**. The method returns **true** if the range is in or at the same text as ITextRange; otherwise, it returns **false**.</returns>
    [MethodImpl]
    public extern bool InRange(ITextRange range);

    /// <summary>Inserts an image into this range.</summary>
    /// <param name="width">The width of the image, in Device-independent pixels (DIPs).</param>
    /// <param name="height">The height of the image, in DIPs.</param>
    /// <param name="ascent">If _verticalAlign_ is **Baseline**, this parameter is the distance, in DIPs, that the top of the image extends above the text baseline. If _verticalAlign_ is **Baseline** and ascent is zero, the bottom of the image is placed at the text baseline.</param>
    /// <param name="verticalAlign">The vertical alignment of the image.</param>
    /// <param name="alternateText">The alternate text for the image.</param>
    /// <param name="value">The stream that contains the image data.</param>
    [MethodImpl]
    public extern void InsertImage(
      int width,
      int height,
      int ascent,
      VerticalCharacterAlignment verticalAlign,
      string alternateText,
      IRandomAccessStream value);

    /// <summary>Determines whether this range's story is the same as a specified range's story.</summary>
    /// <param name="range">The ITextRange object whose story is compared to this range's story.</param>
    /// <returns>The comparison result. The result can be **null**. The method returns **true** if this range's story is the same as that of the ITextRange; otherwise it returns **false**.</returns>
    [MethodImpl]
    public extern bool InStory(ITextRange range);

    /// <summary>Determines whether this range has the same character positions and story as those of a specified range.</summary>
    /// <param name="range">The text range to compare to this text range.</param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern bool IsEqual(ITextRange range);

    /// <summary>Moves the insertion point forward or backward by the specified number of _unit_s. If the text range is nondegenerate, it is collapsed to an insertion point at the start or end position of the text range, depending on _count_, and then is moved.</summary>
    /// <param name="unit">The units to move the insertion point. The default value is **Character**.</param>
    /// <param name="count">The number of _unit_s to move the insertion point. The default value is 1. If _count_ is greater than zero, the insertion point moves forward, toward the end of the story. If _count_ is less than zero, the insertion point moves backward, toward the beginning of the story. If _count_ is zero, the range is unchanged.</param>
    /// <returns>The actual number of units the insertion point moves.</returns>
    [MethodImpl]
    public extern int Move(TextRangeUnit unit, int count);

    /// <summary>Moves the end position of the text range.</summary>
    /// <param name="unit">The unit by which to move the end position of the text range. The default value is Character.</param>
    /// <param name="count">The number of _unit_s to move the end position of the text range. The default value is 1. If _count_ is greater than zero, the end position moves forward, toward the end of the story. If _count_ is less than zero, the end position move backward, toward the beginning of the story. If _count_ is zero, the end position does not move.</param>
    /// <returns>The actual number of _unit_s that the end position of the text range moved.</returns>
    [MethodImpl]
    public extern int MoveEnd(TextRangeUnit unit, int count);

    /// <summary>Moves the start position of a text range.</summary>
    /// <param name="unit">The unit by which to move the start position of the text range. The default value is **Character**.</param>
    /// <param name="count">The number of _unit_s to move the start position of the text range. The default value is 1. If _count_ is greater than zero, the start position of the text range moves forward, toward the end of the story. If _count_ is less than zero, the start position of the text range moves backward, toward the beginning of the story. If _count_ is zero, the start position doesn't move.</param>
    /// <returns>The actual number of _unit_s that the start position moved. The pointer can be **null**.</returns>
    [MethodImpl]
    public extern int MoveStart(TextRangeUnit unit, int count);

    /// <summary>Pastes text from the Clipboard into the text range.</summary>
    /// <param name="format">The clipboard format to use in the paste operation. Zero represents the best format, which usually is Rich Text Format (RTF), but CF_UNICODETEXT and other formats are also possible. The default value is zero.</param>
    [MethodImpl]
    public extern void Paste(int format);

    /// <summary>Scrolls this text range into view.</summary>
    /// <param name="value">The end of the text range to scroll into view. This function uses only the **Start**, **NoHorizontalScroll**, and **NoVerticalScroll** values of the PointOptions enumeration.</param>
    [MethodImpl]
    public extern void ScrollIntoView(PointOptions value);

    /// <summary>Sets the start and end positions of this range to match the active selection.</summary>
    [MethodImpl]
    public extern void MatchSelection();

    /// <summary>Moves the text range to the specified unit of the story.</summary>
    /// <param name="unit">The unit used to move the text range.</param>
    /// <param name="index">The index of the specified unit. The text range is relocated to the unit that has this index. If unit is positive, the numbering of units begins at the start of the story and proceeds forward. If negative, the numbering begins at the end of the story and proceeds backward. The start of the story corresponds to index = 1 for all existing units, and the last unit in the story corresponds to index = – 1.</param>
    /// <param name="extend">Indicates how to change the text range. True extends the text range to include the unit by moving only the end position of the text range. False collapses the text range to an insertion point and then moves the insertion point. The default value is false.</param>
    [MethodImpl]
    public extern void SetIndex(TextRangeUnit unit, int index, bool extend);

    /// <summary>Changes the text range based on the specified point.</summary>
    /// <param name="point">An ordered pair of floating-point x- and y-coordinates that defines a point in a two-dimensional plane.</param>
    /// <param name="options">The alignment type of the specified _point_.</param>
    /// <param name="extend">Indicates how to set the endpoints of the text range. If extend is 0, the text range is an insertion point located at the specified point, or at the nearest point with selectable text. If extend is 1, the endpoint specified by options is moved to the point and the other endpoint is left alone. The default is 0.</param>
    [MethodImpl]
    public extern void SetPoint(Point point, PointOptions options, bool extend);

    /// <summary>Sets the endpoints of the text range to the specified values.</summary>
    /// <param name="startPosition">The character position for the start of the text range. This parameter must be less than _endPosition_.</param>
    /// <param name="endPosition">The character position for the end of the text range.</param>
    [MethodImpl]
    public extern void SetRange(int startPosition, int endPosition);

    /// <summary>Replaces the text in the text range.</summary>
    /// <param name="options">The conversion flags that control how the text is inserted in the text range.</param>
    /// <param name="value">The new text.</param>
    [MethodImpl]
    public extern void SetText(TextSetOptions options, string value);

    /// <summary>Sets the text in the text range based on the contents of a random access stream.</summary>
    /// <param name="options">The text options.</param>
    /// <param name="value">The random access stream.</param>
    [MethodImpl]
    public extern void SetTextViaStream(TextSetOptions options, IRandomAccessStream value);

    /// <summary>Moves or extends the text range to the start of the nearest specified text unit. The text range is moved or extended backward in the document.</summary>
    /// <param name="unit">The unit by which to move the start position of the text range. The default value is **Word**.</param>
    /// <param name="extend">**true** to extend the text range by moving just the start position of the range to the start of the specified unit. **false** to move both ends of the text range to the start of the specified unit. The default is **false**.</param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern int StartOf(TextRangeUnit unit, bool extend);
  }
}
