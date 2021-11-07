// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialLookDirectionRange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  /// <summary>The extent to which the user can look around with their headset.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum SpatialLookDirectionRange
  {
    /// <summary>The user will generally be looking forward as defined by the CoordinateSystem property.</summary>
    ForwardOnly,
    /// <summary>The user may look in any direction.</summary>
    Omnidirectional,
  }
}
