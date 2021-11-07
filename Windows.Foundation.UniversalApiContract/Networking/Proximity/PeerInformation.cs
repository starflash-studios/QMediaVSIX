// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.PeerInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Proximity
{
  /// <summary>Contains information that identifies a peer.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PeerInformation : 
    IPeerInformation,
    IPeerInformation3,
    IPeerInformationWithHostAndService
  {
    /// <summary>Gets the display name of the peer.</summary>
    /// <returns>The display name of the peer.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the app id for the peer app.</summary>
    /// <returns>The app id for the peer app.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets the device data included during device discovery.</summary>
    /// <returns>User or device data to include during device discovery. Must be less than 32 bytes.</returns>
    public extern IBuffer DiscoveryData { [MethodImpl] get; }

    /// <summary>Gets the hostname or IP address of the peer.</summary>
    /// <returns>The hostname or IP address of the peer</returns>
    public extern HostName HostName { [MethodImpl] get; }

    /// <summary>Gets the service name or TCP port number of the peer.</summary>
    /// <returns>The service name or TCP port number of the peer.</returns>
    public extern string ServiceName { [MethodImpl] get; }
  }
}
