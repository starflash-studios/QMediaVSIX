// Decompiled with JetBrains decompiler
// Type: Windows.System.AppResourceGroupInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System.Diagnostics;

namespace Windows.System
{
  /// <summary>Provides diagnostic information such as memory usage and energy use.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772164)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppResourceGroupInfo : IAppResourceGroupInfo, IAppResourceGroupInfo2
  {
    /// <summary>Gets the instance identifier.</summary>
    /// <returns>The instance ID.</returns>
    public extern Guid InstanceId { [MethodImpl] get; }

    /// <summary>Indicates whether the group is part of a shared resource group. Being part of a shared resource group indicates that there are multiple apps in the package and that they share a common component.</summary>
    /// <returns>**True** means the group is part of a shared resource group; **false**, otherwise.</returns>
    public extern bool IsShared { [MethodImpl] get; }

    /// <summary>Provides information about background tasks such as their entry points, names, task ids, and trigger names.</summary>
    /// <returns>Information about each background task.</returns>
    [MethodImpl]
    public extern IVector<AppResourceGroupBackgroundTaskReport> GetBackgroundTaskReports();

    /// <summary>Provides information about memory usage such as the commit limit, commit usage, and so on.</summary>
    /// <returns>Information about memory usage.</returns>
    [MethodImpl]
    public extern AppResourceGroupMemoryReport GetMemoryReport();

    /// <summary>Gets process diagnostic information for the group such as used CPU time, disk I/O usage, and so on.</summary>
    /// <returns>The process diagnostic info.</returns>
    [MethodImpl]
    public extern IVector<ProcessDiagnosticInfo> GetProcessDiagnosticInfos();

    /// <summary>Gets the state report information such as execution state, energy quota state, and so on.</summary>
    /// <returns>The state info.</returns>
    [MethodImpl]
    public extern AppResourceGroupStateReport GetStateReport();

    /// <summary>Initiate moving the associated app to the suspended state.</summary>
    /// <returns>The result of trying to suspend the app.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppExecutionStateChangeResult> StartSuspendAsync();

    /// <summary>Initiate moving the associated app to the active state.</summary>
    /// <returns>The result of trying to resume the app.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppExecutionStateChangeResult> StartResumeAsync();

    /// <summary>Initiate moving the associated app to the terminated state.</summary>
    /// <returns>The result of trying to terminate the app.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppExecutionStateChangeResult> StartTerminateAsync();
  }
}
