// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicQuadLayerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;

namespace Windows.Graphics.Holographic
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2792700147, 23060, 23056, 72, 154, 69, 80, 101, 179, 123, 118)]
  [ExclusiveTo(typeof (HolographicQuadLayer))]
  internal interface IHolographicQuadLayerFactory
  {
    HolographicQuadLayer Create(Size size);

    HolographicQuadLayer CreateWithPixelFormat(
      Size size,
      DirectXPixelFormat pixelFormat);
  }
}
