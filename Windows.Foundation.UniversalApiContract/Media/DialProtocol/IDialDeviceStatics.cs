// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.IDialDeviceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2859060373, 504, 18264, 132, 97, 43, 189, 28, 220, 60, 243)]
  [ExclusiveTo(typeof (DialDevice))]
  internal interface IDialDeviceStatics
  {
    string GetDeviceSelector(string appName);

    [RemoteAsync]
    IAsyncOperation<DialDevice> FromIdAsync(string value);

    [RemoteAsync]
    IAsyncOperation<bool> DeviceInfoSupportsDialAsync(DeviceInformation device);
  }
}
