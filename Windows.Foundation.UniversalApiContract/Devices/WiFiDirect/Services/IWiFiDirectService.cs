// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.IWiFiDirectService
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect.Services
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1353366456, 24433, 17900, 132, 241, 161, 228, 252, 120, 121, 163)]
  [ExclusiveTo(typeof (WiFiDirectService))]
  internal interface IWiFiDirectService
  {
    IBuffer RemoteServiceInfo { get; }

    IVectorView<WiFiDirectServiceConfigurationMethod> SupportedConfigurationMethods { get; }

    bool PreferGroupOwnerMode { get; set; }

    IBuffer SessionInfo { get; set; }

    WiFiDirectServiceError ServiceError { get; }

    event TypedEventHandler<WiFiDirectService, WiFiDirectServiceSessionDeferredEventArgs> SessionDeferred;

    [RemoteAsync]
    IAsyncOperation<WiFiDirectServiceProvisioningInfo> GetProvisioningInfoAsync(
      WiFiDirectServiceConfigurationMethod selectedConfigurationMethod);

    [RemoteAsync]
    [Overload("ConnectAsync")]
    IAsyncOperation<WiFiDirectServiceSession> ConnectAsync();

    [RemoteAsync]
    [Overload("ConnectAsyncWithPin")]
    IAsyncOperation<WiFiDirectServiceSession> ConnectAsync(
      string pin);
  }
}
