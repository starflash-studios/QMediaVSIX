// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionCreationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Represents the result of an attempt by a RemoteSystemSessionController object to create a new remote session.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class RemoteSystemSessionCreationResult : IRemoteSystemSessionCreationResult
  {
    /// <summary>Gets the status of a RemoteSystemSessionController object's attempt to create a remote session.</summary>
    /// <returns>A RemoteSystemSessionCreationStatus value describing the result.</returns>
    public extern RemoteSystemSessionCreationStatus Status { [MethodImpl] get; }

    /// <summary>Gets the RemoteSystemSession object related to this creation attempt.</summary>
    /// <returns>The RemoteSystemSession object representing the session that was created (if the attempt was successful). If the session was not created successfully, this value is **null**.</returns>
    public extern RemoteSystemSession Session { [MethodImpl] get; }
  }
}
