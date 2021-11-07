// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.NetworkOperatorTetheringAccessPointConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Provides the ability to configure and create a NetworkOperatorTetheringAccessPointConfiguration object that contains a specific network account ID (SSID) and specifies the passphrase used to authenticate clients trying to establish a network connection to the tethering network.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class NetworkOperatorTetheringAccessPointConfiguration : 
    INetworkOperatorTetheringAccessPointConfiguration,
    INetworkOperatorTetheringAccessPointConfiguration2
  {
    /// <summary>Creates an instance of the NetworkOperatorTetheringAccessPointConfiguration.</summary>
    [MethodImpl]
    public extern NetworkOperatorTetheringAccessPointConfiguration();

    /// <summary>Gets or sets the network account ID.</summary>
    /// <returns>The network account ID</returns>
    public extern string Ssid { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the passphrase used to authenticate the connection.</summary>
    /// <returns>The network passphrase.</returns>
    public extern string Passphrase { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Checks whether the Wi-Fi access point supports the specified wireless frequency band.</summary>
    /// <param name="band">A TetheringWiFiBand constant, specifying the frequency band to query about.</param>
    /// <returns>`true` if the frequency band is supported, otherwise `false`.</returns>
    [MethodImpl]
    public extern bool IsBandSupported(TetheringWiFiBand band);

    /// <summary>Asynchronously checks whether the Wi-Fi access point supports the specified wireless frequency band.</summary>
    /// <param name="band">A TetheringWiFiBand constant, specifying the frequency band to query about.</param>
    /// <returns>An asynchronous object which, on completion, contains `true` if the frequency band is supported, otherwise `false`.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> IsBandSupportedAsync(TetheringWiFiBand band);

    /// <summary>Gets or sets the wireless frequency band of the Wi-Fi access point. Use IsBandSupported or IsBandSupportedAsync to check whether the Wi-Fi adapter allows configuring a specific frequency band.</summary>
    /// <returns>A TetheringWiFiBand constant, specifying the frequency band.</returns>
    public extern TetheringWiFiBand Band { [MethodImpl] get; [MethodImpl] set; }
  }
}
