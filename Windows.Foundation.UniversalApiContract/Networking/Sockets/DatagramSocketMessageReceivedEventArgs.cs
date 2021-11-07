// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.DatagramSocketMessageReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  /// <summary>Provides data for a MessageReceived event on a DatagramSocket.</summary>
  [GCPressure(amount = GCPressureAmount.Medium)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DatagramSocketMessageReceivedEventArgs : 
    IDatagramSocketMessageReceivedEventArgs
  {
    /// <summary>Gets the IP address of the remote sender of the datagram on the DatagramSocket when a message is received.</summary>
    /// <returns>The IP address of the remote network destination when the message is received on a DatagramSocket.</returns>
    public extern HostName RemoteAddress { [MethodImpl] get; }

    /// <summary>Gets the UDP port number of the remote sender of the datagram received on the DatagramSocket.</summary>
    /// <returns>The UDP port number of the remote network destination when a message is received on a DatagramSocket.</returns>
    public extern string RemotePort { [MethodImpl] get; }

    /// <summary>Gets the local IP address associated with a DatagramSocket when a message was received.</summary>
    /// <returns>The local IP address where the message was received by the DatagramSocket.</returns>
    public extern HostName LocalAddress { [MethodImpl] get; }

    /// <summary>Gets a DataReader object to read incoming data received from the remote network destination on a DatagramSocket object.</summary>
    /// <returns>A DataReader object to read incoming data received from the remote network destination on a DatagramSocket object.</returns>
    [MethodImpl]
    public extern DataReader GetDataReader();

    /// <summary>Gets an IInputStream object that represents a sequential stream of bytes to be read as a message from the remote network destination on a DatagramSocket object.</summary>
    /// <returns>An IInputStream object that represents a sequential stream of bytes to be read as a message.</returns>
    [MethodImpl]
    public extern IInputStream GetDataStream();
  }
}
