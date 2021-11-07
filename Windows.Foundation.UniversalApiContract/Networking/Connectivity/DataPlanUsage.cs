// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.DataPlanUsage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Represents data plan specific data usage information for a connection.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DataPlanUsage : IDataPlanUsage
  {
    /// <summary>Gets a value indicating the total amount of data transferred, in megabytes, over the connection.</summary>
    /// <returns>The number of megabytes of data transferred.</returns>
    public extern uint MegabytesUsed { [MethodImpl] get; }

    /// <summary>Gets a DateTime object indicating the date and time when the MegabytesUsed property was last updated.</summary>
    /// <returns>The date and time when the **MegabytesUsed** property was last updated.</returns>
    public extern DateTime LastSyncTime { [MethodImpl] get; }
  }
}
