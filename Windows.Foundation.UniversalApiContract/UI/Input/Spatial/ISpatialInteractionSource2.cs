// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionSource2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception;

namespace Windows.UI.Input.Spatial
{
  [ExclusiveTo(typeof (SpatialInteractionSource))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3838162700, 1136, 16424, 136, 192, 160, 235, 68, 211, 78, 254)]
  internal interface ISpatialInteractionSource2 : ISpatialInteractionSource
  {
    bool IsPointingSupported { get; }

    bool IsMenuSupported { get; }

    bool IsGraspSupported { get; }

    SpatialInteractionController Controller { get; }

    SpatialInteractionSourceState TryGetStateAtTimestamp(
      PerceptionTimestamp timestamp);
  }
}
