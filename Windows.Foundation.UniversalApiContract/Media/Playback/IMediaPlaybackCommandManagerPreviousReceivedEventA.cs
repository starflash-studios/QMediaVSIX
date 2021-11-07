// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackCommandManagerPreviousReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlaybackCommandManagerPreviousReceivedEventArgs))]
  [Guid(1381904513, 17970, 20342, 153, 177, 215, 113, 98, 63, 98, 135)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaPlaybackCommandManagerPreviousReceivedEventArgs
  {
    bool Handled { get; set; }

    Deferral GetDeferral();
  }
}
