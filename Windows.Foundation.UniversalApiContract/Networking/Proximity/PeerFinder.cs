// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.PeerFinder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;

namespace Windows.Networking.Proximity
{
  /// <summary>Enables you to discover other instances of your app on nearby devices and create a socket connection between the peer apps by using a tap gesture or by browsing. For creating Bluetooth socket connections on Windows 8.1 and later, use Windows.Devices.Bluetooth.Rfcomm instead.</summary>
  [Static(typeof (IPeerFinderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPeerFinderStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class PeerFinder
  {
    /// <summary>Gets or sets the role of the app in peer-to-peer connections.</summary>
    /// <returns>The role of the app in peer-to-peer connections.</returns>
    public static extern PeerRole Role { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets user or device data to include during device discovery.</summary>
    /// <returns>User or device data to include during device discovery. Must be less than 32 bytes.</returns>
    public static extern IBuffer DiscoveryData { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Creates a new instance of a PeerWatcher object for dynamic discovery of peer apps.</summary>
    /// <returns>An instance of a PeerWatcher object for dynamic discovery of peer apps.</returns>
    [MethodImpl]
    public static extern PeerWatcher CreateWatcher();

    /// <summary>Specifies whether the PeerFinder class may connect a StreamSocket object by using Bluetooth.</summary>
    /// <returns>True if the PeerFinder class may connect a StreamSocket object by using Bluetooth; otherwise false. The default is true.</returns>
    public static extern bool AllowBluetooth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies whether the PeerFinder class may connect to a StreamSocket object using TCP/IP.</summary>
    /// <returns>True if the PeerFinder class may connect to a StreamSocket object using TCP/IP; otherwise false.</returns>
    public static extern bool AllowInfrastructure { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies whether the PeerFinder class may connect a StreamSocket object by using Wi-Fi Direct.</summary>
    /// <returns>True if the PeerFinder class may connect a StreamSocket object by using Wi-Fi Direct; otherwise false. The default is true.</returns>
    public static extern bool AllowWiFiDirect { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the name that identifies your computer to remote peers.</summary>
    /// <returns>The name that identifies your computer to remote peers.</returns>
    public static extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates which discovery options are available to use with the PeerFinder class.</summary>
    /// <returns>A value that indicates which discovery options are available to use with the PeerFinder class.</returns>
    public static extern PeerDiscoveryTypes SupportedDiscoveryTypes { [MethodImpl] get; }

    /// <summary>Gets a list of alternate appId values to match with peer applications on other platforms.</summary>
    /// <returns>A list of alternate appId values to match with peer applications on other platforms.</returns>
    public static extern IMap<string, string> AlternateIdentities { [MethodImpl] get; }

    /// <summary>Makes an app discoverable to remote peers.</summary>
    [Overload("Start")]
    [MethodImpl]
    public static extern void Start();

    /// <summary>Makes an app discoverable to remote peers.</summary>
    /// <param name="peerMessage">The message to deliver to the proximate device.</param>
    [Overload("StartWithMessage")]
    [MethodImpl]
    public static extern void Start(string peerMessage);

    /// <summary>Stops advertising for a peer connection.</summary>
    [MethodImpl]
    public static extern void Stop();

    /// <summary>Occurs during a tap gesture from a remote peer.</summary>
    public static extern event TypedEventHandler<object, TriggeredConnectionStateChangedEventArgs> TriggeredConnectionStateChanged;

    /// <summary>Occurs when a remote peer requests a connection using the ConnectAsync method.</summary>
    public static extern event TypedEventHandler<object, ConnectionRequestedEventArgs> ConnectionRequested;

    /// <summary>Asynchronously browses for peer devices that are running the same app within wireless range.</summary>
    /// <returns>The asynchronous operation for browsing for peer devices that are running your app.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<PeerInformation>> FindAllPeersAsync();

    /// <summary>Connects to a peer discovered by a call to the FindAllPeersAsync method.</summary>
    /// <param name="peerInformation">A peer information object representing the peer to connect to.</param>
    /// <returns>An asynchronous operation for connecting to a remote peer using the supplied StreamSocket object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StreamSocket> ConnectAsync(
      PeerInformation peerInformation);
  }
}
