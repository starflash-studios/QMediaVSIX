// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicFrame2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(675231679, 15346, 24209, 102, 51, 135, 5, 116, 230, 242, 23)]
  [ExclusiveTo(typeof (HolographicFrame))]
  internal interface IHolographicFrame2 : IHolographicFrame
  {
    HolographicQuadLayerUpdateParameters GetQuadLayerUpdateParameters(
      HolographicQuadLayer layer);
  }
}
