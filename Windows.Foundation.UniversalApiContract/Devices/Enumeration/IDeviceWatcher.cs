// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [Guid(3387603325, 36715, 20374, 169, 244, 171, 200, 20, 226, 34, 113)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DeviceWatcher))]
  internal interface IDeviceWatcher
  {
    event TypedEventHandler<DeviceWatcher, DeviceInformation> Added;

    event TypedEventHandler<DeviceWatcher, DeviceInformationUpdate> Updated;

    event TypedEventHandler<DeviceWatcher, DeviceInformationUpdate> Removed;

    event TypedEventHandler<DeviceWatcher, object> EnumerationCompleted;

    event TypedEventHandler<DeviceWatcher, object> Stopped;

    DeviceWatcherStatus Status { get; }

    void Start();

    void Stop();
  }
}
