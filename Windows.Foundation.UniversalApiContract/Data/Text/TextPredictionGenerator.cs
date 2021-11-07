// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.TextPredictionGenerator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Text.Core;

namespace Windows.Data.Text
{
  /// <summary>Predicts Japanese words based on a phonetic characters prefix.</summary>
  [Activatable(typeof (ITextPredictionGeneratorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class TextPredictionGenerator : ITextPredictionGenerator, ITextPredictionGenerator2
  {
    /// <summary>Constructs a TextPredictionGenerator object based on a specific BCP-47 language tag.</summary>
    /// <param name="languageTag">The BCP-47 language tag of the language in which the words are to be projected. Only Japanese ("ja") is supported.</param>
    [MethodImpl]
    public extern TextPredictionGenerator(string languageTag);

    /// <summary>Gets the language tag of the successfully created TextPredictionGenerator object.</summary>
    /// <returns>The BCP-47 language tag of the prediction generator.</returns>
    public extern string ResolvedLanguage { [MethodImpl] get; }

    /// <summary>Determines if the language tag specified is available for generating predictions, but is not installed on the user's device.</summary>
    /// <returns>**true** if the language is available but not installed.</returns>
    public extern bool LanguageAvailableButNotInstalled { [MethodImpl] get; }

    /// <summary>Asynchronously retrieves a list of candidate words based on the provided phonetic characters prefix.</summary>
    /// <param name="input">The beginning phonetic characters of the words to be returned.</param>
    /// <returns>An asynchronous operation object which, when it completes, contains an [IVectorView](https://docs.microsoft.com/previous-versions/br224594(v=vs.85)) of strings, which are the predicted words.</returns>
    [RemoteAsync]
    [Overload("GetCandidatesAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> GetCandidatesAsync(
      string input);

    /// <summary>Asynchronously retrieves a list of candidate words, up to a maximum count, based on the provided phonetic characters prefix.</summary>
    /// <param name="input">The beginning phonetic characters of the words to be returned.</param>
    /// <param name="maxCandidates">The maximum number of predicted words to return.</param>
    /// <returns>An asynchronous operation object which, when it completes, contains an [IVectorView](https://docs.microsoft.com/previous-versions/br224594(v=vs.85)) of strings, which are the predicted words.</returns>
    [RemoteAsync]
    [Overload("GetCandidatesWithMaxCountAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> GetCandidatesAsync(
      string input,
      uint maxCandidates);

    [RemoteAsync]
    [Overload("GetCandidatesWithParametersAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> GetCandidatesAsync(
      string input,
      uint maxCandidates,
      TextPredictionOptions predictionOptions,
      IIterable<string> previousStrings);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> GetNextWordCandidatesAsync(
      uint maxCandidates,
      IIterable<string> previousStrings);

    /// <summary>Gets or sets the input scope for text prediction.</summary>
    /// <returns>A CoreTextInputScope value.</returns>
    public extern CoreTextInputScope InputScope { [MethodImpl] get; [MethodImpl] set; }
  }
}
