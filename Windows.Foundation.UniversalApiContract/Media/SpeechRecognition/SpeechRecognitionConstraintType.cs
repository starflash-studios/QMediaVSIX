// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognitionConstraintType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  /// <summary>Specifies the grammar definition constraint used for speech recognition.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SpeechRecognitionConstraintType
  {
    /// <summary>A pre-defined, web-service grammar constraint based on a dictation topic. See SpeechRecognitionTopicConstraint.</summary>
    Topic,
    /// <summary>A constraint based on a list of words or phrases. See SpeechRecognitionListConstraint.</summary>
    List,
    /// <summary>A constraint based on a Speech Recognition Grammar Specification (SRGS) grammar file. See SpeechRecognitionGrammarFileConstraint.</summary>
    Grammar,
    /// <summary>A constraint based on a Voice Command Definition (VCD) file. See SpeechRecognitionVoiceCommandDefinitionConstraint.</summary>
    VoiceCommandDefinition,
  }
}
