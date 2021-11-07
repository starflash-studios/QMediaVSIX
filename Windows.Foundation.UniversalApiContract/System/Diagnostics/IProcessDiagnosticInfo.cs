// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.IProcessDiagnosticInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ExclusiveTo(typeof (ProcessDiagnosticInfo))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3895504971, 12302, 20198, 160, 171, 91, 95, 82, 49, 180, 52)]
  internal interface IProcessDiagnosticInfo
  {
    uint ProcessId { get; }

    string ExecutableFileName { get; }

    ProcessDiagnosticInfo Parent { get; }

    DateTime ProcessStartTime { get; }

    ProcessDiskUsage DiskUsage { get; }

    ProcessMemoryUsage MemoryUsage { get; }

    ProcessCpuUsage CpuUsage { get; }
  }
}
