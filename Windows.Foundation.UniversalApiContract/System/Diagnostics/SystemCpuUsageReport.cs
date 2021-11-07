﻿// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.SystemCpuUsageReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  /// <summary>Provides data about the CPU usage of the system.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SystemCpuUsageReport : ISystemCpuUsageReport
  {
    /// <summary>Gets the amount of CPU kernel time consumed by the system.</summary>
    /// <returns>The amount of CPU kernel time consumed by the system.</returns>
    public extern TimeSpan KernelTime { [MethodImpl] get; }

    /// <summary>Gets the amount of CPU user time consumed by the system.</summary>
    /// <returns>The amount of CPU user time consumed by the system.</returns>
    public extern TimeSpan UserTime { [MethodImpl] get; }

    /// <summary>Gets the amount of time the CPU was idle.</summary>
    /// <returns>The amount of time the CPU was idle.</returns>
    public extern TimeSpan IdleTime { [MethodImpl] get; }
  }
}