// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Contains additional options that a RemoteSystemSessionController instance can specify when attempting to create a remote session.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class RemoteSystemSessionOptions : IRemoteSystemSessionOptions
  {
    /// <summary>Initializes an instance of the RemoteSystemSessionOptions class.</summary>
    [MethodImpl]
    public extern RemoteSystemSessionOptions();

    /// <summary>Indicates whether or not the session described by this RemoteSystemSessionOptions instance should be discoverable by invite only.</summary>
    /// <returns>A value of **true** if the corresponding session will only be discoverable for systems that receive an invitation, **false** if the session will be publicly discoverable.</returns>
    public extern bool IsInviteOnly { [MethodImpl] get; [MethodImpl] set; }
  }
}
