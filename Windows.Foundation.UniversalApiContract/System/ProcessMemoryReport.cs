// Decompiled with JetBrains decompiler
// Type: Windows.System.ProcessMemoryReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Represents process memory usage at a single point in time.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ProcessMemoryReport : IProcessMemoryReport
  {
    /// <summary>Gets the process' private working set usage.</summary>
    /// <returns>The process' private working set usage.</returns>
    public extern ulong PrivateWorkingSetUsage { [MethodImpl] get; }

    /// <summary>Gets the process' total working set usage.</summary>
    /// <returns>The process' total working set usage.</returns>
    public extern ulong TotalWorkingSetUsage { [MethodImpl] get; }
  }
}
