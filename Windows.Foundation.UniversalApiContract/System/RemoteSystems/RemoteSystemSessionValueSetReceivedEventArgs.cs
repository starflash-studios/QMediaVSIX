// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionValueSetReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Contains information about a RemoteSystemSessionMessageChannel.ValueSetReceived event that was raised, namely the message that was received.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class RemoteSystemSessionValueSetReceivedEventArgs : 
    IRemoteSystemSessionValueSetReceivedEventArgs
  {
    /// <summary>Gets the remote session participant that sent the message to the channel and caused this ValueSetReceived event to be raised.</summary>
    /// <returns>The RemoteSystemSessionParticipant object corresponding to the sender participant.</returns>
    public extern RemoteSystemSessionParticipant Sender { [MethodImpl] get; }

    /// <summary>Gets the contents of the message received by the channel.</summary>
    /// <returns>A ValueSet object containing the data that was received from the channel.</returns>
    public extern ValueSet Message { [MethodImpl] get; }
  }
}
