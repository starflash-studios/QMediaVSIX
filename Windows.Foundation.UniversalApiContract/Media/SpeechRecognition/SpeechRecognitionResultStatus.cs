// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognitionResultStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  /// <summary>Specifies the possible result states of a speech recognition session or from the compiling of grammar constraints.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SpeechRecognitionResultStatus
  {
    /// <summary>The recognition session or compilation succeeded.</summary>
    Success,
    /// <summary>A topic constraint was set for an unsupported language.</summary>
    TopicLanguageNotSupported,
    /// <summary>The language of the speech recognizer does not match the language of a grammar.</summary>
    GrammarLanguageMismatch,
    /// <summary>A grammar failed to compile.</summary>
    GrammarCompilationFailure,
    /// <summary>Audio problems caused recognition to fail.</summary>
    AudioQualityFailure,
    /// <summary>User canceled recognition session.</summary>
    UserCanceled,
    /// <summary>An unknown problem caused recognition or compilation to fail.</summary>
    Unknown,
    /// <summary>A timeout due to extended silence or poor audio caused recognition to fail.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TimeoutExceeded,
    /// <summary>An extended pause, or excessive processing time, caused recognition to fail.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] PauseLimitExceeded,
    /// <summary>Network problems caused recognition to fail.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NetworkFailure,
    /// <summary>Lack of a microphone caused recognition to fail.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] MicrophoneUnavailable,
  }
}
