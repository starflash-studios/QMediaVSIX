// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechContinuousRecognitionSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1780562948, 26132, 18936, 153, 162, 181, 233, 179, 160, 133, 200)]
  [ExclusiveTo(typeof (SpeechContinuousRecognitionSession))]
  internal interface ISpeechContinuousRecognitionSession
  {
    TimeSpan AutoStopSilenceTimeout { get; set; }

    [Overload("StartAsync")]
    [RemoteAsync]
    IAsyncAction StartAsync();

    [RemoteAsync]
    [Overload("StartWithModeAsync")]
    IAsyncAction StartAsync(SpeechContinuousRecognitionMode mode);

    [RemoteAsync]
    IAsyncAction StopAsync();

    [RemoteAsync]
    IAsyncAction CancelAsync();

    [RemoteAsync]
    IAsyncAction PauseAsync();

    void Resume();

    event TypedEventHandler<SpeechContinuousRecognitionSession, SpeechContinuousRecognitionCompletedEventArgs> Completed;

    event TypedEventHandler<SpeechContinuousRecognitionSession, SpeechContinuousRecognitionResultGeneratedEventArgs> ResultGenerated;
  }
}
