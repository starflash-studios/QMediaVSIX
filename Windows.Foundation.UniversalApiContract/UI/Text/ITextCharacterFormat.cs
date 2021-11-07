// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.ITextCharacterFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Defines the default character formatting attributes of a document, or the current character formatting attributes of a text range.</summary>
  [Guid(1524560859, 1531, 17453, 128, 101, 100, 42, 254, 160, 44, 237)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ITextCharacterFormat
  {
    /// <summary>Gets or sets whether the characters are all uppercase.</summary>
    /// <returns>The uppercase state.</returns>
    FormatEffect AllCaps { get; set; }

    /// <summary>Gets or sets the text background (highlight) color.</summary>
    /// <returns>The text background color.</returns>
    Color BackgroundColor { get; set; }

    /// <summary>Gets or sets whether the characters are bold.</summary>
    /// <returns>The bold state.</returns>
    FormatEffect Bold { get; set; }

    /// <summary>Gets or sets the degree to which the font is stretched, compared to the normal aspect ratio of the font.</summary>
    /// <returns>The degree to which the font is stretched.</returns>
    FontStretch FontStretch { get; set; }

    /// <summary>Gets or sets the style of the font face, such as normal or italic.</summary>
    /// <returns>The font style.</returns>
    FontStyle FontStyle { get; set; }

    /// <summary>Gets or sets the foreground, or text, color.</summary>
    /// <returns>The foreground color.</returns>
    Color ForegroundColor { get; set; }

    /// <summary>Gets or sets whether characters are hidden.</summary>
    /// <returns>The hidden state.</returns>
    FormatEffect Hidden { get; set; }

    /// <summary>Gets or sets whether characters are in italics.</summary>
    /// <returns>The italicized state.</returns>
    FormatEffect Italic { get; set; }

    /// <summary>Gets or sets the minimum font size at which kerning occurs.</summary>
    /// <returns>The kerning size, in floating-point points.</returns>
    float Kerning { get; set; }

    /// <summary>Gets or sets the Internet Engineering Task Force (IETF) language tag (BCP 47 standard) that identifies the language currently associated with the characters.</summary>
    /// <returns>The language tag.</returns>
    string LanguageTag { get; set; }

    /// <summary>Gets the link type of the text.</summary>
    /// <returns>The link type.</returns>
    LinkType LinkType { get; }

    /// <summary>Gets or sets the font name.</summary>
    /// <returns>The font name.</returns>
    string Name { get; set; }

    /// <summary>Gets or sets whether characters are displayed as outlined characters.</summary>
    /// <returns>The outlined state.</returns>
    FormatEffect Outline { get; set; }

    /// <summary>Gets or sets the character offset relative to the baseline.</summary>
    /// <returns>The character offset, in floating-point points.</returns>
    float Position { get; set; }

    /// <summary>Gets or sets whether the characters are protected against attempts to modify them.</summary>
    /// <returns>The protected state.</returns>
    FormatEffect ProtectedText { get; set; }

    /// <summary>Gets or sets the font size.</summary>
    /// <returns>The font size, in floating-point points.</returns>
    float Size { get; set; }

    /// <summary>Gets or sets whether characters are in small capital letters.</summary>
    /// <returns>The small capitals state.</returns>
    FormatEffect SmallCaps { get; set; }

    /// <summary>Gets or sets the amount of horizontal spacing between characters.</summary>
    /// <returns>The amount of horizontal spacing, in floating-point points.</returns>
    float Spacing { get; set; }

    /// <summary>Gets or sets whether characters are displayed with a horizontal line through the center.</summary>
    /// <returns>The strikethrough state.</returns>
    FormatEffect Strikethrough { get; set; }

    /// <summary>Gets or sets whether characters are displayed as subscript.</summary>
    /// <returns>The subscript state.</returns>
    FormatEffect Subscript { get; set; }

    /// <summary>Gets or sets whether characters are displayed as superscript.</summary>
    /// <returns>The superscript state.</returns>
    FormatEffect Superscript { get; set; }

    /// <summary>Gets or sets the character repertoire.</summary>
    /// <returns>The character repertoire.</returns>
    TextScript TextScript { get; set; }

    /// <summary>Gets or sets the type of underlining that the characters use.</summary>
    /// <returns>The type of underlining.</returns>
    UnderlineType Underline { get; set; }

    /// <summary>Gets or sets the font weight of the characters.</summary>
    /// <returns>The font weight expressed as a numeric value. See Remarks.</returns>
    int Weight { get; set; }

    /// <summary>Sets the character formatting by copying another text character formatting object.</summary>
    /// <param name="value">The character formatting to apply.</param>
    void SetClone(ITextCharacterFormat value);

    /// <summary>Creates a new object that is identical to this character format object.</summary>
    /// <returns>The duplicate character format object.</returns>
    ITextCharacterFormat GetClone();

    /// <summary>Determines whether this character format object has the same properties as the specified character format object.</summary>
    /// <param name="format">The character format object to compare against.</param>
    /// <returns>True if the objects have the same properties, or false if they don't.</returns>
    bool IsEqual(ITextCharacterFormat format);
  }
}
