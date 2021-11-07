// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlayerAudioCategory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Specifies the types of audio that can be played by a media player.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MediaPlayerAudioCategory
  {
    /// <summary>The audio type is not one of the provided enumeration values.</summary>
    Other = 0,
    /// <summary>The audio is used for communications.</summary>
    Communications = 3,
    /// <summary>The audio is used for alerts.</summary>
    Alerts = 4,
    /// <summary>The audio is a sound effect.</summary>
    SoundEffects = 5,
    /// <summary>The audio is a game effect.</summary>
    GameEffects = 6,
    /// <summary>The audio is game media, such as background music.</summary>
    GameMedia = 7,
    /// <summary>The audio is used for game chat.</summary>
    GameChat = 8,
    /// <summary>The audio is used for speech.</summary>
    Speech = 9,
    /// <summary>The audio is for movie playback.</summary>
    Movie = 10, // 0x0000000A
    /// <summary>The audio is for media playback.</summary>
    Media = 11, // 0x0000000B
  }
}
