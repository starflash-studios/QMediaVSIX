// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.IWiFiDirectServiceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect.Services
{
  [ExclusiveTo(typeof (WiFiDirectService))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2108948549, 64884, 18056, 183, 37, 93, 206, 134, 172, 242, 51)]
  internal interface IWiFiDirectServiceStatics
  {
    [Overload("GetSelector")]
    string GetSelector(string serviceName);

    [Overload("GetSelectorWithFilter")]
    string GetSelector(string serviceName, IBuffer serviceInfoFilter);

    [RemoteAsync]
    IAsyncOperation<WiFiDirectService> FromIdAsync(string deviceId);
  }
}
