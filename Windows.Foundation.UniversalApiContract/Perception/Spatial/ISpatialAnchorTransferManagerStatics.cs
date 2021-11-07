// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialAnchorTransferManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Perception.Spatial
{
  [Guid(62650809, 4824, 19406, 136, 53, 197, 223, 58, 192, 173, 171)]
  [ExclusiveTo(typeof (SpatialAnchorTransferManager))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Deprecated("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  internal interface ISpatialAnchorTransferManagerStatics
  {
    [Deprecated("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<IMapView<string, SpatialAnchor>> TryImportAnchorsAsync(
      IInputStream stream);

    [RemoteAsync]
    [Deprecated("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<bool> TryExportAnchorsAsync(
      IIterable<IKeyValuePair<string, SpatialAnchor>> anchors,
      IOutputStream stream);

    [RemoteAsync]
    [Deprecated("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<SpatialPerceptionAccessStatus> RequestAccessAsync();
  }
}
