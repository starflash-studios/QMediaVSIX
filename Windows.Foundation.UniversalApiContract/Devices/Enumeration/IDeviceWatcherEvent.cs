// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceWatcherEvent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DeviceWatcherEvent))]
  [Guid(1957338123, 7613, 18429, 182, 53, 60, 197, 86, 208, 255, 139)]
  internal interface IDeviceWatcherEvent
  {
    DeviceWatcherEventKind Kind { get; }

    DeviceInformation DeviceInformation { get; }

    DeviceInformationUpdate DeviceInformationUpdate { get; }
  }
}
