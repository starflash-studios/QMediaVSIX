// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialAnchorExportPurpose
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  /// <summary>Specifies the purpose of a given spatial anchor export, sharing or relocalization.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum SpatialAnchorExportPurpose
  {
    /// <summary>This export is to relocalize an existing spatial anchor.</summary>
    Relocalization,
    /// <summary>This export is to share a new spatial anchor.</summary>
    Sharing,
  }
}
