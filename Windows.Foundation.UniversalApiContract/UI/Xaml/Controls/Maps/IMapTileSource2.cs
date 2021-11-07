// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapTileSource2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [Guid(2389044157, 16533, 23573, 153, 241, 18, 96, 180, 232, 176, 169)]
  [ExclusiveTo(typeof (MapTileSource))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IMapTileSource2
  {
    MapTileAnimationState AnimationState { get; }

    bool AutoPlay { get; set; }

    int FrameCount { get; set; }

    TimeSpan FrameDuration { get; set; }

    void Pause();

    void Play();

    void Stop();
  }
}
