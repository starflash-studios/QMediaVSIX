// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.AutomationTextAttributesEnum
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Defines constants that identify text attributes of a Microsoft UI Automation text range.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AutomationTextAttributesEnum
  {
    /// <summary>Identifies the **AnimationStyle** text attribute, which specifies the type of animation applied to the text. This attribute is specified as a value of the AutomationAnimationStyle enumeration.</summary>
    AnimationStyleAttribute = 40000, // 0x00009C40
    /// <summary>Identifies the **BackgroundColor** text attribute, which specifies the background color of the text.</summary>
    BackgroundColorAttribute = 40001, // 0x00009C41
    /// <summary>Identifies the **BulletStyle** text attribute, which specifies the style of bullets used in the text range. This attribute is specified as a value of the AutomationBulletStyle enumeration.</summary>
    BulletStyleAttribute = 40002, // 0x00009C42
    /// <summary>Identifies the **CapStyle** text attribute, which specifies the capitalization style for the text.</summary>
    CapStyleAttribute = 40003, // 0x00009C43
    /// <summary>Identifies the **Culture** text attribute, which specifies the locale of the text by locale identifier (LCID).</summary>
    CultureAttribute = 40004, // 0x00009C44
    /// <summary>Identifies the **FontName** text attribute, which specifies the name of the font. Examples: "Arial Black"; "Arial Narrow". The font name string is not localized.</summary>
    FontNameAttribute = 40005, // 0x00009C45
    /// <summary>Identifies the **FontSize** text attribute, which specifies the point size of the font.</summary>
    FontSizeAttribute = 40006, // 0x00009C46
    /// <summary>Identifies the **FontWeight** text attribute, which specifies the relative stroke, thickness, or boldness of the font.</summary>
    FontWeightAttribute = 40007, // 0x00009C47
    /// <summary>Identifies the **ForegroundColor** text attribute, which specifies the foreground color of the text.</summary>
    ForegroundColorAttribute = 40008, // 0x00009C48
    /// <summary>Identifies the **HorizontalTextAlignment** text attribute, which specifies how the text is aligned horizontally.</summary>
    HorizontalTextAlignmentAttribute = 40009, // 0x00009C49
    /// <summary>Identifies the **IndentationFirstLine** text attribute, which specifies how far, in points, to indent the first line of a paragraph.</summary>
    IndentationFirstLineAttribute = 40010, // 0x00009C4A
    /// <summary>Identifies the **IndentationLeading** text attribute, which specifies the leading indentation, in points.</summary>
    IndentationLeadingAttribute = 40011, // 0x00009C4B
    /// <summary>Identifies the **IndentationTrailing** text attribute, which specifies the trailing indentation, in points.</summary>
    IndentationTrailingAttribute = 40012, // 0x00009C4C
    /// <summary>Identifies the **IsHidden** text attribute, which indicates whether the text is hidden (**true**) or visible (**false**).</summary>
    IsHiddenAttribute = 40013, // 0x00009C4D
    /// <summary>Identifies the **IsItalic** text attribute, which indicates whether the text is italic (**true**) or not (**false**).</summary>
    IsItalicAttribute = 40014, // 0x00009C4E
    /// <summary>Identifies the **IsReadOnly** text attribute, which indicates whether the text is read-only (**true**) or can be modified (**false**).</summary>
    IsReadOnlyAttribute = 40015, // 0x00009C4F
    /// <summary>Identifies the **IsSubscript** text attribute, which indicates whether the text is subscript (**true**) or not (**false**).</summary>
    IsSubscriptAttribute = 40016, // 0x00009C50
    /// <summary>Identifies the **IsSuperscript** text attribute, which indicates whether the text is subscript (**true**) or not (**false**).</summary>
    IsSuperscriptAttribute = 40017, // 0x00009C51
    /// <summary>Identifies the **MarginBottom** text attribute, which specifies the size, in points, of the bottom margin applied to the page associated with the text range.</summary>
    MarginBottomAttribute = 40018, // 0x00009C52
    /// <summary>Identifies the **MarginLeading** text attribute, which specifies the size, in points, of the leading margin applied to the page associated with the text range.</summary>
    MarginLeadingAttribute = 40019, // 0x00009C53
    /// <summary>Identifies the **MarginTop** text attribute, which specifies the size, in points, of the top margin applied to the page associated with the text range.</summary>
    MarginTopAttribute = 40020, // 0x00009C54
    /// <summary>Identifies the **MarginTrailing** text attribute, which specifies the size, in points, of the trailing margin applied to the page associated with the text range.</summary>
    MarginTrailingAttribute = 40021, // 0x00009C55
    /// <summary>Identifies the **OutlineStyles** text attribute, which specifies the outline style of the text. This attribute is specified as a value of the AutomationOutlineStyles enumeration.</summary>
    OutlineStylesAttribute = 40022, // 0x00009C56
    /// <summary>Identifies the **OverlineColor** text attribute, which specifies the color of the overline text decoration.</summary>
    OverlineColorAttribute = 40023, // 0x00009C57
    /// <summary>Identifies the **OverlineStyle** text attribute, which specifies the style of the overline text decoration. This attribute is specified as a value of the AutomationTextDecorationLineStyle enumeration.</summary>
    OverlineStyleAttribute = 40024, // 0x00009C58
    /// <summary>Identifies the **StrikethroughColor** text attribute, which specifies the color of the strikethrough text decoration.</summary>
    StrikethroughColorAttribute = 40025, // 0x00009C59
    /// <summary>Identifies the **StrikethroughStyle** text attribute, which specifies the style of the strikethrough text decoration. This attribute is specified as a value of the AutomationTextDecorationLineStyle enumeration.</summary>
    StrikethroughStyleAttribute = 40026, // 0x00009C5A
    /// <summary>Identifies the **Tabs** text attribute, which is an array specifying the tab stops for the text range. Each array element specifies a distance, in points, from the leading margin.</summary>
    TabsAttribute = 40027, // 0x00009C5B
    /// <summary>Identifies the **TextFlowDirections** text attribute, which specifies the direction of text flow. This attribute is specified as a combination of values of the AutomationFlowDirections enumeration.</summary>
    TextFlowDirectionsAttribute = 40028, // 0x00009C5C
    /// <summary>Identifies the **UnderlineColor** text attribute, which specifies the color of the underline text decoration.</summary>
    UnderlineColorAttribute = 40029, // 0x00009C5D
    /// <summary>Identifies the **UnderlineStyle** text attribute, which specifies the style of the underline text decoration. This attribute is specified as a value of the AutomationTextDecorationLineStyle enumeration.</summary>
    UnderlineStyleAttribute = 40030, // 0x00009C5E
    /// <summary>Identifies the **AnnotationTypes** text attribute, which maintains a list of annotation type identifiers for a range of text. This attribute is specified as a value of the AnnotationType enumeration.</summary>
    AnnotationTypesAttribute = 40031, // 0x00009C5F
    /// <summary>Identifies the **AnnotationObjects** text attribute.</summary>
    AnnotationObjectsAttribute = 40032, // 0x00009C60
    /// <summary>Identifies the **StyleName** text attribute, which identifies the localized name of the text style in use for a text range.</summary>
    StyleNameAttribute = 40033, // 0x00009C61
    /// <summary>Identifies the **StyleId** text attribute, which indicates the text styles in use for a text range. This attribute is specified as a value of the AutomationStyleId enumeration.</summary>
    StyleIdAttribute = 40034, // 0x00009C62
    /// <summary>Identifies the **Link** text attribute, which contains the ITextRangeProvider interface of the text range that is the target of an internal link in a document.</summary>
    LinkAttribute = 40035, // 0x00009C63
    /// <summary>Identifies the **IsActive** text attribute, which indicates whether the control that contains the text range has the keyboard focus (**true**) or not (**false**).</summary>
    IsActiveAttribute = 40036, // 0x00009C64
    /// <summary>Identifies the **SelectionActiveEnd** text attribute, which indicates the location of the caret relative to a text range that represents the currently selected text. This attribute is specified as a value from the AutomationActiveEnd enumeration.</summary>
    SelectionActiveEndAttribute = 40037, // 0x00009C65
    /// <summary>Identifies the **CaretPosition** text attribute, which indicates whether the caret is at the beginning or the end of a line of text in the text range. This attribute is specified as a value of the AutomationCaretPosition enumeration.</summary>
    CaretPositionAttribute = 40038, // 0x00009C66
    /// <summary>Identifies the **CaretBidiMode** text attribute, which indicates the direction of text flow in the text range. This attribute is specified as a value of the AutomationCaretBidiMode enumeration.</summary>
    CaretBidiModeAttribute = 40039, // 0x00009C67
  }
}
