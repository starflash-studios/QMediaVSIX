// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackCommandManagerRateReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlaybackCommandManagerRateReceivedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(418003257, 18966, 16745, 139, 5, 62, 185, 245, 255, 120, 235)]
  internal interface IMediaPlaybackCommandManagerRateReceivedEventArgs
  {
    bool Handled { get; set; }

    double PlaybackRate { get; }

    Deferral GetDeferral();
  }
}
