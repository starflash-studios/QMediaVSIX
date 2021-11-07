// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaCapturePauseResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Provides the last frame captured and the recorded duration of a media capture operation that has been paused.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.MTA)]
  [GCPressure(amount = GCPressureAmount.High)]
  [DualApiPartition(version = 167772162)]
  public sealed class MediaCapturePauseResult : IMediaCapturePauseResult, IClosable
  {
    /// <summary>Gets a VideoFrame representing the last frame captured before the capture operation was paused.</summary>
    /// <returns>The last frame captured before the capture operation was paused.</returns>
    public extern VideoFrame LastFrame { [MethodImpl] get; }

    /// <summary>Gets the duration of the media captured before the capture operation was paused.</summary>
    /// <returns>The duration of the media captured before the capture operation was paused.</returns>
    public extern TimeSpan RecordDuration { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
