// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.StreamSocketListenerConnectionReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  /// <summary>Provides data for a ConnectionReceived event on a StreamSocketListener object.</summary>
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StreamSocketListenerConnectionReceivedEventArgs : 
    IStreamSocketListenerConnectionReceivedEventArgs
  {
    /// <summary>The StreamSocket object created when a connection is received by the StreamSocketListener object.</summary>
    /// <returns>The StreamSocket object created when a connection is received by the StreamSocketListener object.</returns>
    public extern StreamSocket Socket { [MethodImpl] get; }
  }
}
