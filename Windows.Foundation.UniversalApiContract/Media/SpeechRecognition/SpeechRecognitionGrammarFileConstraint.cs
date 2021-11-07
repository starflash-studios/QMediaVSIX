// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognitionGrammarFileConstraint
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.SpeechRecognition
{
  /// <summary>A custom grammar constraint based on a list of words or phrases (defined in a Speech Recognition Grammar Specification (SRGS) file) that can be recognized by the SpeechRecognizer object.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ISpeechRecognitionGrammarFileConstraintFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SpeechRecognitionGrammarFileConstraint : 
    ISpeechRecognitionGrammarFileConstraint,
    ISpeechRecognitionConstraint
  {
    /// <summary>Creates an instance of the SpeechRecognitionGrammarFileConstraint class from a file object.</summary>
    /// <param name="file">An object representing a Speech Recognition Grammar Specification (SRGS) grammar file.</param>
    [MethodImpl]
    public extern SpeechRecognitionGrammarFileConstraint(StorageFile file);

    /// <summary>Creates an instance of the SpeechRecognitionGrammarFileConstraint class from a file object and a tag.</summary>
    /// <param name="file">An object representing a Speech Recognition Grammar Specification (SRGS) grammar file.</param>
    /// <param name="tag">The tag to assign to the constraint.</param>
    [MethodImpl]
    public extern SpeechRecognitionGrammarFileConstraint(StorageFile file, string tag);

    /// <summary>Gets the StorageFile object representing the Speech Recognition Grammar Specification (SRGS) grammar file.</summary>
    /// <returns>The object representing the Speech Recognition Grammar Specification (SRGS) grammar file.</returns>
    public extern StorageFile GrammarFile { [MethodImpl] get; }

    /// <summary>Gets or sets whether the constraint can be used by the speech recognizer to perform recognition.</summary>
    /// <returns>True if a speech recognizer can perform recognition using the constraint; otherwise false.</returns>
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a tag that can be useful for identifying the constraint.</summary>
    /// <returns>A string representing the tag.</returns>
    public extern string Tag { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the type of the constraint.</summary>
    /// <returns>An enumeration that indicates the type of the constraint. Always returns Grammar for SpeechRecognitionGrammarFileConstraint.</returns>
    public extern SpeechRecognitionConstraintType Type { [MethodImpl] get; }

    /// <summary>Gets or sets the weighted value of the constraint.</summary>
    /// <returns>An enumeration that indicates the weighted value of the constraint.</returns>
    public extern SpeechRecognitionConstraintProbability Probability { [MethodImpl] get; [MethodImpl] set; }
  }
}
