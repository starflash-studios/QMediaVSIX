// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.ICompositeVideoFrameContext
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Media.Editing;

namespace Windows.Media.Effects
{
  [Guid(1815085643, 62740, 17016, 165, 247, 185, 24, 128, 73, 209, 16)]
  [ExclusiveTo(typeof (CompositeVideoFrameContext))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICompositeVideoFrameContext
  {
    IVectorView<IDirect3DSurface> SurfacesToOverlay { get; }

    VideoFrame BackgroundFrame { get; }

    VideoFrame OutputFrame { get; }

    MediaOverlay GetOverlayForSurface(IDirect3DSurface surfaceToOverlay);
  }
}
