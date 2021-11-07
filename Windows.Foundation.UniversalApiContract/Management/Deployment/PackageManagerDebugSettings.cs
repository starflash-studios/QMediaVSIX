// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.PackageManagerDebugSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  /// <summary>Settings for debugging app packages.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.Both)]
  public sealed class PackageManagerDebugSettings : IPackageManagerDebugSettings
  {
    /// <summary>Sets the staging state of a content group for debugging.</summary>
    /// <param name="package">The app package.</param>
    /// <param name="contentGroupName">The content group name. An AppxContentGroupMap.xml must be present when the app is registered for this API to work.</param>
    /// <param name="state">The PackageContentGroupState enum value.</param>
    /// <returns>Returns an IAsyncAction that completes when the state has changed.</returns>
    [RemoteAsync]
    [Overload("SetContentGroupStateAsync")]
    [MethodImpl]
    public extern IAsyncAction SetContentGroupStateAsync(
      Package package,
      string contentGroupName,
      PackageContentGroupState state);

    /// <summary>Sets the staging state of a content group for debugging.</summary>
    /// <param name="package">The app package.</param>
    /// <param name="contentGroupName">The content group name. An AppxContentGroupMap.xml must be present when the app is registered for this API to work.</param>
    /// <param name="state">The PackageContentGroupState enum value.</param>
    /// <param name="completionPercentage">The simulated percent install completion. A value between 0 and 100.0. A value greater than 100 is clamped to 100.</param>
    /// <returns>Returns an IAsyncAction that completes when the state has changed.</returns>
    [Overload("SetContentGroupStateWithPercentageAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetContentGroupStateAsync(
      Package package,
      string contentGroupName,
      PackageContentGroupState state,
      double completionPercentage);
  }
}
