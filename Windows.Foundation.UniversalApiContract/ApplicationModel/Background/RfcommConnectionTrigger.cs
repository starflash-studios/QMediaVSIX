// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.RfcommConnectionTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking;
using Windows.Networking.Sockets;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a trigger that launches a background task when an RFCOMM inbound or outbound connections are established.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class RfcommConnectionTrigger : IRfcommConnectionTrigger, IBackgroundTrigger
  {
    /// <summary>Initializes a new instance of the RfcommConnectionTrigger class.</summary>
    [MethodImpl]
    public extern RfcommConnectionTrigger();

    /// <summary>Gets or sets the RfcommInboundConnectionInformation object that describes how the system will advertise and listen for inbound connections on behalf of the app.</summary>
    /// <returns>The RfcommInboundConnectionInformation object that describes how the system will advertise and listen for inbound connections on behalf of the app. The default is null.</returns>
    public extern RfcommInboundConnectionInformation InboundConnection { [MethodImpl] get; }

    /// <summary>Gets or sets the RfcommOutboundConnectionInformation object that describes how the system will create outgoing connections on behalf of the app.</summary>
    /// <returns>The RfcommOutboundConnectionInformation object that describes how the system will create outgoing connections on behalf of the app. The default is null.</returns>
    public extern RfcommOutboundConnectionInformation OutboundConnection { [MethodImpl] get; }

    /// <summary>Gets or sets whether the app wants to handle multiple connections at a time.</summary>
    /// <returns>True if the app wants to handle multiple connections at a time; Otherwise False. The default is False.</returns>
    public extern bool AllowMultipleConnections { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum protection level required for connections that are created or accepted on behalf of the app.</summary>
    /// <returns>The minimum protection level required for connections that are created or accepted on behalf of the app. The default is BluetoothEncryptionWithAuthentication.</returns>
    public extern SocketProtectionLevel ProtectionLevel { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets specific remote Bluetooth device the system will connect to, or accept connections from, on behalf of the app.</summary>
    /// <returns>Gets or sets specific remote Bluetooth device the system will connect to, or accept connections from, on behalf of the app. If this property is not set, the system will connect to and/or accept connections from any paired Bluetooth device that supports the relevant service.</returns>
    public extern HostName RemoteHostName { [MethodImpl] get; [MethodImpl] set; }
  }
}
