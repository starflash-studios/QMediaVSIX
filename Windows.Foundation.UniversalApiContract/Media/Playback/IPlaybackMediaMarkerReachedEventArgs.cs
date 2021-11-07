// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IPlaybackMediaMarkerReachedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Guid(1468846521, 37090, 20064, 171, 196, 135, 64, 176, 31, 97, 150)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PlaybackMediaMarkerReachedEventArgs))]
  internal interface IPlaybackMediaMarkerReachedEventArgs
  {
    PlaybackMediaMarker PlaybackMediaMarker { get; }
  }
}
