// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialManipulationCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  /// <summary>Provides data for the SpatialGestureRecognizer.ManipulationCompleted event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpatialManipulationCompletedEventArgs : ISpatialManipulationCompletedEventArgs
  {
    /// <summary>Gets the kind of interaction source associated with this gesture.</summary>
    /// <returns>The interaction source kind.</returns>
    public extern SpatialInteractionSourceKind InteractionSourceKind { [MethodImpl] get; }

    /// <summary>Get the relative motion of the hand since the start of the Manipulation gesture.</summary>
    /// <param name="coordinateSystem">The coordinate system in which to express the delta.</param>
    /// <returns>The delta.</returns>
    [MethodImpl]
    public extern SpatialManipulationDelta TryGetCumulativeDelta(
      SpatialCoordinateSystem coordinateSystem);
  }
}
