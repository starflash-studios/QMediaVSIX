// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.IProcessMemoryUsageReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ExclusiveTo(typeof (ProcessMemoryUsageReport))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3267853498, 6481, 18053, 133, 50, 126, 116, 158, 207, 142, 235)]
  internal interface IProcessMemoryUsageReport
  {
    ulong NonPagedPoolSizeInBytes { get; }

    uint PageFaultCount { get; }

    ulong PageFileSizeInBytes { get; }

    ulong PagedPoolSizeInBytes { get; }

    ulong PeakNonPagedPoolSizeInBytes { get; }

    ulong PeakPageFileSizeInBytes { get; }

    ulong PeakPagedPoolSizeInBytes { get; }

    ulong PeakVirtualMemorySizeInBytes { get; }

    ulong PeakWorkingSetSizeInBytes { get; }

    ulong PrivatePageCount { get; }

    ulong VirtualMemorySizeInBytes { get; }

    ulong WorkingSetSizeInBytes { get; }
  }
}
