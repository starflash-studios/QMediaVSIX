// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechContinuousRecognitionMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  /// <summary>Specifies the behavior of the speech recognizer during a continuous recognition session.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SpeechContinuousRecognitionMode
  {
    /// <summary>Speech recognizer continues listening for and processing speech input after a recognition result is generated.</summary>
    Default,
    /// <summary>Speech recognizer pauses and suspends further processing of speech input when a recognition result is generated.</summary>
    PauseOnRecognition,
  }
}
