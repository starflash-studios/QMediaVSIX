// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.TriggeredConnectState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Proximity
{
  /// <summary>Indicates the current state of a connection to a peer application.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TriggeredConnectState
  {
    /// <summary>A device that supports proximity socket connections is within proximity. The tap gesture is complete.</summary>
    PeerFound,
    /// <summary>This side of the socket connection will be the host and is waiting for a connection from the peer.</summary>
    Listening,
    /// <summary>This side of the socket connection will be the client and is attempting to connect to the peer.</summary>
    Connecting,
    /// <summary>The connection is complete, and the StreamSocket class can now be used to communicate with the peer.</summary>
    Completed,
    /// <summary>The connection was stopped before it was completed.</summary>
    Canceled,
    /// <summary>An error prevented a successful connection.</summary>
    Failed,
  }
}
