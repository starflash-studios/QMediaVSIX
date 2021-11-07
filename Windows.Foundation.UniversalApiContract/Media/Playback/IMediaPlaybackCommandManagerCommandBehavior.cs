// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackCommandManagerCommandBehavior
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Guid(2020351608, 52856, 18960, 175, 214, 132, 63, 203, 185, 12, 46)]
  [ExclusiveTo(typeof (MediaPlaybackCommandManagerCommandBehavior))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaPlaybackCommandManagerCommandBehavior
  {
    MediaPlaybackCommandManager CommandManager { get; }

    bool IsEnabled { get; }

    MediaCommandEnablingRule EnablingRule { get; set; }

    event TypedEventHandler<MediaPlaybackCommandManagerCommandBehavior, object> IsEnabledChanged;
  }
}
