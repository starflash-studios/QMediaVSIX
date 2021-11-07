// Decompiled with JetBrains decompiler
// Type: Windows.Networking.EndpointPair
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking
{
  /// <summary>Provides data for the local endpoint and remote endpoint for a network connection used by network apps.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Activatable(typeof (IEndpointPairFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class EndpointPair : IEndpointPair
  {
    /// <summary>Creates a new EndpointPair object.</summary>
    /// <param name="localHostName">The local hostname or IP address for the EndpointPair object.</param>
    /// <param name="localServiceName">The local service name or the local TCP or UDP port number for the EndpointPair object.</param>
    /// <param name="remoteHostName">The remote hostname or IP address for the EndpointPair object.</param>
    /// <param name="remoteServiceName">The remote service name or the remote TCP or UDP port number for the EndpointPair object.</param>
    [MethodImpl]
    public extern EndpointPair(
      HostName localHostName,
      string localServiceName,
      HostName remoteHostName,
      string remoteServiceName);

    /// <summary>Get or set the local hostname for the EndpointPair object.</summary>
    /// <returns>The local hostname for the EndpointPair object.</returns>
    public extern HostName LocalHostName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or set the local service name for the EndpointPair object.</summary>
    /// <returns>The local service name for the EndpointPair object.</returns>
    public extern string LocalServiceName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or set the remote hostname for the EndpointPair object.</summary>
    /// <returns>The remote hostname for the EndpointPair object.</returns>
    public extern HostName RemoteHostName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or set the remote service name for the EndpointPair object.</summary>
    /// <returns>The remote service name for the EndpointPair object.</returns>
    public extern string RemoteServiceName { [MethodImpl] get; [MethodImpl] set; }
  }
}
