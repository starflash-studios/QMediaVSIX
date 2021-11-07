// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognizerTimeouts
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  /// <summary>The timespan that a speech recognizer ignores silence or unrecognizable sounds (babble) and continues listening for speech input.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SpeechRecognizerTimeouts : ISpeechRecognizerTimeouts
  {
    /// <summary>Gets and sets the length of time, before any recognition results have been generated, that a SpeechRecognizer detects silence and assumes speech input has ended.</summary>
    /// <returns>The length of time that the speech recognizer continues to listen while detecting only silence. The default is 5 seconds.</returns>
    public extern TimeSpan InitialSilenceTimeout { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the length of time, after recognition results have been generated, that a SpeechRecognizer detects silence and assumes speech input has ended.</summary>
    /// <returns>The length of time that the speech recognizer continues to listen while detecting only silence. The default is 150 milliseconds.</returns>
    public extern TimeSpan EndSilenceTimeout { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the length of time that a SpeechRecognizer continues to listen while receiving unrecognizable sounds (babble) before it assumes speech input has ended and finalizes the recognition operation.</summary>
    /// <returns>The length of time that the speech recognizer continues to listen while detecting only non-speech input such as background noise. The default is 0 seconds (not activated).</returns>
    public extern TimeSpan BabbleTimeout { [MethodImpl] get; [MethodImpl] set; }
  }
}
