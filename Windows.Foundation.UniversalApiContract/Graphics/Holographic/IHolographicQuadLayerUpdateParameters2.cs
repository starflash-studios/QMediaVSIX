// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicQuadLayerUpdateParameters2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;

namespace Windows.Graphics.Holographic
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(1328796461, 33473, 18113, 137, 128, 60, 183, 13, 152, 24, 43)]
  [ExclusiveTo(typeof (HolographicQuadLayerUpdateParameters))]
  internal interface IHolographicQuadLayerUpdateParameters2
  {
    bool CanAcquireWithHardwareProtection { get; }

    IDirect3DSurface AcquireBufferToUpdateContentWithHardwareProtection();
  }
}
