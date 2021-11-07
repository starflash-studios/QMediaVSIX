// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.PlaybackMediaMarker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Represents a marker at specific location in a media stream time-line.</summary>
  [Activatable(typeof (IPlaybackMediaMarkerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PlaybackMediaMarker : IPlaybackMediaMarker
  {
    [MethodImpl]
    public extern PlaybackMediaMarker(TimeSpan value);

    [MethodImpl]
    public extern PlaybackMediaMarker(TimeSpan value, string mediaMarketType, string text);

    /// <summary>Gets the offset in the media timeline where the marker occurs.</summary>
    /// <returns>The offset in the media timeline where the marker occurs.</returns>
    public extern TimeSpan Time { [MethodImpl] get; }

    /// <summary>Gets the type of the media marker.</summary>
    /// <returns>The type of the media marker.</returns>
    public extern string MediaMarkerType { [MethodImpl] get; }

    /// <summary>Gets the text associated with the marker.</summary>
    /// <returns>The text associated with the marker.</returns>
    public extern string Text { [MethodImpl] get; }
  }
}
