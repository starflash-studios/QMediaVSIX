// Decompiled with JetBrains decompiler
// Type: Windows.Media.Render.AudioRenderCategory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Render
{
  /// <summary>Describes the purpose of the audio information in an audio stream.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AudioRenderCategory
  {
    /// <summary>All other streams.</summary>
    Other,
    /// <summary>Audio is for general media, for example audio for video, or streaming audio, but should not be played as background. This enumeration value is deprecated. For more information, see Remarks.</summary>
    /// <deprecated type="deprecate">ForegroundOnlyMedia is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    [Deprecated("ForegroundOnlyMedia is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] ForegroundOnlyMedia,
    /// <summary>Audio is for general media, for example audio for video, or streaming audio, and can be played as background. This enumeration value is deprecated. For more information, see Remarks.</summary>
    /// <deprecated type="deprecate">BackgroundCapableMedia is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    [Deprecated("BackgroundCapableMedia is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] BackgroundCapableMedia,
    /// <summary>Audio is for peer-to-peer communications, for example chat or VoIP.</summary>
    Communications,
    /// <summary>Audio is for system or application notifications, for example ring tones.</summary>
    Alerts,
    /// <summary>Audio is for sound effects.</summary>
    SoundEffects,
    /// <summary>Audio is for game-specific sound effects.</summary>
    GameEffects,
    /// <summary>Audio is background (non-event or ambient) audio for games.</summary>
    GameMedia,
    /// <summary>Audio is voice chat for games.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GameChat,
    /// <summary>Audio is speech.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Speech,
    /// <summary>Audio is movie audio.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Movie,
    /// <summary>Audio is media playback.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Media,
  }
}
