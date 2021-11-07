// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFi.IWiFiAdapter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;
using Windows.Security.Credentials;

namespace Windows.Devices.WiFi
{
  [Guid(2797921315, 15733, 17316, 185, 222, 17, 226, 107, 114, 217, 176)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WiFiAdapter))]
  internal interface IWiFiAdapter
  {
    NetworkAdapter NetworkAdapter { get; }

    [RemoteAsync]
    IAsyncAction ScanAsync();

    WiFiNetworkReport NetworkReport { get; }

    event TypedEventHandler<WiFiAdapter, object> AvailableNetworksChanged;

    [RemoteAsync]
    [Overload("ConnectAsync")]
    IAsyncOperation<WiFiConnectionResult> ConnectAsync(
      WiFiAvailableNetwork availableNetwork,
      WiFiReconnectionKind reconnectionKind);

    [Overload("ConnectWithPasswordCredentialAsync")]
    IAsyncOperation<WiFiConnectionResult> ConnectAsync(
      WiFiAvailableNetwork availableNetwork,
      WiFiReconnectionKind reconnectionKind,
      PasswordCredential passwordCredential);

    [Overload("ConnectWithPasswordCredentialAndSsidAsync")]
    IAsyncOperation<WiFiConnectionResult> ConnectAsync(
      WiFiAvailableNetwork availableNetwork,
      WiFiReconnectionKind reconnectionKind,
      PasswordCredential passwordCredential,
      string ssid);

    void Disconnect();
  }
}
