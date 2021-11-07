// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedMetadataTrack2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;

namespace Windows.Media.Core
{
  [Guid(565491272, 40861, 16570, 168, 243, 26, 146, 117, 58, 239, 11)]
  [ExclusiveTo(typeof (TimedMetadataTrack))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ITimedMetadataTrack2 : ITimedMetadataTrack, IMediaTrack
  {
    MediaPlaybackItem PlaybackItem { get; }

    string Name { get; }
  }
}
