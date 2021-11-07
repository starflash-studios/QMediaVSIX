// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.OfflineMaps.OfflineMapPackageStartDownloadStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.OfflineMaps
{
  /// <summary>Specifies the status of an OfflineMapPackageStartDownloadResult.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  public enum OfflineMapPackageStartDownloadStatus
  {
    /// <summary>The operation completed successfully.</summary>
    Success,
    /// <summary>The operation returned an unknown error.</summary>
    UnknownError,
    /// <summary>The credentials used to complete this operation are invalid.</summary>
    InvalidCredentials,
    /// <summary>The ``&lt;uap4:Capability Name="offlineMapsManagement" /&gt;`` has not been added to the package manifest.</summary>
    DeniedWithoutCapability,
  }
}
