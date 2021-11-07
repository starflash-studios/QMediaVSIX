// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionJoinRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Represents a remote device's request to join a session controlled by this device.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class RemoteSystemSessionJoinRequest : IRemoteSystemSessionJoinRequest
  {
    /// <summary>Describes a request by a remote device to join a remote session.</summary>
    /// <returns>A RemoteSystemSessionParticipant object representing the participant that issued the join request.</returns>
    public extern RemoteSystemSessionParticipant Participant { [MethodImpl] get; }

    /// <summary>Causes the app to accept the requesting device into the remote session it is controlling.</summary>
    [MethodImpl]
    public extern void Accept();
  }
}
