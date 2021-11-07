// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.DataPlanStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Represents the current status information for the data plan associated with a connection.</summary>
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DataPlanStatus : IDataPlanStatus
  {
    /// <summary>Gets a DataPlanUsage object that indicates the amount of data transferred over the connection, in megabytes, and the last time this value was refreshed.</summary>
    /// <returns>The data usage and the last updated time.</returns>
    public extern DataPlanUsage DataPlanUsage { [MethodImpl] get; }

    /// <summary>Gets a value indicating the maximum data transfer allowance for a connection within each billing cycle, as defined by the data plan.</summary>
    /// <returns>The maximum number of megabytes allowed as defined by the network carrier.</returns>
    public extern IReference<uint> DataLimitInMegabytes { [MethodImpl] get; }

    /// <summary>Gets a value indicating the nominal rate of the inbound data transfer occurring on the connection.</summary>
    /// <returns>The rate of inbound data transfer.</returns>
    public extern IReference<ulong> InboundBitsPerSecond { [MethodImpl] get; }

    /// <summary>Gets a value indicating the nominal rate of the outbound data transfer.</summary>
    /// <returns>The outbound data transfer rate.</returns>
    public extern IReference<ulong> OutboundBitsPerSecond { [MethodImpl] get; }

    /// <summary>Gets a value indicating the date and time of the next billing cycle.</summary>
    /// <returns>The date and time of the next billing cycle.</returns>
    public extern IReference<DateTime> NextBillingCycle { [MethodImpl] get; }

    /// <summary>Gets a value indicates the maximum size of a transfer that is allowed without user consent on a metered network.</summary>
    /// <returns>The maximum size of a transfer that is allowed without user consent on a metered network.</returns>
    public extern IReference<uint> MaxTransferSizeInMegabytes { [MethodImpl] get; }
  }
}
