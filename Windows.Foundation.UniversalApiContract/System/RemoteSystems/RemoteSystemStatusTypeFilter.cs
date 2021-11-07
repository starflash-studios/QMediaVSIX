// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemStatusTypeFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>An IRemoteSystemFilter that limits the set of discoverable remote systems by allowing only those of a specific availability status.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Activatable(typeof (IRemoteSystemStatusTypeFilterFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class RemoteSystemStatusTypeFilter : 
    IRemoteSystemStatusTypeFilter,
    IRemoteSystemFilter
  {
    /// <summary>Initializes an instance of the RemoteSystemStatusTypeFilter class.</summary>
    /// <param name="remoteSystemStatusType">The status type to target.</param>
    [MethodImpl]
    public extern RemoteSystemStatusTypeFilter(RemoteSystemStatusType remoteSystemStatusType);

    /// <summary>The status type that the containing RemoteSystemStatusTypeFilter object targets.</summary>
    /// <returns>The status type to target.</returns>
    public extern RemoteSystemStatusType RemoteSystemStatusType { [MethodImpl] get; }
  }
}
