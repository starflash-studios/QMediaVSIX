// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.NetworkUsageStates
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Defines the desired state of the connection profile for which usage data is returned by the method GetNetworkUsageAsync.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct NetworkUsageStates
  {
    /// <summary>Defines the desired roaming state of the network connection.</summary>
    public TriStates Roaming;
    /// <summary>Defines the desired sharing state of the network connection.</summary>
    public TriStates Shared;
  }
}
