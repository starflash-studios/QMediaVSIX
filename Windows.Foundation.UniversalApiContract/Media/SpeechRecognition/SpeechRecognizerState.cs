// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognizerState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  /// <summary>Specifies the state of the speech recognizer.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SpeechRecognizerState
  {
    /// <summary>Indicates that speech recognition is not active and the speech recognizer is not capturing (listening for) audio input.</summary>
    Idle,
    /// <summary>Indicates that the speech recognizer is capturing (listening for) audio input from the user.</summary>
    Capturing,
    /// <summary>Indicates that the speech recognizer is processing (attempting to recognize) audio input from the user. The recognizer is no longer capturing (listening for) audio input from the user.</summary>
    Processing,
    /// <summary>Indicates that the speech recognizer has detected sound on the audio stream.</summary>
    SoundStarted,
    /// <summary>Indicates that the speech recognizer no longer detects sound on the audio stream.</summary>
    SoundEnded,
    /// <summary>Indicates that the speech recognizer has detected speech input on the audio stream.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] SpeechDetected,
    /// <summary>Only valid for continuous recognition.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Paused,
  }
}
