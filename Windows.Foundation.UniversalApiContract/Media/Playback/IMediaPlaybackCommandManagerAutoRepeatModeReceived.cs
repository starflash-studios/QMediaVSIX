// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs))]
  [Guid(1030704931, 21040, 17425, 160, 233, 186, 217, 76, 42, 4, 92)]
  internal interface IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs
  {
    bool Handled { get; set; }

    MediaPlaybackAutoRepeatMode AutoRepeatMode { get; }

    Deferral GetDeferral();
  }
}
