// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaBreak
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Represents a set of one or more MediaPlaybackItem objects that are played before, after, or at specified points during the playback of another MediaPlaybackItem.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Activatable(typeof (IMediaBreakFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class MediaBreak : IMediaBreak
  {
    /// <summary>Initializes a new instance of the MediaBreak class with the specified insertion method.</summary>
    /// <param name="insertionMethod">A value indicating whether the media break will pause the currently playing media content.</param>
    [MethodImpl]
    public extern MediaBreak(MediaBreakInsertionMethod insertionMethod);

    [MethodImpl]
    public extern MediaBreak(
      MediaBreakInsertionMethod insertionMethod,
      TimeSpan presentationPosition);

    /// <summary>Gets the MediaPlaybackList containing the MediaPlaybackItem objects that will be played as part of the MediaBreak.</summary>
    /// <returns>The MediaPlaybackList containing the MediaPlaybackItem objects that will be played as part of the MediaBreak.</returns>
    public extern MediaPlaybackList PlaybackList { [MethodImpl] get; }

    /// <summary>Gets the position within the playback of a MediaPlaybackItem at which the MediaBreak will be played.</summary>
    /// <returns>The position within the playback of a MediaPlaybackItem that the MediaBreak will be played.</returns>
    public extern IReference<TimeSpan> PresentationPosition { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the media break will interrupt the main content, causing the main content to pause while it is played, or if it will replace the main content.</summary>
    /// <returns>A value indicating whether the media break will interrupt the main contentTBD</returns>
    public extern MediaBreakInsertionMethod InsertionMethod { [MethodImpl] get; }

    /// <summary>Gets a map of key/value pairs that allow you to associate custom data with a MediaBreak.</summary>
    /// <returns>A map of key/value pairs that allow you to associate custom data with a MediaBreak.</returns>
    public extern ValueSet CustomProperties { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating whether the MediaBreak can be played.</summary>
    /// <returns>True if the MediaBreak can be played; otherwise false.</returns>
    public extern bool CanStart { [MethodImpl] get; [MethodImpl] set; }
  }
}
