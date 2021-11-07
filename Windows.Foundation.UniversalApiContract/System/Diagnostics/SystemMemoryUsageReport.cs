// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.SystemMemoryUsageReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  /// <summary>Provides data about the memory usage of the system.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772164)]
  public sealed class SystemMemoryUsageReport : ISystemMemoryUsageReport
  {
    /// <summary>Get the total amount of physical memory for the system.</summary>
    /// <returns>The total amount of physical memory for the system.</returns>
    public extern ulong TotalPhysicalSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the amount of system memory available in bytes.</summary>
    /// <returns>The amount of system memory available in bytes.</returns>
    public extern ulong AvailableSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the amount of committed memory for the system.</summary>
    /// <returns>The amount of committed memory for the system.</returns>
    public extern ulong CommittedSizeInBytes { [MethodImpl] get; }
  }
}
