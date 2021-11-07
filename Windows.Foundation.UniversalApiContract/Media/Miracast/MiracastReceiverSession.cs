// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  /// <summary>An object which encapsulates functionality related to receiving incoming Miracast connections.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  public sealed class MiracastReceiverSession : IMiracastReceiverSession, IClosable
  {
    /// <summary>An event which is raised when a new incoming MiracastReceiverConnection is received.</summary>
    public extern event TypedEventHandler<MiracastReceiverSession, MiracastReceiverConnectionCreatedEventArgs> ConnectionCreated;

    /// <summary>An event which is raised when the MediaSource object for a MiracastReceiverConnection has been created.</summary>
    public extern event TypedEventHandler<MiracastReceiverSession, MiracastReceiverMediaSourceCreatedEventArgs> MediaSourceCreated;

    /// <summary>An event which is raised when a MiracastReceiverConnection has been disconnected by the Miracast Transmitter.</summary>
    public extern event TypedEventHandler<MiracastReceiverSession, MiracastReceiverDisconnectedEventArgs> Disconnected;

    /// <summary>Specifies if the app allows a new connection to take over an in-progress Miracast Connection.</summary>
    /// <returns>True if the app allows a new connection is allowed to take over an in-progress connection.</returns>
    public extern bool AllowConnectionTakeover { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies the maximum number of simultaneous connections that the app is willing to handle on the MiracastReceiverSession.</summary>
    /// <returns>The maximum number of simultaneous connections that the app is willing to handle on the MiracastReceiverSession.</returns>
    public extern int MaxSimultaneousConnections { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Start listening for incoming Miracast connections.</summary>
    /// <returns>The result of the operation.</returns>
    [MethodImpl]
    public extern MiracastReceiverSessionStartResult Start();

    /// <summary>Start listening for incoming Miracast connections.</summary>
    /// <returns>The result of the operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MiracastReceiverSessionStartResult> StartAsync();

    [MethodImpl]
    public extern void Close();
  }
}
