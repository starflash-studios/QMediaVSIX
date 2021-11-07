// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialAnchor2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (SpatialAnchor))]
  [Guid(3977758984, 42645, 19702, 146, 253, 151, 38, 59, 167, 16, 71)]
  internal interface ISpatialAnchor2
  {
    bool RemovedByUser { get; }
  }
}
