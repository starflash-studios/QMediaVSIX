// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFi.IWiFiAdapter2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Devices.WiFi
{
  [ExclusiveTo(typeof (WiFiAdapter))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1539592221, 33252, 17725, 148, 48, 31, 202, 251, 173, 214, 182)]
  internal interface IWiFiAdapter2
  {
    [RemoteAsync]
    IAsyncOperation<WiFiWpsConfigurationResult> GetWpsConfigurationAsync(
      WiFiAvailableNetwork availableNetwork);

    [Overload("ConnectWithPasswordCredentialAndSsidAndConnectionMethodAsync")]
    IAsyncOperation<WiFiConnectionResult> ConnectAsync(
      WiFiAvailableNetwork availableNetwork,
      WiFiReconnectionKind reconnectionKind,
      PasswordCredential passwordCredential,
      string ssid,
      WiFiConnectionMethod connectionMethod);
  }
}
