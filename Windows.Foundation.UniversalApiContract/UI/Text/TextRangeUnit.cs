// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.TextRangeUnit
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Specifies the units to use when navigating a text range.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TextRangeUnit
  {
    /// <summary>A single character.</summary>
    Character,
    /// <summary>A span of alphanumeric characters, an end of paragraph, or punctuation that includes any blanks that follow.</summary>
    Word,
    /// <summary>A string of text that meets the following criteria:</summary>
    Sentence,
    /// <summary>A string of text terminated by an end-of-paragraph mark, such as carriage return/line feed (CR/LF), carriage return (CR), vertical tab(VT), line feed (LF), form feed (FF), or the Unicode paragraph separator (0x2029).</summary>
    Paragraph,
    /// <summary>A single line of text on a display, provided that the display is associated with the range. If no display is associated with a range, **Line** is treated as **Paragraph**. A selection automatically has a display.</summary>
    Line,
    /// <summary>A story, which is a contiguous range of text in a document. For example, a story can contain one of the various parts of a document, such as the main text of a document, headers and footers, footnotes, or annotations. In a rich edit control, there is only one story per document, although a client can use multiple documents to represent multiple stories.</summary>
    Story,
    /// <summary>The contents of a screen. Typically, a screen is the amount of content associated with the Page Up or Page Down key.</summary>
    Screen,
    /// <summary>A section.</summary>
    Section,
    /// <summary>The characters between the upper-left and lower-right corners of the window.</summary>
    Window,
    /// <summary>A text run of characters that all have identical character formatting properties.</summary>
    CharacterFormat,
    /// <summary>A text run of characters that all have identical paragraph formatting properties.</summary>
    ParagraphFormat,
    /// <summary>An embedded object.</summary>
    Object,
    /// <summary>A paragraph that is ended by a carriage return (CR) or carriage return/line feed (CR/LF).</summary>
    HardParagraph,
    /// <summary>A complex-script cluster (occurs, for example, in Indic scripts).</summary>
    Cluster,
    /// <summary>Bold text.</summary>
    Bold,
    /// <summary>Italic text.</summary>
    Italic,
    /// <summary>Underlined text.</summary>
    Underline,
    /// <summary>Strikethrough text.</summary>
    Strikethrough,
    /// <summary>Protected text.</summary>
    ProtectedText,
    /// <summary>Hyperlink text.</summary>
    Link,
    /// <summary>Text in small caps.</summary>
    SmallCaps,
    /// <summary>Text in all uppercase.</summary>
    AllCaps,
    /// <summary>Hidden text.</summary>
    Hidden,
    /// <summary>Outline text.</summary>
    Outline,
    /// <summary>Shadow text.</summary>
    Shadow,
    /// <summary>Imprinted (engraved) text.</summary>
    Imprint,
    /// <summary>Disabled text.</summary>
    Disabled,
    /// <summary>Revised text.</summary>
    Revised,
    /// <summary>Text in the subscript character format.</summary>
    Subscript,
    /// <summary>Text in the superscript character format.</summary>
    Superscript,
    /// <summary>Text is in a font-bound font. That is, characters that can't be displayed with the current font were assigned a different font that could display the characters.</summary>
    FontBound,
    /// <summary>Characters in one or more contiguous, friendly-name hyperlinks. To work with single links that might be adjacent, use the **Link** unit.</summary>
    LinkProtected,
    /// <summary>ContentLink text.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] ContentLink,
  }
}
