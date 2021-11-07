// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.ProcessMemoryUsage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  /// <summary>Provides access to data about the memory usage of a process.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  public sealed class ProcessMemoryUsage : IProcessMemoryUsage
  {
    /// <summary>Gets the ProcessMemoryUsageReport for the process.</summary>
    /// <returns>The ProcessMemoryUsageReport for the process.</returns>
    [MethodImpl]
    public extern ProcessMemoryUsageReport GetReport();
  }
}
