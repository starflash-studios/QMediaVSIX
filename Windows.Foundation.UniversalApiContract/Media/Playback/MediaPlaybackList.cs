// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Represents a list of MediaPlaybackItem objects that can be played back. Provides methods for switching the currently playing item and enabling looping and shuffling.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaPlaybackList : 
    IMediaPlaybackList,
    IMediaPlaybackSource,
    IMediaPlaybackList2,
    IMediaPlaybackList3
  {
    /// <summary>Initializes a new instance of the MediaPlaybackList class.</summary>
    [MethodImpl]
    public extern MediaPlaybackList();

    /// <summary>Occurs when an error is encountered with a MediaPlaybackItem in the playback list.</summary>
    public extern event TypedEventHandler<MediaPlaybackList, MediaPlaybackItemFailedEventArgs> ItemFailed;

    /// <summary>Occurs when the currently playing MediaPlaybackItem changes.</summary>
    public extern event TypedEventHandler<MediaPlaybackList, CurrentMediaPlaybackItemChangedEventArgs> CurrentItemChanged;

    /// <summary>Occurs when a MediaPlaybackItem in the playback list is successfully opened.</summary>
    public extern event TypedEventHandler<MediaPlaybackList, MediaPlaybackItemOpenedEventArgs> ItemOpened;

    /// <summary>Gets an IObservableVector representation of the playback list.</summary>
    /// <returns>An IObservableVector representation of the playback list.</returns>
    public extern IObservableVector<MediaPlaybackItem> Items { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating whether the playback list will loop when the end of the list is reached.</summary>
    /// <returns>True if auto-repeat is enabled; otherwise, false.</returns>
    public extern bool AutoRepeatEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating whether the items in the playback list are played in a random order.</summary>
    /// <returns>True if shuffle is enabled; otherwise, false.</returns>
    public extern bool ShuffleEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the currently playing MediaPlaybackItem.</summary>
    /// <returns>The currently playing MediaPlaybackItem.</returns>
    public extern MediaPlaybackItem CurrentItem { [MethodImpl] get; }

    /// <summary>Gets the index of the current item in theMediaPlaybackList.</summary>
    /// <returns>The index of the current item in theMediaPlaybackList.</returns>
    public extern uint CurrentItemIndex { [MethodImpl] get; }

    /// <summary>Changes the current item of the MediaPlaybackList to the next item in the list.</summary>
    /// <returns>The new current MediaPlaybackItem.</returns>
    [MethodImpl]
    public extern MediaPlaybackItem MoveNext();

    /// <summary>Changes the current item of the MediaPlaybackList to the previous item in the list.</summary>
    /// <returns>The new current MediaPlaybackItem.</returns>
    [MethodImpl]
    public extern MediaPlaybackItem MovePrevious();

    /// <summary>Changes the current item of the MediaPlaybackList to the item with the specified index.</summary>
    /// <param name="itemIndex">The index of the item to make current.</param>
    /// <returns>The new current MediaPlaybackItem.</returns>
    [MethodImpl]
    public extern MediaPlaybackItem MoveTo(uint itemIndex);

    /// <summary>Gets or sets the maximum time before a MediaPlaybackItem in the list is expected to play that the media content associated with the item is retrieved.</summary>
    /// <returns>The maximum time before a MediaPlaybackItem in the list is expected to play that the media content associated with the item is retrieved.</returns>
    public extern IReference<TimeSpan> MaxPrefetchTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the MediaPlaybackItem that will be played first.</summary>
    /// <returns>The MediaPlaybackItem that will be played first.</returns>
    public extern MediaPlaybackItem StartingItem { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a read-only list of MediaPlaybackItem objects that will be played in shuffle mode, in the order in which they will be played.</summary>
    /// <returns>A read-only list of MediaPlaybackItem objects that will be played in shuffle mode</returns>
    public extern IVectorView<MediaPlaybackItem> ShuffledItems { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetShuffledItems(IIterable<MediaPlaybackItem> value);

    /// <summary>Gets or sets a value that specifies the number of MediaPlaybackItem objects that should be kept open after they have been played.</summary>
    /// <returns>A value that specifies the number of MediaPlaybackItem objects that should be kept open after they have been played.</returns>
    public extern IReference<uint> MaxPlayedItemsToKeepOpen { [MethodImpl] get; [MethodImpl] set; }
  }
}
