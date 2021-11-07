// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechContinuousRecognitionSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  /// <summary>Manages speech input for free-form dictation, or an arbitrary sequence of words or phrases that are defined in a local grammar file constraint.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class SpeechContinuousRecognitionSession : ISpeechContinuousRecognitionSession
  {
    /// <summary>Gets or sets the time threshold at which the continuous recognition session ends due to lack of audio input.</summary>
    /// <returns>The time threshold.</returns>
    public extern TimeSpan AutoStopSilenceTimeout { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>*Overload*</summary>
    /// <returns>An asynchronous handler called when the operation is complete.</returns>
    [Overload("StartAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StartAsync();

    /// <summary>*Overload*</summary>
    /// <param name="mode">The speech recognition behavior.</param>
    /// <returns>An asynchronous handler called when the operation is complete.</returns>
    [Overload("StartWithModeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StartAsync(SpeechContinuousRecognitionMode mode);

    /// <summary>Asynchronously end a continuous speech recognition session and pass all pending recognition results to the ResultGenerated event.</summary>
    /// <returns>An asynchronous handler called when the operation is complete.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StopAsync();

    /// <summary>Asynchronously cancel the continuous speech recognition session and discard all pending recognition results.</summary>
    /// <returns>An asynchronous handler called when the operation is complete.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CancelAsync();

    /// <summary>Asynchronously pause a continuous speech recognition session to update a local grammar file or list constraint.</summary>
    /// <returns>An asynchronous handler called when the operation is complete.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction PauseAsync();

    /// <summary>Resumes a continuous speech recognition session, if paused.</summary>
    [MethodImpl]
    public extern void Resume();

    /// <summary>Occurs when a continuous recognition session ends.</summary>
    public extern event TypedEventHandler<SpeechContinuousRecognitionSession, SpeechContinuousRecognitionCompletedEventArgs> Completed;

    /// <summary>Occurs when the speech recognizer returns the result from a continuous recognition session.</summary>
    public extern event TypedEventHandler<SpeechContinuousRecognitionSession, SpeechContinuousRecognitionResultGeneratedEventArgs> ResultGenerated;
  }
}
