// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IPlaybackMediaMarker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3302109020, 15388, 17476, 182, 185, 119, 139, 4, 34, 212, 26)]
  [ExclusiveTo(typeof (PlaybackMediaMarker))]
  internal interface IPlaybackMediaMarker
  {
    TimeSpan Time { get; }

    string MediaMarkerType { get; }

    string Text { get; }
  }
}
