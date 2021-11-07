// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemAuthorizationKindFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>An IRemoteSystemFilter that alters the set of discoverable remote systems by allowing those of a specific authorization kind.</summary>
  [Activatable(typeof (IRemoteSystemAuthorizationKindFilterFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RemoteSystemAuthorizationKindFilter : 
    IRemoteSystemAuthorizationKindFilter,
    IRemoteSystemFilter
  {
    /// <summary>Initializes an instance of the RemoteSystemAuthorizationKindFilter class.</summary>
    /// <param name="remoteSystemAuthorizationKind">The authorization kind to target.</param>
    [MethodImpl]
    public extern RemoteSystemAuthorizationKindFilter(
      RemoteSystemAuthorizationKind remoteSystemAuthorizationKind);

    /// <summary>The authorization kind setting that the containing RemoteSystemAuthorizationKindFilter object targets.</summary>
    /// <returns>The authorization kind to target.</returns>
    public extern RemoteSystemAuthorizationKind RemoteSystemAuthorizationKind { [MethodImpl] get; }
  }
}
