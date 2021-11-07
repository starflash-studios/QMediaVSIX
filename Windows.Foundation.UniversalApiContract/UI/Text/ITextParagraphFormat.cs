// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.ITextParagraphFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Defines the default paragraph formatting attributes of a document, or the current paragraph formatting attributes of a text range.</summary>
  [WebHostHidden]
  [Guid(754503590, 18038, 18826, 147, 245, 187, 219, 252, 11, 216, 131)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ITextParagraphFormat
  {
    /// <summary>Gets or sets the paragraph alignment.</summary>
    /// <returns>The paragraph alignment value.</returns>
    ParagraphAlignment Alignment { get; set; }

    /// <summary>Gets the amount used to indent the first line of a paragraph relative to the left indent.</summary>
    /// <returns>The first line indentation amount, in floating-point points.</returns>
    float FirstLineIndent { get; }

    /// <summary>Gets or sets whether page breaks are allowed in paragraphs.</summary>
    /// <returns>A value that indicates whether page breaks are allowed.</returns>
    FormatEffect KeepTogether { get; set; }

    /// <summary>Gets or sets whether page breaks are allowed between paragraphs in a range.</summary>
    /// <returns>The value that indicates whether page breaks are allowed.</returns>
    FormatEffect KeepWithNext { get; set; }

    /// <summary>Gets the amount used to indent all lines except the first line of a paragraph.</summary>
    /// <returns>The amount of left indentation, in floating-point points. Indentation is relative to the left margin.</returns>
    float LeftIndent { get; }

    /// <summary>Gets the paragraph line-spacing value.</summary>
    /// <returns>The line spacing value. The meaning depends on the value of the LineSpacingRule property. The line spacing value is in floating-point points except when the line-spacing rule is **Multiple** or **Percent**.</returns>
    float LineSpacing { get; }

    /// <summary>Gets the paragraph line-spacing rule.</summary>
    /// <returns>The paragraph line-spacing rule.</returns>
    LineSpacingRule LineSpacingRule { get; }

    /// <summary>Gets or sets the alignment to use for bulleted and numbered lists.</summary>
    /// <returns>The alignment for bulleted and numbered lists.</returns>
    MarkerAlignment ListAlignment { get; set; }

    /// <summary>Gets or sets the list level index used with paragraphs.</summary>
    /// <returns>The list level index. It can be a value of 0 or higher, as described in the following table. &lt;table&gt;</returns>
    int ListLevelIndex { get; set; }

    /// <summary>Gets or sets the starting value or code of a list numbering sequence.</summary>
    /// <returns>The starting value or code of a list numbering sequence.</returns>
    int ListStart { get; set; }

    /// <summary>Gets or sets the style used to mark the item paragraphs in a list.</summary>
    /// <returns>The style used to mark the item paragraphs.</returns>
    MarkerStyle ListStyle { get; set; }

    /// <summary>Gets or sets the list tab setting, which is the distance between the first indent and the start of the text on the first line.</summary>
    /// <returns>The list tab setting.</returns>
    float ListTab { get; set; }

    /// <summary>Gets or sets the kind of characters used to mark the item paragraphs in a list.</summary>
    /// <returns>The kind of characters used to mark the item paragraphs.</returns>
    MarkerType ListType { get; set; }

    /// <summary>Gets or sets whether paragraph numbering is suppressed.</summary>
    /// <returns>A value that indicates whether line numbering is suppressed.</returns>
    FormatEffect NoLineNumber { get; set; }

    /// <summary>Gets or sets whether there is a page break before a paragraph.</summary>
    /// <returns>A value that indicates whether there is page break.</returns>
    FormatEffect PageBreakBefore { get; set; }

    /// <summary>Gets or sets the right margin of a paragraph.</summary>
    /// <returns>The size of the right margin, in floating-point points.</returns>
    float RightIndent { get; set; }

    /// <summary>Gets or sets whether the paragraph uses right-to-left formatting.</summary>
    /// <returns>A value that indicates whether the paragraph uses right-to-left formatting.</returns>
    FormatEffect RightToLeft { get; set; }

    /// <summary>Gets or sets the paragraph style.</summary>
    /// <returns>The paragraph style.</returns>
    ParagraphStyle Style { get; set; }

    /// <summary>Gets or sets the amount of vertical space that follows a paragraph.</summary>
    /// <returns>The amount of vertical space, in floating-point points.</returns>
    float SpaceAfter { get; set; }

    /// <summary>Gets or sets the amount of vertical space above a paragraph.</summary>
    /// <returns>The amount of vertical space, in floating-point points.</returns>
    float SpaceBefore { get; set; }

    /// <summary>Gets or sets whether widow and orphan suppression is on or off.</summary>
    /// <returns>The state of widow and orphan suppression.</returns>
    FormatEffect WidowControl { get; set; }

    /// <summary>Retrieves the tab count.</summary>
    /// <returns>The tab count.</returns>
    int TabCount { get; }

    /// <summary>Adds a new tab at the specified position.</summary>
    /// <param name="position">The position of the new tab, in floating-point points relative to the left side of the page for left-to-right paragraphs, or the right side of the page for right-to-left paragraphs. A maximum of 63 tabs are allowed. Tabs beyond the page are ignored. Negative tabs are not valid.</param>
    /// <param name="align">The alignment option for the tab position.</param>
    /// <param name="leader">The character used to fill the space taken by a tab character.</param>
    void AddTab(float position, TabAlignment align, TabLeader leader);

    /// <summary>Clears all tabs, reverting to equally spaced tabs with the default tab spacing.</summary>
    void ClearAllTabs();

    /// <summary>Deletes the tab at the specified position.</summary>
    /// <param name="position">The position of the tab to delete, in floating-point points.</param>
    void DeleteTab(float position);

    /// <summary>Creates a new object that is identical to this paragraph format object.</summary>
    /// <returns>The duplicate paragraph format object.</returns>
    ITextParagraphFormat GetClone();

    /// <summary>Retrieves information about the specified tab.</summary>
    /// <param name="index">The zero-based index of the tab to retrieve.</param>
    /// <param name="position">The tab's position, in floating-point points. This parameter is zero if the tab does not exist.</param>
    /// <param name="align">The alignment option for the tab position.</param>
    /// <param name="leader">The character used to fill the space taken by a tab character.</param>
    void GetTab(int index, out float position, out TabAlignment align, out TabLeader leader);

    /// <summary>Determines whether this paragraph format object has the same properties as the specified paragraph format object.</summary>
    /// <param name="format">The paragraph format object to compare against.</param>
    /// <returns>True if the objects have the same properties, or false if they don't.</returns>
    bool IsEqual(ITextParagraphFormat format);

    /// <summary>Sets the paragraph formatting by copying another paragraph formatting object.</summary>
    /// <param name="format">The paragraph formatting to apply.</param>
    void SetClone(ITextParagraphFormat format);

    /// <summary>Sets the first-line indent, the left indent, and the right indent for a paragraph.</summary>
    /// <param name="start">The indent of the first line in a paragraph, relative to the left indent. The value is in floating-point points and can be positive or negative.</param>
    /// <param name="left">The left indent of all lines except the first line in a paragraph, relative to the left margin. The value is in floating-point points and can be positive or negative.</param>
    /// <param name="right">The right indent of all lines in a paragraph, relative to the right margin. The value is in floating-point points and can be positive or negative. This value is optional.</param>
    void SetIndents(float start, float left, float right);

    /// <summary>Sets the paragraph line-spacing rule and the amount of line spacing for a paragraph.</summary>
    /// <param name="rule">The new line-spacing rule.</param>
    /// <param name="spacing">The new line spacing amount. If the line-spacing *rule* interprets the *spacing* value as a linear dimension, *spacing* is given in floating-point points.</param>
    void SetLineSpacing(LineSpacingRule rule, float spacing);
  }
}
