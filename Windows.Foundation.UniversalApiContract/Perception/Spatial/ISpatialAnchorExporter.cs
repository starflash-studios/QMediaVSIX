// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialAnchorExporter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Perception.Spatial
{
  [ExclusiveTo(typeof (SpatialAnchorExporter))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(2586460984, 9467, 17001, 137, 197, 136, 48, 74, 238, 242, 15)]
  internal interface ISpatialAnchorExporter
  {
    [RemoteAsync]
    IAsyncOperation<SpatialAnchorExportSufficiency> GetAnchorExportSufficiencyAsync(
      SpatialAnchor anchor,
      SpatialAnchorExportPurpose purpose);

    [RemoteAsync]
    IAsyncOperation<bool> TryExportAnchorAsync(
      SpatialAnchor anchor,
      SpatialAnchorExportPurpose purpose,
      IOutputStream stream);
  }
}
