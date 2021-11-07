// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.IDisplayMonitorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(1856924047, 41512, 19461, 130, 29, 182, 149, 214, 103, 222, 142)]
  [ExclusiveTo(typeof (DisplayMonitor))]
  internal interface IDisplayMonitorStatics
  {
    string GetDeviceSelector();

    [RemoteAsync]
    IAsyncOperation<DisplayMonitor> FromIdAsync(string deviceId);

    [RemoteAsync]
    IAsyncOperation<DisplayMonitor> FromInterfaceIdAsync(
      string deviceInterfaceId);
  }
}
