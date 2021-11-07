// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaBreakSeekedOverEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Provides data for the MediaBreakManager.BreaksSeekedOver event, which occurs when the user seeks the media playback position past one or more pending media breaks.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaBreakSeekedOverEventArgs : IMediaBreakSeekedOverEventArgs
  {
    /// <summary>Gets the list of MediaBreak objects that were seeked over, meaning that they were scheduled to play between the OldPosition and NewPosition of the seek operation.</summary>
    /// <returns>The list of MediaBreak objects that were seeked over.</returns>
    public extern IVectorView<MediaBreak> SeekedOverBreaks { [MethodImpl] get; }

    /// <summary>Gets the previous position within the MediaPlaybackItem before the seek operation started.</summary>
    /// <returns>The previous position within the MediaPlaybackItem before the seek operation started.</returns>
    public extern TimeSpan OldPosition { [MethodImpl] get; }

    /// <summary>Gets the new current position within the MediaPlaybackItem after the seek operation has completed.</summary>
    /// <returns>The new current position within the MediaPlaybackItem after the seek operation has completed.</returns>
    public extern TimeSpan NewPosition { [MethodImpl] get; }
  }
}
