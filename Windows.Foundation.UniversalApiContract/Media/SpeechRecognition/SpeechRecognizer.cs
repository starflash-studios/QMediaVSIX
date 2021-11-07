// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognizer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Media.SpeechRecognition
{
  /// <summary>Enables speech recognition with either a default or a custom graphical user interface (GUI).</summary>
  [Activatable(typeof (ISpeechRecognizerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ISpeechRecognizerStatics2), 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ISpeechRecognizerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class SpeechRecognizer : ISpeechRecognizer, IClosable, ISpeechRecognizer2
  {
    /// <summary>Creates a new instance of the SpeechRecognizer class with a language specifier.</summary>
    /// <param name="language">The spoken language to use for recognition.</param>
    [MethodImpl]
    public extern SpeechRecognizer(Language language);

    /// <summary>Creates a new instance of the SpeechRecognizer class.</summary>
    [MethodImpl]
    public extern SpeechRecognizer();

    /// <summary>Gets the language used for speech recognition.</summary>
    /// <returns>The language used for speech recognition.</returns>
    public extern Language CurrentLanguage { [MethodImpl] get; }

    /// <summary>Gets the collection of constraint objects currently added to the SpeechRecognizer object.</summary>
    /// <returns>A collection of ISpeechRecognitionConstraint objects.</returns>
    public extern IVector<ISpeechRecognitionConstraint> Constraints { [MethodImpl] get; }

    /// <summary>Gets how long a speech recognizer ignores silence or unrecognizable sounds (babble) and continues listening for speech input.</summary>
    /// <returns>The timeout settings.</returns>
    public extern SpeechRecognizerTimeouts Timeouts { [MethodImpl] get; }

    /// <summary>Gets the UI settings for the RecognizeWithUIAsync method.</summary>
    /// <returns>The UI settings.</returns>
    public extern SpeechRecognizerUIOptions UIOptions { [MethodImpl] get; }

    /// <summary>Asynchronously compile all constraints specified by the Constraints property.</summary>
    /// <returns>The result of the constraints compilation as a SpeechRecognitionCompilationResult object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SpeechRecognitionCompilationResult> CompileConstraintsAsync();

    /// <summary>Begins a speech recognition session for a SpeechRecognizer object.</summary>
    /// <returns>The result of the speech recognition session that was initiated by the SpeechRecognizer object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SpeechRecognitionResult> RecognizeAsync();

    /// <summary>Asynchronously starts a speech recognition session that includes additional UI mechanisms, including prompts, examples, text-to-speech (TTS), and confirmations.</summary>
    /// <returns>The result of the speech recognition session as a SpeechRecognitionResult object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SpeechRecognitionResult> RecognizeWithUIAsync();

    /// <summary>This event is raised when an audio problem is detected that might affect recognition accuracy.</summary>
    public extern event TypedEventHandler<SpeechRecognizer, SpeechRecognitionQualityDegradingEventArgs> RecognitionQualityDegrading;

    /// <summary>This event is raised when a change occurs to the State property during audio capture.</summary>
    public extern event TypedEventHandler<SpeechRecognizer, SpeechRecognizerStateChangedEventArgs> StateChanged;

    [MethodImpl]
    public extern void Close();

    /// <summary>Gets the continuous recognition session object (SpeechContinuousRecognitionSession ) associated with this SpeechRecognizer.</summary>
    /// <returns>The continuous recognition session object associated with this SpeechRecognizer.</returns>
    public extern SpeechContinuousRecognitionSession ContinuousRecognitionSession { [MethodImpl] get; }

    /// <summary>Gets the state of the speech recognizer.</summary>
    /// <returns>The speech recognizer state.</returns>
    public extern SpeechRecognizerState State { [MethodImpl] get; }

    /// <summary>Asynchronously ends the speech recognition session.</summary>
    /// <returns>No object or value is returned when this method completes.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StopRecognitionAsync();

    /// <summary>Occurs during an ongoing dictation session when a recognition result fragment is returned by the speech recognizer.</summary>
    public extern event TypedEventHandler<SpeechRecognizer, SpeechRecognitionHypothesisGeneratedEventArgs> HypothesisGenerated;

    /// <summary>Asynchronously attempts to set the system language used for speech recognition on an IoT device.</summary>
    /// <param name="speechLanguage">The  BCP-47 -based system language used for speech recognition.</param>
    /// <returns>An asynchronous operation that returns true if the set operation was a success. Otherwise, returns false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> TrySetSystemSpeechLanguageAsync(
      Language speechLanguage);

    /// <summary>Gets the speech language of the device specified in **Settings &gt; Time &amp; Language &gt; Speech**.</summary>
    /// <returns>The speech language of the device, or null if a speech language is not installed.</returns>
    public static extern Language SystemSpeechLanguage { [MethodImpl] get; }

    /// <summary>Gets the collection of languages supported by the pre-defined, web-service grammars of the SpeechRecognitionTopicConstraint objects specified in the Constraints property.</summary>
    /// <returns>The collection of languages supported by the pre-defined, web-service grammars.</returns>
    public static extern IVectorView<Language> SupportedTopicLanguages { [MethodImpl] get; }

    /// <summary>Gets the collection of languages supported by the custom grammars of the SpeechRecognitionGrammarFileConstraint and SpeechRecognitionListConstraint objects specified in the Constraints property.</summary>
    /// <returns>The collection of grammar languages.</returns>
    public static extern IVectorView<Language> SupportedGrammarLanguages { [MethodImpl] get; }
  }
}
