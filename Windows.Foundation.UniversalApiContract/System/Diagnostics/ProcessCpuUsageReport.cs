// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.ProcessCpuUsageReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  /// <summary>Provides data about the CPU usage of the process.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ProcessCpuUsageReport : IProcessCpuUsageReport
  {
    /// <summary>Gets the amount of CPU kernel time consumed by the process.</summary>
    /// <returns>The amount of CPU kernel time consumed by the process.</returns>
    public extern TimeSpan KernelTime { [MethodImpl] get; }

    /// <summary>Gets the amount of CPU user time consumed by the process.</summary>
    /// <returns>The amount of CPU user time consumed by the process.</returns>
    public extern TimeSpan UserTime { [MethodImpl] get; }
  }
}
