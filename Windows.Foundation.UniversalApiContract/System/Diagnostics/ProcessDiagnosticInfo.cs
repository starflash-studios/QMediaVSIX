// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.ProcessDiagnosticInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  /// <summary>Provides diagnostic information about a process, such as CPU usage, disk usage, memory usage and so on.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IProcessDiagnosticInfoStatics2), 327680, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IProcessDiagnosticInfoStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ProcessDiagnosticInfo : IProcessDiagnosticInfo, IProcessDiagnosticInfo2
  {
    /// <summary>Gets the unique process ID.</summary>
    /// <returns>The unique process ID.</returns>
    public extern uint ProcessId { [MethodImpl] get; }

    /// <summary>Gets the name of the executable file for the process.</summary>
    /// <returns>The name of the executable file for the process.</returns>
    public extern string ExecutableFileName { [MethodImpl] get; }

    /// <summary>Gets the ProcessDiagnosticInfo for the parent process.</summary>
    /// <returns>The ProcessDiagnosticInfo for the parent process.</returns>
    public extern ProcessDiagnosticInfo Parent { [MethodImpl] get; }

    /// <summary>Gets the time the process was started.</summary>
    /// <returns>The time the process was started.</returns>
    public extern DateTime ProcessStartTime { [MethodImpl] get; }

    /// <summary>Gets the disk I/O usage of the process.</summary>
    /// <returns>The disk I/O usage of the process.</returns>
    public extern ProcessDiskUsage DiskUsage { [MethodImpl] get; }

    /// <summary>Gets memory usage data for the process.</summary>
    /// <returns>Memory usage data for the process.</returns>
    public extern ProcessMemoryUsage MemoryUsage { [MethodImpl] get; }

    /// <summary>Gets the CPU time used by the process.</summary>
    /// <returns>The CPU time used by the process.</returns>
    public extern ProcessCpuUsage CpuUsage { [MethodImpl] get; }

    /// <summary>Gets one or more AppDiagnosticInfo objects if the IsPackaged property is **true**.</summary>
    /// <returns>Returns one or more AppDiagnosticInfo objects.</returns>
    [MethodImpl]
    public extern IVector<AppDiagnosticInfo> GetAppDiagnosticInfos();

    /// <summary>Gets a Boolean value indicating whether or not this ProcessDiagnosticInfo instance has any related UWP information.</summary>
    /// <returns>A Boolean value indicating whether or not this ProcessDiagnosticInfo instance has any related UWP information.</returns>
    public extern bool IsPackaged { [MethodImpl] get; }

    /// <summary>Gets a ProcessDiagnosticInfo object for the specified process.</summary>
    /// <param name="processId">The identifier of the process for which to retrieve a ProcessDiagnosticInfo object.</param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public static extern ProcessDiagnosticInfo TryGetForProcessId(
      uint processId);

    /// <summary>Gets a list of ProcessDiagnosticInfo objects for all running processes that are accessible to the caller.</summary>
    /// <returns>A list of ProcessDiagnosticInfo objects for all running processes.</returns>
    [MethodImpl]
    public static extern IVectorView<ProcessDiagnosticInfo> GetForProcesses();

    /// <summary>Gets the ProcessDiagnosticInfo for the currently running process.</summary>
    /// <returns>The ProcessDiagnosticInfo for the currently running process.</returns>
    [MethodImpl]
    public static extern ProcessDiagnosticInfo GetForCurrentProcess();
  }
}
