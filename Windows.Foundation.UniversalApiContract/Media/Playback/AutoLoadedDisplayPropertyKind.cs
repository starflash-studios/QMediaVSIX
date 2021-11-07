// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.AutoLoadedDisplayPropertyKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Specifies the kinds of metadata that can be automatically displayed for a MediaPlaybackItem. Set the type of data you want to be automatically loaded by assigning one of these values to the AutoLoadedDisplayProperties properties.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum AutoLoadedDisplayPropertyKind
  {
    /// <summary>No metadata should be automatically displayed.</summary>
    None,
    /// <summary>Metadata should be automatically displayed for music or video content.</summary>
    MusicOrVideo,
    /// <summary>Metadata should be automatically displayed for music content.</summary>
    Music,
    /// <summary>Metadata should be automatically displayed for video content.</summary>
    Video,
  }
}
