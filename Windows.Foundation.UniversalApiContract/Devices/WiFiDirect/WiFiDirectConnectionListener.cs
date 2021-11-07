// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.WiFiDirectConnectionListener
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  /// <summary>Class used to listen for incoming Wi-Fi Direct connection requests.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class WiFiDirectConnectionListener : IWiFiDirectConnectionListener
  {
    /// <summary>Creates a new WiFiDirectConnectionListener object.</summary>
    [MethodImpl]
    public extern WiFiDirectConnectionListener();

    /// <summary>Notification on an incoming Wi-Fi Direct connection request.</summary>
    public extern event TypedEventHandler<WiFiDirectConnectionListener, WiFiDirectConnectionRequestedEventArgs> ConnectionRequested;
  }
}
