// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayer4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.Media.Playback
{
  [WebHostHidden]
  [Guid(2147704240, 29768, 18288, 175, 207, 42, 87, 69, 9, 20, 197)]
  [ExclusiveTo(typeof (MediaPlayer))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaPlayer4
  {
    void SetSurfaceSize(Size size);

    MediaPlayerSurface GetSurface(Compositor compositor);
  }
}
