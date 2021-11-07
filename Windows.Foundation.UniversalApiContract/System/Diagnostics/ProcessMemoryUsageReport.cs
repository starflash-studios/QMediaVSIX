// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.ProcessMemoryUsageReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  /// <summary>Provides data about the memory usage of the process.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ProcessMemoryUsageReport : IProcessMemoryUsageReport
  {
    /// <summary>Gets the amount of non-paged memory available to the process, in bytes.</summary>
    /// <returns>The amount of non-paged memory available to the process, in bytes.</returns>
    public extern ulong NonPagedPoolSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the number of memory page faults.</summary>
    /// <returns>The number of memory page faults.</returns>
    public extern uint PageFaultCount { [MethodImpl] get; }

    /// <summary>Gets the size of the memory page file in bytes.</summary>
    /// <returns>The size of the memory page file in bytes.</returns>
    public extern ulong PageFileSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the amount of paged memory available to the process, in bytes.</summary>
    /// <returns>The amount of memory, in bytes, allocated by the associated process that can be written to the virtual memory paging file.</returns>
    public extern ulong PagedPoolSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the maximum amount of non-paged memory used by the process, in bytes.</summary>
    /// <returns>The maximum amount of non-paged memory used by the process, in bytes.</returns>
    public extern ulong PeakNonPagedPoolSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the maximum size of the memory page file used by the process, in bytes.</summary>
    /// <returns>The maximum size of the memory page file used by the process, in bytes.</returns>
    public extern ulong PeakPageFileSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the maximum amount of paged memory used by the process, in bytes.</summary>
    /// <returns>The maximum amount of paged memory used by the process, in bytes.</returns>
    public extern ulong PeakPagedPoolSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the maximum amount of virtual memory used by the associated process.</summary>
    /// <returns>The maximum amount of virtual memory, in bytes, allocated for the associated process since it was started.</returns>
    public extern ulong PeakVirtualMemorySizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the maximum amount of physical memory used by the associated process.</summary>
    /// <returns>The maximum amount of physical memory, in bytes, allocated for the associated process since it was started.</returns>
    public extern ulong PeakWorkingSetSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the number of private memory pages allocated for the associated process.</summary>
    /// <returns>The number of private memory pages allocated for the associated process.</returns>
    public extern ulong PrivatePageCount { [MethodImpl] get; }

    /// <summary>Gets the amount of the virtual memory allocated for the associated process.</summary>
    /// <returns>The amount of virtual memory, in bytes, allocated for the associated process.</returns>
    public extern ulong VirtualMemorySizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the amount of physical memory allocated for the associated process.</summary>
    /// <returns>The amount of physical memory, in bytes, allocated for the associated process.</returns>
    public extern ulong WorkingSetSizeInBytes { [MethodImpl] get; }
  }
}
