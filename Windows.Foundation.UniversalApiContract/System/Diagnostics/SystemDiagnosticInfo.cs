// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.SystemDiagnosticInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  /// <summary>Provides diagnostic information about the system, such as CPU usage, disk usage, memory usage and so on.</summary>
  [Static(typeof (ISystemDiagnosticInfoStatics2), 720896, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772164)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (ISystemDiagnosticInfoStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SystemDiagnosticInfo : ISystemDiagnosticInfo
  {
    /// <summary>Gets memory usage data for the system.</summary>
    /// <returns>Memory usage data for the system.</returns>
    public extern SystemMemoryUsage MemoryUsage { [MethodImpl] get; }

    /// <summary>Gets the CPU time used by the system.</summary>
    /// <returns>The CPU time used by the system.</returns>
    public extern SystemCpuUsage CpuUsage { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool IsArchitectureSupported(ProcessorArchitecture type);

    public static extern ProcessorArchitecture PreferredArchitecture { [MethodImpl] get; }

    /// <summary>Gets the SystemDiagnosticInfo for the current system.</summary>
    /// <returns>The SystemDiagnosticInfo for the current system.</returns>
    [MethodImpl]
    public static extern SystemDiagnosticInfo GetForCurrentSystem();
  }
}
