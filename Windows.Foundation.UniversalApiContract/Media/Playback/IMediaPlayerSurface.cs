// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayerSurface
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.Media.Playback
{
  [WebHostHidden]
  [Guid(248927164, 46902, 18883, 131, 11, 118, 74, 56, 69, 49, 58)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaPlayerSurface))]
  internal interface IMediaPlayerSurface
  {
    ICompositionSurface CompositionSurface { get; }

    Compositor Compositor { get; }

    MediaPlayer MediaPlayer { get; }
  }
}
