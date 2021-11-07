// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.OfflineMaps.OfflineMapPackageQueryStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.OfflineMaps
{
  /// <summary>Specifies the status of a OfflineMapPackageQueryResult.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum OfflineMapPackageQueryStatus
  {
    /// <summary>The query completed successfully.</summary>
    Success,
    /// <summary>The query returned an unknown error.</summary>
    UnknownError,
    /// <summary>The credentials used to perform this query are invalid.</summary>
    InvalidCredentials,
    /// <summary>There was a network failure that prevented the query from being completed successfully.</summary>
    NetworkFailure,
  }
}
