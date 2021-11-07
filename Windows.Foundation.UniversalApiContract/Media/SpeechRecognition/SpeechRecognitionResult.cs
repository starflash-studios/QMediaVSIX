// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognitionResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  /// <summary>The result of a speech recognition session.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SpeechRecognitionResult : ISpeechRecognitionResult, ISpeechRecognitionResult2
  {
    /// <summary>Gets the result state (SpeechRecognitionResultStatus ) of a speech recognition session.</summary>
    /// <returns>The status of the result.</returns>
    public extern SpeechRecognitionResultStatus Status { [MethodImpl] get; }

    /// <summary>Gets the recognized phrase of the speech recognition session.</summary>
    /// <returns>The recognized phrase of the speech recognition session.</returns>
    public extern string Text { [MethodImpl] get; }

    /// <summary>Gets a value that indicates the confidence of the speech recognizer in the recognition result.</summary>
    /// <returns>The confidence level of the recognition result.</returns>
    public extern SpeechRecognitionConfidence Confidence { [MethodImpl] get; }

    /// <summary>Gets an interpretation object containing the semantic properties of a recognized phrase in a Speech Recognition Grammar Specification (SRGS) grammar.</summary>
    /// <returns>An interpretation object containing the semantic properties of a recognized phrase in a Speech Recognition Grammar Specification (SRGS) grammar.</returns>
    public extern SpeechRecognitionSemanticInterpretation SemanticInterpretation { [MethodImpl] get; }

    /// <summary>Gets a collection of recognition result alternatives, ordered by RawConfidence from most likely to least likely. The first item in the collection is the recognition result indicated by the parent object.</summary>
    /// <param name="maxAlternates">The maximum number of speech recognition results to return in the collection.</param>
    /// <returns>A collection of speech recognition results, ordered by confidence from most likely to least likely.</returns>
    [MethodImpl]
    public extern IVectorView<SpeechRecognitionResult> GetAlternates(
      uint maxAlternates);

    /// <summary>Gets the constraint used for the recognition result.</summary>
    /// <returns>The constraint used for the recognition result. Null for remote recognition using predefined grammars (SpeechRecognitionTopicConstraint ).</returns>
    public extern ISpeechRecognitionConstraint Constraint { [MethodImpl] get; }

    /// <summary>Gets the hierarchy of rule elements that were triggered to return the recognized phrase.</summary>
    /// <returns>An array that represents the hierarchy of rule elements that were triggered to return the recognized phrase. Each value in the array contains the value of the id attribute for a rule element. The order of values in the array corresponds to the order that the rules were triggered.</returns>
    public extern IVectorView<string> RulePath { [MethodImpl] get; }

    /// <summary>Gets a value that indicates the relative confidence of the SpeechRecognitionResult when compared with a collection of alternatives returned with the recognition result.</summary>
    /// <returns>The confidence level of the result.</returns>
    public extern double RawConfidence { [MethodImpl] get; }

    /// <summary>Gets the start time of the utterance.</summary>
    /// <returns>The start time of the utterance.</returns>
    public extern DateTime PhraseStartTime { [MethodImpl] get; }

    /// <summary>Gets the amount of time required for the utterance.</summary>
    /// <returns>The duration of the utterance.</returns>
    public extern TimeSpan PhraseDuration { [MethodImpl] get; }
  }
}
