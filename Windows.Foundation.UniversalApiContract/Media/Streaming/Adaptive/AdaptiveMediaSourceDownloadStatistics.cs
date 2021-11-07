// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadStatistics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  /// <summary>Represents a set of download statistics associated with the AdaptiveMediaSource.DownloadFailed and AdaptiveMediaSource.DownloadCompleted events.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AdaptiveMediaSourceDownloadStatistics : IAdaptiveMediaSourceDownloadStatistics
  {
    /// <summary>Gets the count of bytes that have been received at the time of the event.</summary>
    /// <returns>The count of bytes that have been received at the time of the event.</returns>
    public extern ulong ContentBytesReceivedCount { [MethodImpl] get; }

    /// <summary>Gets the time window between when the system makes the asyncronous http request for the content and when the operation completes, when the http headers have been received.</summary>
    /// <returns>The time window between when the system makes the asyncronous http request for the content and when the operation completes, when the http headers have been received.</returns>
    public extern IReference<TimeSpan> TimeToHeadersReceived { [MethodImpl] get; }

    /// <summary>Gets the time window between when the system makes the asyncronous http request for the content and when the first block of data has been read from the http stream.</summary>
    /// <returns>The time window between when the system makes the asyncronous http request for the content and when the first block of data has been read from the http stream.</returns>
    public extern IReference<TimeSpan> TimeToFirstByteReceived { [MethodImpl] get; }

    /// <summary>Gets the time window between when the system makes the asyncronous http request for the content and when the last block of data has been read from the http stream.</summary>
    /// <returns>The time window between when the system makes the asyncronous http request for the content and when the last block of data has been read from the http stream.</returns>
    public extern IReference<TimeSpan> TimeToLastByteReceived { [MethodImpl] get; }
  }
}
