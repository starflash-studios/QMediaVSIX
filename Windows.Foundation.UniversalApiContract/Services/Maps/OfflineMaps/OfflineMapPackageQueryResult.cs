// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.OfflineMaps.OfflineMapPackageQueryResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.OfflineMaps
{
  /// <summary>Represents the result of a query for map packages.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class OfflineMapPackageQueryResult : IOfflineMapPackageQueryResult
  {
    /// <summary>Gets the success or failure of the query to find map packages.</summary>
    /// <returns>The status of the query.</returns>
    public extern OfflineMapPackageQueryStatus Status { [MethodImpl] get; }

    /// <summary>Gets the map packages returned by a call to the FindPackagesAsync, FindPackagesInBoundingBoxAsync, and FindPackagesInGeocircleAsync methods.</summary>
    /// <returns>The map packages returned by a call to the FindPackagesAsync, FindPackagesInBoundingBoxAsync, and FindPackagesInGeocircleAsync methods.</returns>
    public extern IVectorView<OfflineMapPackage> Packages { [MethodImpl] get; }
  }
}
