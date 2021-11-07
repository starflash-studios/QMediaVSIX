// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectDeviceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WiFiDirectDevice))]
  [Guid(3899438460, 15020, 18513, 167, 146, 72, 42, 175, 147, 27, 4)]
  internal interface IWiFiDirectDeviceStatics
  {
    [Overload("GetDeviceSelector")]
    string GetDeviceSelector();

    [RemoteAsync]
    [Overload("FromIdAsync")]
    IAsyncOperation<WiFiDirectDevice> FromIdAsync(string deviceId);
  }
}
