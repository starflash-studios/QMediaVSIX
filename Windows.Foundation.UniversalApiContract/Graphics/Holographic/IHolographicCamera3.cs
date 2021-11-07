// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicCamera3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [ExclusiveTo(typeof (HolographicCamera))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1168789427, 31577, 21070, 74, 63, 74, 106, 214, 101, 4, 119)]
  internal interface IHolographicCamera3 : IHolographicCamera2, IHolographicCamera
  {
    bool IsPrimaryLayerEnabled { get; set; }

    uint MaxQuadLayerCount { get; }

    IVector<HolographicQuadLayer> QuadLayers { get; }
  }
}
