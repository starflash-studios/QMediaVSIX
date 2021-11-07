// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackSessionBufferingStartedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(3446321133, 29922, 17333, 177, 21, 118, 35, 108, 51, 121, 26)]
  [ExclusiveTo(typeof (MediaPlaybackSessionBufferingStartedEventArgs))]
  internal interface IMediaPlaybackSessionBufferingStartedEventArgs
  {
    bool IsPlaybackInterruption { get; }
  }
}
