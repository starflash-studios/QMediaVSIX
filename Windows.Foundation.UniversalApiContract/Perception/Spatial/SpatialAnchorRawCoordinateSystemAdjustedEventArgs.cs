// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialAnchorRawCoordinateSystemAdjustedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  /// <summary>Provides data for the SpatialAnchor.RawCoordinateSystemAdjusted event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  public sealed class SpatialAnchorRawCoordinateSystemAdjustedEventArgs : 
    ISpatialAnchorRawCoordinateSystemAdjustedEventArgs
  {
    /// <summary>Gets a transform representing the adjustment of this SpatialAnchor relative to its previous location.</summary>
    /// <returns>The transform.</returns>
    public extern Matrix4x4 OldRawCoordinateSystemToNewRawCoordinateSystemTransform { [MethodImpl] get; }
  }
}
