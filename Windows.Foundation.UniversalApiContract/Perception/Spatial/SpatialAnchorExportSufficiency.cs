// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialAnchorExportSufficiency
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  /// <summary>Represents information about whether a spatial anchor's data is sufficient for sharing or relocalization.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class SpatialAnchorExportSufficiency : ISpatialAnchorExportSufficiency
  {
    /// <summary>Gets whether the spatial anchor has gathered enough data to successfully export for the specified purpose.</summary>
    /// <returns>Whether the export will succeed.</returns>
    public extern bool IsMinimallySufficient { [MethodImpl] get; }

    /// <summary>Gets the amount of data the spatial anchor has gathered relative to the minimal amount needed to successfully export for the specified purpose.</summary>
    /// <returns>The amount of data gathered for this export.</returns>
    public extern double SufficiencyLevel { [MethodImpl] get; }

    /// <summary>Gets the SufficiencyLevel value that is ideal for an export for the specified purpose.</summary>
    /// <returns>The ideal sufficiency level.</returns>
    public extern double RecommendedSufficiencyLevel { [MethodImpl] get; }
  }
}
