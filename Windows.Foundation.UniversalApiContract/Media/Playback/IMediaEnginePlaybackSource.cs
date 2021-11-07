// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaEnginePlaybackSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>The interface implemented by classes that are Media Engine playback sources.</summary>
  /// <deprecated type="deprecate">Use MediaPlayer instead of MediaEngine. For more info, see MSDN.</deprecated>
  [Guid(1545407399, 14422, 18617, 141, 198, 36, 75, 241, 7, 191, 140)]
  [Deprecated("Use MediaPlayer instead of MediaEngine. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IMediaEnginePlaybackSource
  {
    /// <summary>Gets the current playing MediaPlaybackItem.</summary>
    /// <returns>The current playing MediaPlaybackItem.</returns>
    MediaPlaybackItem CurrentItem { [Deprecated("Use MediaPlayer instead of MediaEngine. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Sets the media playback source.</summary>
    /// <deprecated type="deprecate">Use MediaPlayer instead of MediaEngine. For more info, see MSDN.</deprecated>
    /// <param name="source">The media playback source.</param>
    [Deprecated("Use MediaPlayer instead of MediaEngine. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void SetPlaybackSource(IMediaPlaybackSource source);
  }
}
