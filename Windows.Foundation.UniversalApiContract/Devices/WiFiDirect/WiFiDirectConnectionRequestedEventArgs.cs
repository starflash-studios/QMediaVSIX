// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.WiFiDirectConnectionRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  /// <summary>Provides data for a ConnectionRequested event on a WiFiDirectConnectionListener.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WiFiDirectConnectionRequestedEventArgs : 
    IWiFiDirectConnectionRequestedEventArgs
  {
    /// <summary>Retrieves the WiFiDirectConnectionRequest received on a ConnectionRequested event by a WiFiDirectConnectionListener.</summary>
    /// <returns>The Wi-FI Direct connection request.</returns>
    [MethodImpl]
    public extern WiFiDirectConnectionRequest GetConnectionRequest();
  }
}
