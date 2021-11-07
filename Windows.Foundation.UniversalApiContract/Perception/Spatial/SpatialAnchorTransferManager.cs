// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialAnchorTransferManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Perception.Spatial
{
  /// <summary>Static methods for transferring spatial anchors between devices, so that both devices can reason about the same locations in their users' surroundings.</summary>
  /// <deprecated type="deprecate">Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.</deprecated>
  [Static(typeof (ISpatialAnchorTransferManagerStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [Deprecated("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  public static class SpatialAnchorTransferManager
  {
    /// <summary>Imports a stream of spatial anchors that was previously exported from another device. This allows both devices to reason about the same locations in their users' surroundings.</summary>
    /// <deprecated type="deprecate">Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.</deprecated>
    /// <param name="stream">The stream to import anchors from.</param>
    /// <returns>The operation that triggers once the import is complete, providing the imported anchors.</returns>
    [Deprecated("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IMapView<string, SpatialAnchor>> TryImportAnchorsAsync(
      IInputStream stream);

    [Deprecated("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> TryExportAnchorsAsync(
      IIterable<IKeyValuePair<string, SpatialAnchor>> anchors,
      IOutputStream stream);

    /// <summary>Requests access for an app to export or import spatial anchors. This requires the spatialPerception capability.</summary>
    /// <deprecated type="deprecate">Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.</deprecated>
    /// <returns>Operation that triggers once the user has completed any consent dialog, providing the access status.</returns>
    [Deprecated("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SpatialPerceptionAccessStatus> RequestAccessAsync();
  }
}
