// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialInteractionSourcePositionAccuracy
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  /// <summary>Specifies the accuracy of an interaction source's positional tracking.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum SpatialInteractionSourcePositionAccuracy
  {
    /// <summary>The interaction source's position is being tracked at its nominal accuracy.</summary>
    High,
    /// <summary>The interaction source's position is only being tracked approximately, with either an inferred or body-locked position.</summary>
    Approximate,
  }
}
