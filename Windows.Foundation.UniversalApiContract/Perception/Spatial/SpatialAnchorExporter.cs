// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialAnchorExporter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Perception.Spatial
{
  /// <summary>Allows apps to export spatial anchors for sharing and relocalization across devices, so that both devices can reason about the same locations in their users' surroundings.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISpatialAnchorExporterStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Threading(ThreadingModel.Both)]
  public sealed class SpatialAnchorExporter : ISpatialAnchorExporter
  {
    /// <summary>Returns information about whether a spatial anchor's data is sufficient for sharing or relocalization.</summary>
    /// <param name="anchor">The spatial anchor that will be exported.</param>
    /// <param name="purpose">The purpose of the export, sharing or relocalization.</param>
    /// <returns>The anchor's export sufficiency.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SpatialAnchorExportSufficiency> GetAnchorExportSufficiencyAsync(
      SpatialAnchor anchor,
      SpatialAnchorExportPurpose purpose);

    /// <summary>Exports a spatial anchor to a stream for sharing or relocalization. This allows multiple devices to reason about the same locations in their users' surroundings.</summary>
    /// <param name="anchor">The spatial anchor to export.</param>
    /// <param name="purpose">The purpose of the export, sharing or relocalization.</param>
    /// <param name="stream">The stream to export the anchor to.</param>
    /// <returns>Operation that triggers once the export has been attempted, providing true if the export succeeded; otherwise, false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryExportAnchorAsync(
      SpatialAnchor anchor,
      SpatialAnchorExportPurpose purpose,
      IOutputStream stream);

    /// <summary>Gets the default **SpatialAnchorExporter** instance for the current device.</summary>
    /// <returns>The exporter.</returns>
    [MethodImpl]
    public static extern SpatialAnchorExporter GetDefault();

    /// <summary>Requests access for an app to export spatial anchors. This requires the **spatialPerception** capability.</summary>
    /// <returns>Operation that triggers once the user has completed any consent dialog, providing the access status.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SpatialPerceptionAccessStatus> RequestAccessAsync();
  }
}
