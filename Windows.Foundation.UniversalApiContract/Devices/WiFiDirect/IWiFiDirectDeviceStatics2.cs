// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectDeviceStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [Guid(445988425, 45315, 17278, 146, 38, 171, 103, 151, 19, 66, 249)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WiFiDirectDevice))]
  internal interface IWiFiDirectDeviceStatics2
  {
    [Overload("GetDeviceSelector")]
    string GetDeviceSelector(WiFiDirectDeviceSelectorType type);

    [Overload("FromIdAsync")]
    IAsyncOperation<WiFiDirectDevice> FromIdAsync(
      string deviceId,
      WiFiDirectConnectionParameters connectionParameters);
  }
}
