// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionJoinResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Represents the result of this device's attempt to join a remote session.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RemoteSystemSessionJoinResult : IRemoteSystemSessionJoinResult
  {
    /// <summary>Represents the success status of this device's attempt to join a remote session.</summary>
    /// <returns>A RemoteSystemSessionJoinStatus value representing the result.</returns>
    public extern RemoteSystemSessionJoinStatus Status { [MethodImpl] get; }

    /// <summary>Gets the RemoteSystemSession object representing the session that was joined (if the join attempt was successful).</summary>
    /// <returns>The RemoteSystemSession object representing the session that was joined (if the join attempt was successful). If the attempt failed, this value is **null**.</returns>
    public extern RemoteSystemSession Session { [MethodImpl] get; }
  }
}
