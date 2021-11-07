// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedLineDisplay
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (ClaimedLineDisplay))]
  [Guid(302696816, 39541, 19151, 170, 231, 9, 151, 43, 207, 135, 148)]
  internal interface IClaimedLineDisplay
  {
    string DeviceId { get; }

    LineDisplayCapabilities Capabilities { get; }

    string PhysicalDeviceName { get; }

    string PhysicalDeviceDescription { get; }

    string DeviceControlDescription { get; }

    string DeviceControlVersion { get; }

    string DeviceServiceVersion { get; }

    LineDisplayWindow DefaultWindow { get; }

    void RetainDevice();

    event TypedEventHandler<ClaimedLineDisplay, object> ReleaseDeviceRequested;
  }
}
