// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionGraphicsDevice4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;
using Windows.Graphics.DirectX;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CompositionGraphicsDevice))]
  [Guid(1517535225, 43391, 19701, 186, 70, 152, 239, 53, 142, 113, 177)]
  internal interface ICompositionGraphicsDevice4
  {
    [RemoteAsync]
    IAsyncOperation<ICompositionSurface> CaptureAsync(
      Visual captureVisual,
      SizeInt32 size,
      DirectXPixelFormat pixelFormat,
      DirectXAlphaMode alphaMode,
      float sdrBoost);
  }
}
