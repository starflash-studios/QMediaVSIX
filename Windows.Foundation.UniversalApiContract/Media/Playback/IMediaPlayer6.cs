// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayer6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;

namespace Windows.Media.Playback
{
  [Guid(3771375750, 44645, 16716, 176, 16, 139, 197, 95, 0, 230, 146)]
  [ExclusiveTo(typeof (MediaPlayer))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IMediaPlayer6
  {
    event TypedEventHandler<MediaPlayer, object> SubtitleFrameChanged;

    [Overload("RenderSubtitlesToSurface")]
    bool RenderSubtitlesToSurface(IDirect3DSurface destination);

    [Overload("RenderSubtitlesToSurfaceWithTargetRectangle")]
    bool RenderSubtitlesToSurface(IDirect3DSurface destination, Rect targetRectangle);
  }
}
