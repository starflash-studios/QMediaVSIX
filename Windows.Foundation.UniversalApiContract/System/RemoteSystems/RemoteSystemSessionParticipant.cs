// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionParticipant
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.System.RemoteSystems
{
  /// <summary>Represents a device that is a participant in a remote session. A session can have one or more participants.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class RemoteSystemSessionParticipant : IRemoteSystemSessionParticipant
  {
    /// <summary>Gets the remote system that is a participant in the session.</summary>
    /// <returns>A RemoteSystem object representing the participant device.</returns>
    public extern RemoteSystem RemoteSystem { [MethodImpl] get; }

    /// <summary>Retrieves a list of host names for this remote session participant that are resolvable by the other remote systems in the session.</summary>
    /// <returns>A list of HostName objects for the IP/Bluetooth addresses of this remote system.</returns>
    [MethodImpl]
    public extern IVectorView<HostName> GetHostNames();
  }
}
