// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.LowLagMediaRecording
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;

namespace Windows.Media.Capture
{
  /// <summary>Provides methods for taking a low lag media recording.</summary>
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  public sealed class LowLagMediaRecording : 
    ILowLagMediaRecording,
    ILowLagMediaRecording2,
    ILowLagMediaRecording3
  {
    /// <summary>Asynchronously starts the low lag media recording.</summary>
    /// <returns>Object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StartAsync();

    /// <summary>Asynchronously stops the low lag media recording.</summary>
    /// <returns>Object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StopAsync();

    /// <summary>Asynchronously releases the LowLagMediaRecording object and resources used by the media recording operation.</summary>
    /// <returns>Object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction FinishAsync();

    /// <summary>Pauses an ongoing low lag media record operation.</summary>
    /// <param name="behavior">A value indicating whether the media capture hardware resources should be preserved or released while recording is paused.</param>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction PauseAsync(MediaCapturePauseBehavior behavior);

    /// <summary>Resumes a paused low lag recording operation.</summary>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ResumeAsync();

    /// <summary>Pauses an ongoing low lag media record operation and provides a MediaCapturePauseResult that can be used to help the user align the camera with the last captured frame when resuming recording.</summary>
    /// <param name="behavior">A value indicating whether the media capture hardware resources should be preserved or released while recording is paused.</param>
    /// <returns>An asynchronous action that returns a MediaCapturePauseResult upon completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaCapturePauseResult> PauseWithResultAsync(
      MediaCapturePauseBehavior behavior);

    /// <summary>Asynchronously stops the low lag media recording and provides a MediaCaptureStopResult that can be used to help the user align the camera with the last captured frame when restarting recording.</summary>
    /// <returns>An asynchronous action that returns a MediaCaptureStopResult upon completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaCaptureStopResult> StopWithResultAsync();
  }
}
