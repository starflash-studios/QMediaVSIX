// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialEntity
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [Guid(376301909, 57835, 17740, 186, 8, 230, 192, 102, 141, 220, 101)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (SpatialEntity))]
  internal interface ISpatialEntity
  {
    string Id { get; }

    SpatialAnchor Anchor { get; }

    ValueSet Properties { get; }
  }
}
