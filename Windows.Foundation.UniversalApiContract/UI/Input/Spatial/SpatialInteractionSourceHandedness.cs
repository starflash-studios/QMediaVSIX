// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialInteractionSourceHandedness
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  /// <summary>Specifies whether the interaction source represents the user's left hand or right hand.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum SpatialInteractionSourceHandedness
  {
    /// <summary>The interaction source does not represent a specific hand.</summary>
    Unspecified,
    /// <summary>The interaction source represents the user's left hand.</summary>
    Left,
    /// <summary>The interaction source represents the user's right hand.</summary>
    Right,
  }
}
