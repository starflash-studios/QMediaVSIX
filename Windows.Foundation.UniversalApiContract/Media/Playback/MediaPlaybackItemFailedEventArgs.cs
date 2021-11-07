// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackItemFailedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Provides data for the MediaPlaybackList.ItemFailed event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class MediaPlaybackItemFailedEventArgs : IMediaPlaybackItemFailedEventArgs
  {
    /// <summary>Gets the MediaPlaybackItem associated with the error.</summary>
    /// <returns>The MediaPlaybackItem associated with the error.</returns>
    public extern MediaPlaybackItem Item { [MethodImpl] get; }

    /// <summary>Gets a wrapper object for the MediaPlaybackItem error that provides high-level information about the cause of the error.</summary>
    /// <returns>A wrapper object for the MediaPlaybackItem error.</returns>
    public extern MediaPlaybackItemError Error { [MethodImpl] get; }
  }
}
