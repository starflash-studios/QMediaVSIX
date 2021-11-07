// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.ConnectionCost
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Provides access to property values that indicate the current cost of a network connection.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class ConnectionCost : IConnectionCost, IConnectionCost2
  {
    /// <summary>Gets a value that indicates the current network cost for a connection.</summary>
    /// <returns>The network cost of the connection.</returns>
    public extern NetworkCostType NetworkCostType { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the connection is connected to a network outside of the home provider.</summary>
    /// <returns>TRUE if the connection on a roaming network; otherwise, FALSE.</returns>
    public extern bool Roaming { [MethodImpl] get; }

    /// <summary>Gets a value that indicates if the connection has exceeded the data usage allowance specified by the data plan.</summary>
    /// <returns>TRUE if the current total data usage is over the specified data limit; otherwise, FALSE.</returns>
    public extern bool OverDataLimit { [MethodImpl] get; }

    /// <summary>Gets a value that indicates if a connection is approaching the data usage allowance specified by the data plan.</summary>
    /// <returns>TRUE if the connection profile is close to the data limit threshold; otherwise, FALSE.</returns>
    public extern bool ApproachingDataLimit { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether background data usage has been restricted.</summary>
    /// <returns>True if background data usage is restricted.</returns>
    public extern bool BackgroundDataUsageRestricted { [MethodImpl] get; }
  }
}
