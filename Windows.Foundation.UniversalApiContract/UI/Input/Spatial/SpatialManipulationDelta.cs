// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialManipulationDelta
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Spatial
{
  /// <summary>Represents the relative motion of the hand since the start of a Manipulation gesture.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpatialManipulationDelta : ISpatialManipulationDelta
  {
    /// <summary>Get the relative translation of the hand since the start of a Manipulation gesture.</summary>
    /// <returns>The translation.</returns>
    public extern Vector3 Translation { [MethodImpl] get; }
  }
}
