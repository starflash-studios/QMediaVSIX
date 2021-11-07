// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackSessionBufferingStartedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Provides data for the BufferingStarted event of a MediaPlaybackSession.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class MediaPlaybackSessionBufferingStartedEventArgs : 
    IMediaPlaybackSessionBufferingStartedEventArgs
  {
    /// <summary>Gets a value indicating whether the buffering that triggered the event was expected by the system, such as when a new item begins playing or after the user seeks to a new position in the media item, or if it was an unexpected interruption, such as when buffering is caused by degradation of the network connection.</summary>
    /// <returns>True if the buffering represents an unexpected playback interruption. False if the buffering was an expected result of normal playback operations.</returns>
    public extern bool IsPlaybackInterruption { [MethodImpl] get; }
  }
}
