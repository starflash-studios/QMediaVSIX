// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.TextConversionGenerator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  /// <summary>Converts input phonetic characters into a collection of corresponding ideographic characters (Chinese characters).</summary>
  [Activatable(typeof (ITextConversionGeneratorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class TextConversionGenerator : ITextConversionGenerator
  {
    /// <summary>Constructs a TextConversionGenerator object based on a specific BCP-47 language tag.</summary>
    /// <param name="languageTag">The BCP-47 language tag of the language in which the words are to be projected. Japanese ("ja") and Simplified Chinese ("zh-Hans") are supported.</param>
    [MethodImpl]
    public extern TextConversionGenerator(string languageTag);

    /// <summary>Gets the language tag of the successfully created TextConversionGenerator object.</summary>
    /// <returns>The BCP-47 language tag of the conversion generator.</returns>
    public extern string ResolvedLanguage { [MethodImpl] get; }

    /// <summary>Determines if the language tag specified is available for conversions, but is not installed on the user's device.</summary>
    /// <returns>**true** if the language is available but not installed.</returns>
    public extern bool LanguageAvailableButNotInstalled { [MethodImpl] get; }

    /// <summary>Asynchronously gets a list of candidate words based on the provided phonetic characters.</summary>
    /// <param name="input">The phonetic characters of the words to be returned.</param>
    /// <returns>An asynchronous operation to return an [IVectorView](https://docs.microsoft.com/previous-versions/br224594(v=vs.85)) of the list of candidate words.</returns>
    [RemoteAsync]
    [Overload("GetCandidatesAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> GetCandidatesAsync(
      string input);

    /// <summary>Asynchronously gets a list of candidate words, up to a maximum count, based on the provided phonetic characters.</summary>
    /// <param name="input">The phonetic characters of the words to be returned.</param>
    /// <param name="maxCandidates">The maximum number of candidate words to return.</param>
    /// <returns>An asynchronous operation to return an [IVectorView](https://docs.microsoft.com/previous-versions/br224594(v=vs.85)) of the list of candidate words.</returns>
    [Overload("GetCandidatesWithMaxCountAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> GetCandidatesAsync(
      string input,
      uint maxCandidates);
  }
}
