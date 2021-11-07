// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayer5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (MediaPlayer))]
  [Guid(3487905789, 63594, 17478, 191, 77, 200, 231, 146, 183, 180, 179)]
  internal interface IMediaPlayer5
  {
    event TypedEventHandler<MediaPlayer, object> VideoFrameAvailable;

    bool IsVideoFrameServerEnabled { get; set; }

    [Overload("CopyFrameToVideoSurface")]
    void CopyFrameToVideoSurface(IDirect3DSurface destination);

    [Overload("CopyFrameToVideoSurfaceWithTargetRectangle")]
    void CopyFrameToVideoSurface(IDirect3DSurface destination, Rect targetRectangle);

    void CopyFrameToStereoscopicVideoSurfaces(
      IDirect3DSurface destinationLeftEye,
      IDirect3DSurface destinationRightEye);
  }
}
