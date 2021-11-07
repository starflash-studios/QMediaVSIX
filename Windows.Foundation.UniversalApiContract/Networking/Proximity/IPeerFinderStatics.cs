// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.IPeerFinderStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;

namespace Windows.Networking.Proximity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2437626721, 63201, 18372, 161, 76, 20, 138, 25, 3, 208, 198)]
  [ExclusiveTo(typeof (PeerFinder))]
  internal interface IPeerFinderStatics
  {
    bool AllowBluetooth { get; set; }

    bool AllowInfrastructure { get; set; }

    bool AllowWiFiDirect { get; set; }

    string DisplayName { get; set; }

    PeerDiscoveryTypes SupportedDiscoveryTypes { get; }

    IMap<string, string> AlternateIdentities { get; }

    [Overload("Start")]
    void Start();

    [Overload("StartWithMessage")]
    void Start(string peerMessage);

    void Stop();

    event TypedEventHandler<object, TriggeredConnectionStateChangedEventArgs> TriggeredConnectionStateChanged;

    event TypedEventHandler<object, ConnectionRequestedEventArgs> ConnectionRequested;

    [RemoteAsync]
    IAsyncOperation<IVectorView<PeerInformation>> FindAllPeersAsync();

    [RemoteAsync]
    IAsyncOperation<StreamSocket> ConnectAsync(
      PeerInformation peerInformation);
  }
}
