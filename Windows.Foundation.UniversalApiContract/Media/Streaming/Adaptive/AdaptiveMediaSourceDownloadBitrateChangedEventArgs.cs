// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadBitrateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  /// <summary>Provides data for the DownloadBitrateChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class AdaptiveMediaSourceDownloadBitrateChangedEventArgs : 
    IAdaptiveMediaSourceDownloadBitrateChangedEventArgs,
    IAdaptiveMediaSourceDownloadBitrateChangedEventArgs2
  {
    /// <summary>Gets a value indicating the previous download bitrate for the media source.</summary>
    /// <returns>A value indicating the previous download bitrate for the media source.</returns>
    public extern uint OldValue { [MethodImpl] get; }

    /// <summary>Gets a value indicating the new download bitrate for the media source.</summary>
    /// <returns>A value indicating the new download bitrate for the media source.</returns>
    public extern uint NewValue { [MethodImpl] get; }

    /// <summary>Gets a value specifying the reason that the download bitrate changed.</summary>
    /// <returns>A value specifying the reason that the download bitrate changed.</returns>
    public extern AdaptiveMediaSourceDownloadBitrateChangedReason Reason { [MethodImpl] get; }
  }
}
