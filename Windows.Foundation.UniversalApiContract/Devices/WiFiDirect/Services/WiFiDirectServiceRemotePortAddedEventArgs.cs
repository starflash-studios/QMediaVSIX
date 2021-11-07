// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.WiFiDirectServiceRemotePortAddedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.Devices.WiFiDirect.Services
{
  /// <summary>Returned when a WiFiDirectServiceSession.RemotePortAdded event is raised. Your event handler should use this information to establish new socket connections to the new port.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WiFiDirectServiceRemotePortAddedEventArgs : 
    IWiFiDirectServiceRemotePortAddedEventArgs
  {
    /// <summary>Gets the endpoint pairs associated with the new remote port.</summary>
    /// <returns>New endpoint pairs.</returns>
    public extern IVectorView<EndpointPair> EndpointPairs { [MethodImpl] get; }

    /// <summary>Gets the protocol used to communicate with the new remote port.</summary>
    /// <returns>An enumeration value corresponding to the IP protocol to use for the new remote port.</returns>
    public extern WiFiDirectServiceIPProtocol Protocol { [MethodImpl] get; }
  }
}
