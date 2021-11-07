// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognitionAudioProblem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  /// <summary>Specifies the type of audio problem detected.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SpeechRecognitionAudioProblem
  {
    /// <summary>No audio problem.</summary>
    None,
    /// <summary>Too much background noise interfering with the speech recognition.</summary>
    TooNoisy,
    /// <summary>No audio. For example, the microphone may have been muted.</summary>
    NoSignal,
    /// <summary>Input volume too high.</summary>
    TooLoud,
    /// <summary>Input volume too quiet.</summary>
    TooQuiet,
    /// <summary>User spoke too fast.</summary>
    TooFast,
    /// <summary>User spoke too slowly.</summary>
    TooSlow,
  }
}
