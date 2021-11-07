// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Language
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  /// <summary>A class that provides information related to BCP-47 language tags such as the language name and the script.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (ILanguageStatics3), 655360, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (ILanguageFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ILanguageStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ILanguageStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Language : ILanguage, ILanguageExtensionSubtags, ILanguage2, ILanguage3
  {
    /// <summary>Creates a Language object.</summary>
    /// <param name="languageTag">A BCP-47 language tag. See Remarks for Language.</param>
    [MethodImpl]
    public extern Language(string languageTag);

    /// <summary>Gets the normalized BCP-47 language tag for this language.</summary>
    /// <returns>The normalized BCP-47 language tag.</returns>
    public extern string LanguageTag { [MethodImpl] get; }

    /// <summary>Gets a localized string that is suitable for display to the user for identifying the language.</summary>
    /// <returns>The localized name of the language.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the name of the language in the language itself.</summary>
    /// <returns>The name of the language in the language itself.</returns>
    public extern string NativeName { [MethodImpl] get; }

    /// <summary>Gets the four-letter ISO 15924 script code of the language.</summary>
    /// <returns>A string with the script code of the language. If the script code cannot be identified or inferred from the language tag, "Zyyy" is returned.</returns>
    public extern string Script { [MethodImpl] get; }

    /// <summary>Retrieves a vector of extension subtags in the current language for the given extension identified by singleton.</summary>
    /// <param name="singleton">A single-character subtag for the LanguageTag of the current language. See BCP-47 language tags, Extensions and the Extensions Registry.</param>
    /// <returns>The list of extension subtags identified by *singleton*.</returns>
    [MethodImpl]
    public extern IVectorView<string> GetExtensionSubtags(string singleton);

    /// <summary>Gets the content layout direction (for text and UI elements) most appropriate for a language.</summary>
    /// <returns>A layout direction.</returns>
    public extern LanguageLayoutDirection LayoutDirection { [MethodImpl] get; }

    /// <summary>Gets the three-letter abbreviation for a BCP-47 language tag. For example, "en-US" is converted to "eng".</summary>
    /// <returns>The three letter abbreviation.</returns>
    public extern string AbbreviatedName { [MethodImpl] get; }

    [MethodImpl]
    public static extern IVector<string> GetMuiCompatibleLanguageListFromLanguageTags(
      IIterable<string> languageTags);

    /// <summary>Tries to set the normalized BCP-47 language tag of this language.</summary>
    /// <param name="languageTag">The normalized BCP-47 language tag.</param>
    /// <returns>**true** if the value is successfully set, otherwise **false**.</returns>
    [MethodImpl]
    public static extern bool TrySetInputMethodLanguageTag(string languageTag);

    /// <summary>Determines whether a BCP-47 language tag is well-formed.</summary>
    /// <param name="languageTag">A BCP-47 language tag.</param>
    /// <returns>**True** if the language tag is well-formed as defined by BCP-47, except when the language tag can never be valid according to BCP-47. Otherwise it returns **false**. If this method returns **true**, an application can safely construct a language by using this tag. If it returns **false**, attempting to construct a language for the given tag will throw an exception.</returns>
    [MethodImpl]
    public static extern bool IsWellFormed(string languageTag);

    /// <summary>Gets the BCP-47 language tag for the currently enabled keyboard layout or Input Method Editor (IME).</summary>
    /// <returns>The BCP-47 language tag.</returns>
    public static extern string CurrentInputMethodLanguageTag { [MethodImpl] get; }
  }
}
