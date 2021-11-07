// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicCameraRenderingParameters2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;

namespace Windows.Graphics.Holographic
{
  [Guid(638742755, 46742, 17972, 148, 214, 190, 6, 129, 100, 53, 153)]
  [ExclusiveTo(typeof (HolographicCameraRenderingParameters))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IHolographicCameraRenderingParameters2 : IHolographicCameraRenderingParameters
  {
    HolographicReprojectionMode ReprojectionMode { get; set; }

    void CommitDirect3D11DepthBuffer(IDirect3DSurface value);
  }
}
