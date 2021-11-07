// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackCommandManagerPositionReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaPlaybackCommandManagerPositionReceivedEventArgs))]
  [Guid(1435608916, 54823, 19421, 169, 13, 134, 160, 21, 178, 73, 2)]
  internal interface IMediaPlaybackCommandManagerPositionReceivedEventArgs
  {
    bool Handled { get; set; }

    TimeSpan Position { get; }

    Deferral GetDeferral();
  }
}
