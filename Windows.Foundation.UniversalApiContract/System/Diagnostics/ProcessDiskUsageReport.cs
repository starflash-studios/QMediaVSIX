// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.ProcessDiskUsageReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  /// <summary>Provides data about the disk usage of the process.</summary>
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ProcessDiskUsageReport : IProcessDiskUsageReport
  {
    /// <summary>Gets the number of disk read operations performed by the process.</summary>
    /// <returns>The number of disk read operations performed by the process.</returns>
    public extern long ReadOperationCount { [MethodImpl] get; }

    /// <summary>Gets the number of disk write operations performed by the process.</summary>
    /// <returns>The number of disk write operations performed by the process.</returns>
    public extern long WriteOperationCount { [MethodImpl] get; }

    /// <summary>Gets the number of disk operations performed by the process that were not read or write operations.</summary>
    /// <returns>The number of disk operations performed by the process that were not read or write operations.</returns>
    public extern long OtherOperationCount { [MethodImpl] get; }

    /// <summary>Gets the number of bytes the process has read from disk.</summary>
    /// <returns>The number of bytes the process has read from disk.</returns>
    public extern long BytesReadCount { [MethodImpl] get; }

    /// <summary>Gets the number of bytes the process has written to disk.</summary>
    /// <returns>The number of bytes the process has written to disk.</returns>
    public extern long BytesWrittenCount { [MethodImpl] get; }

    /// <summary>Gets the number of bytes used by the process in disk operations that were not read or write operations.</summary>
    /// <returns>The number of bytes used by the process in disk operations that were not read or write operations.</returns>
    public extern long OtherBytesCount { [MethodImpl] get; }
  }
}
