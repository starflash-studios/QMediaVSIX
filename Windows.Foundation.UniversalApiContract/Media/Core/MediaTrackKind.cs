// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaTrackKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Specifies the type of a media track.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MediaTrackKind
  {
    /// <summary>The track is an audio track.</summary>
    Audio,
    /// <summary>The track is a video track.</summary>
    Video,
    /// <summary>The track is a timed metadata track.</summary>
    TimedMetadata,
  }
}
