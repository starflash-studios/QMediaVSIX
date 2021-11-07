// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.TextReverseConversionGenerator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  /// <summary>Reverse-converts a Japanese string which is mix of phonetic and ideographic characters, to a string of phonetic characters.</summary>
  [Activatable(typeof (ITextReverseConversionGeneratorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class TextReverseConversionGenerator : 
    ITextReverseConversionGenerator,
    ITextReverseConversionGenerator2
  {
    /// <summary>Constructs a TextReverseConversionGenerator object based on a specific BCP-47 language tag.</summary>
    /// <param name="languageTag">The BCP-47 language tag of the language in which the words are to be reverse-converted. Only Japanese ("ja") is supported.</param>
    [MethodImpl]
    public extern TextReverseConversionGenerator(string languageTag);

    /// <summary>Gets the language tag of the successfully created TextReverseConversionGenerator object.</summary>
    /// <returns>The BCP-47 language tag of the reverse conversion generator.</returns>
    public extern string ResolvedLanguage { [MethodImpl] get; }

    /// <summary>Determines if the language tag specified is available for reverse conversions, but is not installed on the user's device.</summary>
    /// <returns>**true** if the language is available but not installed.</returns>
    public extern bool LanguageAvailableButNotInstalled { [MethodImpl] get; }

    /// <summary>Asynchronously reverse-converts a string which contains ideographic characters to a phonetic expression.</summary>
    /// <param name="input">The string containing ideographic characters to be reverse-converted.</param>
    /// <returns>An asynchronous operation to return the phonetic expression.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> ConvertBackAsync(string input);

    /// <summary>Returns a set of phonemes representing the given input string. This method is primarily intended for use in sorting data in the Japanese language. Phonetic reading is important for Japanese data handling, especially to sort names in proper phonetic order rather than in character code point order.</summary>
    /// <param name="input">A string containing words in Japanese.</param>
    /// <returns>On successful completion of the async operation, a list of TextPhoneme objects representing the input string in phoneme form.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<TextPhoneme>> GetPhonemesAsync(
      string input);
  }
}
