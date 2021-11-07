// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialInteractionSourceProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  /// <summary>Represents advanced state of a hand or motion controller.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpatialInteractionSourceProperties : ISpatialInteractionSourceProperties
  {
    /// <summary>Gets the direction you should suggest that the user move their hand or motion controller if it is nearing the edge of the detection area.</summary>
    /// <param name="coordinateSystem">The coordinate system in which to express the mitigation direction.</param>
    /// <returns>The mitigation direction vector, or null if there is no mitigation direction.</returns>
    [MethodImpl]
    public extern IReference<Vector3> TryGetSourceLossMitigationDirection(
      SpatialCoordinateSystem coordinateSystem);

    /// <summary>Gets the risk that detection of a hand or motion controller will be lost as a value from 0.0 to 1.0.</summary>
    /// <returns>The source loss risk.</returns>
    public extern double SourceLossRisk { [MethodImpl] get; }

    /// <summary>Get the position, orientation and velocity of the hand or motion controller, expressed in the specified coordinate system.</summary>
    /// <param name="coordinateSystem">The coordinate system in which to express the hand's location.</param>
    /// <returns>The location.</returns>
    [MethodImpl]
    public extern SpatialInteractionSourceLocation TryGetLocation(
      SpatialCoordinateSystem coordinateSystem);
  }
}
