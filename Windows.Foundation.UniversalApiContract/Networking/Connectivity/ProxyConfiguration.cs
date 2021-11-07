// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.ProxyConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Represents the proxy configuration for the current user. </summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ProxyConfiguration : IProxyConfiguration
  {
    /// <summary>Gets a list of URIs for the proxies from the proxy configuration. </summary>
    /// <returns>A list of URIs for the proxy configuration.</returns>
    public extern IVectorView<Uri> ProxyUris { [MethodImpl] get; }

    /// <summary>Gets a value that indicates if this configuration can connect directly. </summary>
    /// <returns>TRUE if this configuration can connect directly; otherwise, FALSE.</returns>
    public extern bool CanConnectDirectly { [MethodImpl] get; }
  }
}
