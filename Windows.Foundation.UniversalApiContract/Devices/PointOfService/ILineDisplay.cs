// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ILineDisplay
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (LineDisplay))]
  [Guid(620093262, 15513, 17634, 183, 63, 229, 27, 227, 99, 122, 140)]
  internal interface ILineDisplay
  {
    string DeviceId { get; }

    LineDisplayCapabilities Capabilities { get; }

    string PhysicalDeviceName { get; }

    string PhysicalDeviceDescription { get; }

    string DeviceControlDescription { get; }

    string DeviceControlVersion { get; }

    string DeviceServiceVersion { get; }

    [RemoteAsync]
    IAsyncOperation<ClaimedLineDisplay> ClaimAsync();
  }
}
