// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.WlanConnectionProfileDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Used to access information specific to a WLAN connection.</summary>
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WlanConnectionProfileDetails : IWlanConnectionProfileDetails
  {
    /// <summary>Retrieves the Service Set Identifier (SSID) for a WLAN connection.</summary>
    /// <returns>The service set identifier (SSID).</returns>
    [MethodImpl]
    public extern string GetConnectedSsid();
  }
}
