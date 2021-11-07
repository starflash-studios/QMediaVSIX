// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFi.IWiFiAdapterStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFi
{
  [Guid(3659922909, 53836, 17379, 170, 189, 196, 101, 159, 115, 15, 153)]
  [ExclusiveTo(typeof (WiFiAdapter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWiFiAdapterStatics
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<WiFiAdapter>> FindAllAdaptersAsync();

    string GetDeviceSelector();

    [RemoteAsync]
    [Overload("FromIdAsync")]
    IAsyncOperation<WiFiAdapter> FromIdAsync(string deviceId);

    [RemoteAsync]
    IAsyncOperation<WiFiAccessStatus> RequestAccessAsync();
  }
}
