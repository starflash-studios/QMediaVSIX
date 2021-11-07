// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.OfflineMaps.OfflineMapPackageStartDownloadResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.OfflineMaps
{
  /// <summary>Represents the result of an asynchronous request to queue the download of a map package onto the local system.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class OfflineMapPackageStartDownloadResult : IOfflineMapPackageStartDownloadResult
  {
    /// <summary>Gets the status of an asynchronous request to download a map package onto the local system.</summary>
    /// <returns>The status of an asynchronous request to download a map package onto the local system.</returns>
    public extern OfflineMapPackageStartDownloadStatus Status { [MethodImpl] get; }
  }
}
