// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackCommandManagerRewindReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Guid(2668124487, 41920, 16989, 170, 239, 151, 186, 120, 152, 177, 65)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaPlaybackCommandManagerRewindReceivedEventArgs))]
  internal interface IMediaPlaybackCommandManagerRewindReceivedEventArgs
  {
    bool Handled { get; set; }

    Deferral GetDeferral();
  }
}
