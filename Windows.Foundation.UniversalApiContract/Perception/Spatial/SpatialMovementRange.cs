// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialMovementRange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  /// <summary>The extent to which the user can move while wearing their headset.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum SpatialMovementRange
  {
    /// <summary>The user can stand but has not defined a boundary within which they intend to walk while using the headset.</summary>
    NoMovement,
    /// <summary>The user can walk around within the bounds returned by TryGetMovementBounds.</summary>
    Bounded,
  }
}
