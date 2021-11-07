// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.OfflineMaps.OfflineMapPackageStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.OfflineMaps
{
  /// <summary>Specifies the status of a OfflineMapPackage.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum OfflineMapPackageStatus
  {
    /// <summary>The map package is not downloaded to the local system.</summary>
    NotDownloaded,
    /// <summary>The map packaging is currently downloading to the local system.</summary>
    Downloading,
    /// <summary>The map package is downloaded to the local system.</summary>
    Downloaded,
    /// <summary>The map package is being deleted from the local system.</summary>
    Deleting,
  }
}
