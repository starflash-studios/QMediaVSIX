// Decompiled with JetBrains decompiler
// Type: Windows.System.AppDiagnosticInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Contains APIs for getting a basic set of diagnostic information for all running apps.</summary>
  [Static(typeof (IAppDiagnosticInfoStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772164)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IAppDiagnosticInfoStatics2), 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class AppDiagnosticInfo : 
    IAppDiagnosticInfo,
    IAppDiagnosticInfo2,
    IAppDiagnosticInfo3
  {
    /// <summary>Provides info about the app's package family name and package-relative app name.</summary>
    /// <returns>
    /// </returns>
    public extern AppInfo AppInfo { [MethodImpl] get; }

    /// <summary>Gets diagnostic information such as memory usage over time, energy use over time, and so on, for each resource group in the app.</summary>
    /// <returns>Diagnostic info for each resource group in the app.</returns>
    [MethodImpl]
    public extern IVector<AppResourceGroupInfo> GetResourceGroups();

    /// <summary>Creates a **ResourceGroupInfoWatcher** that monitors the execution state of an app or task, and provides notifications when its state changes.</summary>
    /// <returns>A **ResourceGroupInfoWatcher** that can be used to monitor diagnostic info.</returns>
    [MethodImpl]
    public extern AppResourceGroupInfoWatcher CreateResourceGroupWatcher();

    /// <summary>Launches the app associated with the diagnostic info.</summary>
    /// <returns>On success, `AppActivationResult.AppResourceGroupInfo` will correspond to the newly-activated app instance.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppActivationResult> LaunchAsync();

    /// <summary>Creates an **AppDiagnosticInfoWatcher ** that monitors information about the execution state of an app, and provides notifications when its state changes.</summary>
    /// <returns>An **AppDiagnosticInfoWatcher ** that can be used to monitor diagnostic info.</returns>
    [MethodImpl]
    public static extern AppDiagnosticInfoWatcher CreateWatcher();

    /// <summary>Asynchronously requests access to diagnostic information.</summary>
    /// <returns>Returns an async operation with a **DiagnosticAccessStatus ** value indicating the level of diagnostic info available to this app.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<DiagnosticAccessStatus> RequestAccessAsync();

    /// <summary>Gets a collection of AppDiagnosticInfo objects for all instances of the specified app package.</summary>
    /// <param name="packageFamilyName">The identifier of the app package for which to get the AppDiagnosticInfo.</param>
    /// <returns>A collection of AppDiagnosticInfo objects for all instances of the app package specified by *packageFamilyName*.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVector<AppDiagnosticInfo>> RequestInfoForPackageAsync(
      string packageFamilyName);

    /// <summary>Gets a collection of AppDiagnosticInfo objects for all running instances of this app.</summary>
    /// <returns>A collection of AppDiagnosticInfo objects for all running instances of this app.</returns>
    [RemoteAsync]
    [DefaultOverload]
    [Overload("RequestInfoForAppAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVector<AppDiagnosticInfo>> RequestInfoForAppAsync();

    /// <summary>Gets a collection of AppDiagnosticInfo objects for all instances of the specified running app.</summary>
    /// <param name="appUserModelId">The identifier of the running app for which to get the AppDiagnosticInfo.</param>
    /// <returns>A collection of AppDiagnosticInfo objects for all instances of the app specified by *appUserModelId*.</returns>
    [RemoteAsync]
    [Overload("RequestInfoForAppUserModelId")]
    [MethodImpl]
    public static extern IAsyncOperation<IVector<AppDiagnosticInfo>> RequestInfoForAppAsync(
      string appUserModelId);

    /// <summary>Gets a collection of AppDiagnosticInfo objects for all running apps that have a package family name.</summary>
    /// <returns>A list of AppDiagnosticInfo objects for all running apps that have a package family name.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVector<AppDiagnosticInfo>> RequestInfoAsync();
  }
}
