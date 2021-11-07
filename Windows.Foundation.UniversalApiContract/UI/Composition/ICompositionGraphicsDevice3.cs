// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionGraphicsDevice3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;
using Windows.Graphics.DirectX;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [Guid(938898708, 54255, 18897, 182, 157, 13, 142, 171, 235, 54, 38)]
  [ExclusiveTo(typeof (CompositionGraphicsDevice))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface ICompositionGraphicsDevice3
  {
    CompositionMipmapSurface CreateMipmapSurface(
      SizeInt32 sizePixels,
      DirectXPixelFormat pixelFormat,
      DirectXAlphaMode alphaMode);

    void Trim();
  }
}
