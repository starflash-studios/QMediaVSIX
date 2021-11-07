// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.SocketActivityKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  /// <summary>Describes the kind of socket object being transferred to or from the socket broker.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SocketActivityKind
  {
    /// <summary>The socket type is unknown.</summary>
    None,
    /// <summary>A socket type of StreamSocketListener.</summary>
    StreamSocketListener,
    /// <summary>A socket type of DatagramSocket.</summary>
    DatagramSocket,
    /// <summary>A socket type of StreamSocket.</summary>
    StreamSocket,
  }
}
