// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayerSource2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlayer))]
  [Guid(2185534367, 29474, 19467, 176, 59, 62, 105, 164, 130, 96, 197)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaPlayerSource2
  {
    IMediaPlaybackSource Source { get; set; }
  }
}
