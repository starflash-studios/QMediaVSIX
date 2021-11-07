// Decompiled with JetBrains decompiler
// Type: Windows.System.AppResourceGroupMemoryReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Provides memory information for a resource group, such as commit usage.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772164)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class AppResourceGroupMemoryReport : IAppResourceGroupMemoryReport
  {
    /// <summary>Gets the limit of the amount of memory that can be committed (allocated) by this resource group.</summary>
    /// <returns>The maximum amount of memory that is available for allocation.</returns>
    public extern ulong CommitUsageLimit { [MethodImpl] get; }

    /// <summary>Returns the commit usage level for the resource group.</summary>
    /// <returns>The amount of memory that has been allocated a data storage location as opposed to simply being reserved for future allocation.</returns>
    public extern AppMemoryUsageLevel CommitUsageLevel { [MethodImpl] get; }

    /// <summary>Gets the amount of private memory (memory that can't be shared between processes) committed by this resource group.</summary>
    /// <returns>The amount of private commit memory.</returns>
    public extern ulong PrivateCommitUsage { [MethodImpl] get; }

    /// <summary>Gets the total amount of memory committed by this resource group.</summary>
    /// <returns>The total amount of committed memory.</returns>
    public extern ulong TotalCommitUsage { [MethodImpl] get; }
  }
}
