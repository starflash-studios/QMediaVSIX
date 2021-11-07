// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.IWiFiDirectServiceAdvertiser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect.Services
{
  [ExclusiveTo(typeof (WiFiDirectServiceAdvertiser))]
  [Guid(2762612449, 40335, 20303, 147, 238, 125, 222, 162, 227, 127, 70)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWiFiDirectServiceAdvertiser
  {
    string ServiceName { get; }

    IVector<string> ServiceNamePrefixes { get; }

    IBuffer ServiceInfo { get; set; }

    bool AutoAcceptSession { get; set; }

    bool PreferGroupOwnerMode { get; set; }

    IVector<WiFiDirectServiceConfigurationMethod> PreferredConfigurationMethods { get; }

    WiFiDirectServiceStatus ServiceStatus { get; set; }

    uint CustomServiceStatusCode { get; set; }

    IBuffer DeferredSessionInfo { get; set; }

    WiFiDirectServiceAdvertisementStatus AdvertisementStatus { get; }

    WiFiDirectServiceError ServiceError { get; }

    event TypedEventHandler<WiFiDirectServiceAdvertiser, WiFiDirectServiceSessionRequestedEventArgs> SessionRequested;

    event TypedEventHandler<WiFiDirectServiceAdvertiser, WiFiDirectServiceAutoAcceptSessionConnectedEventArgs> AutoAcceptSessionConnected;

    event TypedEventHandler<WiFiDirectServiceAdvertiser, object> AdvertisementStatusChanged;

    [RemoteAsync]
    [Overload("ConnectAsync")]
    IAsyncOperation<WiFiDirectServiceSession> ConnectAsync(
      DeviceInformation deviceInfo);

    [Overload("ConnectAsyncWithPin")]
    [RemoteAsync]
    IAsyncOperation<WiFiDirectServiceSession> ConnectAsync(
      DeviceInformation deviceInfo,
      string pin);

    void Start();

    void Stop();
  }
}
