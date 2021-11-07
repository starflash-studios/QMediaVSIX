// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialAnchorStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  /// <summary>Represents a collection of SpatialAnchor objects stored by Windows on behalf of an app.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpatialAnchorStore : ISpatialAnchorStore
  {
    /// <summary>Gets a map of all anchors saved in the store, with their identifiers as the keys.</summary>
    /// <returns>The map of anchors.</returns>
    [MethodImpl]
    public extern IMapView<string, SpatialAnchor> GetAllSavedAnchors();

    /// <summary>Persists an anchor to the store.</summary>
    /// <param name="id">An identifier for the anchor. The identifier must be unique within your app.</param>
    /// <param name="anchor">The anchor to save.</param>
    /// <returns>True, if the save succeeded; otherwise, false.</returns>
    [MethodImpl]
    public extern bool TrySave(string id, SpatialAnchor anchor);

    /// <summary>Removes a specific anchor from the store. The anchor is specified by its identifier.</summary>
    /// <param name="id">The identifier of the anchor to remove.</param>
    [MethodImpl]
    public extern void Remove(string id);

    /// <summary>Clears all anchors in the app's anchor store.</summary>
    [MethodImpl]
    public extern void Clear();
  }
}
