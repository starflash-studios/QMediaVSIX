// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemDiscoveryTypeFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>An IRemoteSystemFilter that limits the set of discoverable remote systems by allowing only those of a specific discovery type.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IRemoteSystemDiscoveryTypeFilterFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class RemoteSystemDiscoveryTypeFilter : 
    IRemoteSystemDiscoveryTypeFilter,
    IRemoteSystemFilter
  {
    /// <summary>Initializes an instance of the RemoteSystemDiscoveryTypeFilter class.</summary>
    /// <param name="discoveryType">The discovery type to target.</param>
    [MethodImpl]
    public extern RemoteSystemDiscoveryTypeFilter(RemoteSystemDiscoveryType discoveryType);

    /// <summary>The discovery type that the containing RemoteSystemDiscoveryTypeFilter object targets.</summary>
    /// <returns>The discovery type to target.</returns>
    public extern RemoteSystemDiscoveryType RemoteSystemDiscoveryType { [MethodImpl] get; }
  }
}
