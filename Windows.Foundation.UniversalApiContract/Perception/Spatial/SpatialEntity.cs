// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialEntity
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  /// <summary>Represents a physical location in the user's surroundings and its metadata, which an app intends to share with other devices.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ISpatialEntityFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.Both)]
  public sealed class SpatialEntity : ISpatialEntity
  {
    /// <summary>Creates a new spatial entity to share the provided spatial anchor.</summary>
    /// <param name="spatialAnchor">The spatial anchor to share.</param>
    [MethodImpl]
    public extern SpatialEntity(SpatialAnchor spatialAnchor);

    /// <summary>Creates a new spatial entity to share the provided spatial anchor and metadata.</summary>
    /// <param name="spatialAnchor">The spatial anchor to share.</param>
    /// <param name="propertySet">The metadata to share for this anchor.</param>
    [MethodImpl]
    public extern SpatialEntity(SpatialAnchor spatialAnchor, ValueSet propertySet);

    /// <summary>Gets the globally-unique ID for this spatial entity.</summary>
    /// <returns>The ID.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets the spatial anchor representing the shared location in the user's surroundings.</summary>
    /// <returns>The anchor.</returns>
    public extern SpatialAnchor Anchor { [MethodImpl] get; }

    /// <summary>Gets the key/value store of metadata for this spatial entity.</summary>
    /// <returns>The metadata.</returns>
    public extern ValueSet Properties { [MethodImpl] get; }
  }
}
