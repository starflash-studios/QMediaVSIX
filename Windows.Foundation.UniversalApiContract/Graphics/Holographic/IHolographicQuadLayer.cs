// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicQuadLayer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;

namespace Windows.Graphics.Holographic
{
  [ExclusiveTo(typeof (HolographicQuadLayer))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2419351753, 51673, 23900, 65, 172, 162, 213, 171, 15, 211, 49)]
  internal interface IHolographicQuadLayer
  {
    DirectXPixelFormat PixelFormat { get; }

    Size Size { get; }
  }
}
