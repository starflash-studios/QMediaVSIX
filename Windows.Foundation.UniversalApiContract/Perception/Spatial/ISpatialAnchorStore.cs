// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialAnchorStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [Guid(2965124662, 18538, 15536, 158, 111, 18, 69, 22, 92, 77, 182)]
  [ExclusiveTo(typeof (SpatialAnchorStore))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialAnchorStore
  {
    IMapView<string, SpatialAnchor> GetAllSavedAnchors();

    bool TrySave(string id, SpatialAnchor anchor);

    void Remove(string id);

    void Clear();
  }
}
