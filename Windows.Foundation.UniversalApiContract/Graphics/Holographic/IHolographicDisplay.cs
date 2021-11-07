// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicDisplay
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.Graphics.Holographic
{
  [ExclusiveTo(typeof (HolographicDisplay))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2597233684, 7583, 16528, 163, 136, 144, 192, 111, 110, 174, 156)]
  internal interface IHolographicDisplay
  {
    string DisplayName { get; }

    Size MaxViewportSize { get; }

    bool IsStereo { get; }

    bool IsOpaque { get; }

    HolographicAdapterId AdapterId { get; }

    SpatialLocator SpatialLocator { get; }
  }
}
