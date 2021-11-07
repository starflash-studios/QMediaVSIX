// Decompiled with JetBrains decompiler
// Type: Windows.System.AppResourceGroupStateReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Provides information, such as the execution state and energy quota usage, for a resource group.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  public sealed class AppResourceGroupStateReport : IAppResourceGroupStateReport
  {
    /// <summary>Gets the execution state of the resource group, such as whether it is suspended, running, and so on.</summary>
    /// <returns>The execution state.</returns>
    public extern AppResourceGroupExecutionState ExecutionState { [MethodImpl] get; }

    /// <summary>Gets the energy quota state of the resource group, such as whether it is under quota or over quota.</summary>
    /// <returns>The energy quota state.</returns>
    public extern AppResourceGroupEnergyQuotaState EnergyQuotaState { [MethodImpl] get; }
  }
}
