// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.CurrentMediaPlaybackItemChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Provides data for the MediaPlaybackList.CurrentItemChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class CurrentMediaPlaybackItemChangedEventArgs : 
    ICurrentMediaPlaybackItemChangedEventArgs,
    ICurrentMediaPlaybackItemChangedEventArgs2
  {
    /// <summary>Gets the new current MediaPlaybackItem.</summary>
    /// <returns>The new current MediaPlaybackItem.</returns>
    public extern MediaPlaybackItem NewItem { [MethodImpl] get; }

    /// <summary>Gets the previous current MediaPlaybackItem.</summary>
    /// <returns>The previous current MediaPlaybackItem.</returns>
    public extern MediaPlaybackItem OldItem { [MethodImpl] get; }

    /// <summary>Gets the reason why the current MediaPlaybackItem in a MediaPlaybackList changed, such as if the previous item completed playback successfully or if there was an error playing back the previous item.</summary>
    /// <returns>The reason why the current MediaPlaybackItem in a MediaPlaybackList changed.</returns>
    public extern MediaPlaybackItemChangedReason Reason { [MethodImpl] get; }
  }
}
