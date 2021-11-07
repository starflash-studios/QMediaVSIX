// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Fonts.LanguageFontGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.Fonts
{
  /// <summary>Supplies a set of font recommendations for a given language or script for various usage cases.</summary>
  [DualApiPartition(version = 100794368)]
  [Activatable(typeof (ILanguageFontGroupFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.MTA)]
  public sealed class LanguageFontGroup : ILanguageFontGroup
  {
    /// <summary>Creates a LanguageFontGroup object for a given language or script.</summary>
    /// <param name="languageTag">A BCP-47 language tag, or an ISO 15924 script identifier.</param>
    [MethodImpl]
    public extern LanguageFontGroup(string languageTag);

    /// <summary>Gets a font that is recommended for typical UI body text.</summary>
    /// <returns>The recommended LanguageFont.</returns>
    public extern LanguageFont UITextFont { [MethodImpl] get; }

    /// <summary>Gets a font that is recommended for special UI elements, such as headings, that are displayed at sizes somewhat larger than typical UI body text.</summary>
    /// <returns>The recommended LanguageFont.</returns>
    public extern LanguageFont UIHeadingFont { [MethodImpl] get; }

    /// <summary>Gets a font that is recommended for special UI elements set at sizes much larger than typical UI body text.</summary>
    /// <returns>The recommended LanguageFont.</returns>
    public extern LanguageFont UITitleFont { [MethodImpl] get; }

    /// <summary>Gets a font that is recommended for special UI elements, such as captions, that are displayed at sizes smaller than typical UI body text.</summary>
    /// <returns>The recommended LanguageFont.</returns>
    public extern LanguageFont UICaptionFont { [MethodImpl] get; }

    /// <summary>Gets a font that is recommended for special UI elements, such as headings in notifications or other app messages, that are displayed at UI  body text size or only slightly larger yet need to be differentiated from UI body text.</summary>
    /// <returns>The recommended LanguageFont.</returns>
    public extern LanguageFont UINotificationHeadingFont { [MethodImpl] get; }

    /// <summary>Gets a font that is recommended for typical document body text following traditional style conventions.</summary>
    /// <returns>The recommended LanguageFont.</returns>
    public extern LanguageFont TraditionalDocumentFont { [MethodImpl] get; }

    /// <summary>Gets a font that is recommended for typical document body text following modern style conventions.</summary>
    /// <returns>The recommended LanguageFont.</returns>
    public extern LanguageFont ModernDocumentFont { [MethodImpl] get; }

    /// <summary>Gets a font that is recommended for use in document headings.</summary>
    /// <returns>The recommended LanguageFont.</returns>
    public extern LanguageFont DocumentHeadingFont { [MethodImpl] get; }

    /// <summary>Gets a font that is recommended for displaying fixed-width characters.</summary>
    /// <returns>The recommended LanguageFont, or **NULL** if no font recommendation is available.</returns>
    public extern LanguageFont FixedWidthTextFont { [MethodImpl] get; }

    /// <summary>Gets a font that is recommended as an additional option for use in documents beyond the recommendations provided by DocumentHeadingFont, ModernDocumentFont and TraditionalDocumentFont.</summary>
    /// <returns>The recommended LanguageFont, or **NULL** if no font recommendation is available.</returns>
    public extern LanguageFont DocumentAlternate1Font { [MethodImpl] get; }

    /// <summary>Gets a font that is recommended as an additional option for use in documents beyond the recommendations provided by DocumentHeadingFont, ModernDocumentFont and TraditionalDocumentFont.</summary>
    /// <returns>The recommended LanguageFont, or **NULL** if no font recommendation is available.</returns>
    public extern LanguageFont DocumentAlternate2Font { [MethodImpl] get; }
  }
}
