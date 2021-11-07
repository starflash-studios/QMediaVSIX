// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionParticipantRemovedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Contains information about a RemoteSystemSessionParticipantWatcher.Removed event, namely the participant that was removed from the session.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RemoteSystemSessionParticipantRemovedEventArgs : 
    IRemoteSystemSessionParticipantRemovedEventArgs
  {
    /// <summary>Gets the participant that was removed from the remote session.</summary>
    /// <returns>A RemoteSystemSessionParticipant object corresponding to the participant removed.</returns>
    public extern RemoteSystemSessionParticipant Participant { [MethodImpl] get; }
  }
}
