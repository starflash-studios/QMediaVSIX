// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionGraphicsDevice2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;
using Windows.Graphics.DirectX;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (CompositionGraphicsDevice))]
  [Guid(263765494, 49392, 19404, 159, 184, 8, 73, 130, 73, 13, 125)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ICompositionGraphicsDevice2
  {
    CompositionDrawingSurface CreateDrawingSurface2(
      SizeInt32 sizePixels,
      DirectXPixelFormat pixelFormat,
      DirectXAlphaMode alphaMode);

    CompositionVirtualDrawingSurface CreateVirtualDrawingSurface(
      SizeInt32 sizePixels,
      DirectXPixelFormat pixelFormat,
      DirectXAlphaMode alphaMode);
  }
}
