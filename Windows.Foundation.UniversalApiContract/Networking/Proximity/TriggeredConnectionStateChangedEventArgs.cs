// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.TriggeredConnectionStateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;

namespace Windows.Networking.Proximity
{
  /// <summary>Contains properties that the TriggeredConnectionStateChanged event passes to an application.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TriggeredConnectionStateChangedEventArgs : 
    ITriggeredConnectionStateChangedEventArgs
  {
    /// <summary>Gets the state of the connection in progress.</summary>
    /// <returns>The state of the connection in progress.</returns>
    public extern TriggeredConnectState State { [MethodImpl] get; }

    /// <summary>Gets the unique identifier for the connection in progress.</summary>
    /// <returns>The unique identifier for the connection in progress.</returns>
    public extern uint Id { [MethodImpl] get; }

    /// <summary>Gets the StreamSocket instance for the connection.</summary>
    /// <returns>The StreamSocket instance for the connection.</returns>
    public extern StreamSocket Socket { [MethodImpl] get; }
  }
}
