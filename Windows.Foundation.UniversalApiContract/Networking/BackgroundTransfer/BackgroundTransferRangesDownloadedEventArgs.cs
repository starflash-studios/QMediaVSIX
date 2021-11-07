// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.BackgroundTransferRangesDownloadedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  /// <summary>Provides access to information about the incremental download progress event.</summary>
  [DualApiPartition(version = 167772164)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BackgroundTransferRangesDownloadedEventArgs : 
    IBackgroundTransferRangesDownloadedEventArgs
  {
    /// <summary>TRUE if the download was restarted from scratch since the previous RangesDownloaded event.</summary>
    /// <returns>TRUE if the download was restarted from scratch since the previous RangesDownloaded event, otherwise FALSE.</returns>
    public extern bool WasDownloadRestarted { [MethodImpl] get; }

    /// <summary>List of ranges that were downloaded since the previous RangesDownloaded event.</summary>
    /// <returns>List of ranges that were downloaded since the previous RangesDownloaded event.</returns>
    public extern IVector<BackgroundTransferFileRange> AddedRanges { [MethodImpl] get; }

    /// <summary>Deferral allows apps to carry out asynchronous work within their RangesDownloaded handler without receiving a new RangesDownloaded event in the meantime.</summary>
    /// <returns>**HRESULT**</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
