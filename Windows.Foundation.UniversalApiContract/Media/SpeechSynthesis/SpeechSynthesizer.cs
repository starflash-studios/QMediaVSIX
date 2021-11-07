// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechSynthesis.SpeechSynthesizer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechSynthesis
{
  /// <summary>Provides access to the functionality of an installed speech synthesis engine (voice) for Text-to-speech (TTS) services.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IInstalledVoicesStatic), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IInstalledVoicesStatic2), 327680, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SpeechSynthesizer : ISpeechSynthesizer, IClosable, ISpeechSynthesizer2
  {
    /// <summary>Initializes a new instance of a SpeechSynthesizer object.</summary>
    [MethodImpl]
    public extern SpeechSynthesizer();

    /// <summary>Asynchronously generate speech output from a string.</summary>
    /// <param name="text">The text to speak.</param>
    /// <returns>A SpeechSynthesisStream that represents the speech generated from the text.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SpeechSynthesisStream> SynthesizeTextToStreamAsync(
      string text);

    /// <summary>Asynchronously generate and control speech output from a Speech Synthesis Markup Language (SSML) Version 1.1 string.</summary>
    /// <param name="Ssml">The SSML-modified text to speak.</param>
    /// <returns>A SpeechSynthesisStream that represents the speech generated from the Speech Synthesis Markup Language (SSML) Version 1.1.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SpeechSynthesisStream> SynthesizeSsmlToStreamAsync(
      string Ssml);

    /// <summary>Gets or sets the speech synthesis engine (voice).</summary>
    /// <returns>A speech synthesis engine (or voice). The default value is the current system voice.</returns>
    public extern VoiceInformation Voice { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    /// <summary>Gets a reference to the collection of options that can be set on the SpeechSynthesizer object.</summary>
    /// <returns>The speech synthesizer options.</returns>
    public extern SpeechSynthesizerOptions Options { [MethodImpl] get; }

    /// <summary>Asynchronously attempts to set the voice used for speech synthesis on an IoT device.</summary>
    /// <param name="voice">One of the installed speech synthesis engines (voices).</param>
    /// <returns>An asynchronous operation that returns true if the set operation was a success. Otherwise, returns false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> TrySetDefaultVoiceAsync(
      VoiceInformation voice);

    /// <summary>Gets a collection of all installed speech synthesis engines (voices).</summary>
    /// <returns>A collection of VoiceInformation objects.</returns>
    public static extern IVectorView<VoiceInformation> AllVoices { [MethodImpl] get; }

    /// <summary>Gets the default speech synthesis engine (voice).</summary>
    /// <returns>The default voice.</returns>
    public static extern VoiceInformation DefaultVoice { [MethodImpl] get; }
  }
}
