// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.DatagramSocketInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  /// <summary>Provides socket information on a DatagramSocket object.</summary>
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DatagramSocketInformation : IDatagramSocketInformation
  {
    /// <summary>The local IP address associated with a DatagramSocket object.</summary>
    /// <returns>The local hostname or IP address.</returns>
    public extern HostName LocalAddress { [MethodImpl] get; }

    /// <summary>The local service name or UDP port number associated with a DatagramSocket.</summary>
    /// <returns>The local service name or UDP port number.</returns>
    public extern string LocalPort { [MethodImpl] get; }

    /// <summary>The IP address of the remote network destination associated with a DatagramSocket object.</summary>
    /// <returns>The IP address of the remote network destination.</returns>
    public extern HostName RemoteAddress { [MethodImpl] get; }

    /// <summary>The UDP port number of the remote network destination associated with a DatagramSocket object.</summary>
    /// <returns>The UDP port number of the remote network destination.</returns>
    public extern string RemotePort { [MethodImpl] get; }
  }
}
