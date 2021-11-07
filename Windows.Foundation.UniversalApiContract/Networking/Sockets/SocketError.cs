// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.SocketError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  /// <summary>Provides socket error status for operations on a DatagramSocket, StreamSocket, or StreamSocketListener.</summary>
  [Static(typeof (ISocketErrorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  public static class SocketError
  {
    /// <summary>Gets a SocketErrorStatus value based on an error encountered by a socket operation.</summary>
    /// <param name="hresult">The error encountered by a socket operation represented as an **HRESULT**.</param>
    /// <returns>The socket error status value for a socket operation.</returns>
    [MethodImpl]
    public static extern SocketErrorStatus GetStatus(int hresult);
  }
}
