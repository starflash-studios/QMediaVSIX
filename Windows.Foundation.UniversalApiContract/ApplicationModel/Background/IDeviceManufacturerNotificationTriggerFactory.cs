// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IDeviceManufacturerNotificationTriggerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Deprecated("DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (DeviceManufacturerNotificationTrigger))]
  [Guid(2035670645, 9659, 16723, 161, 162, 48, 41, 252, 171, 182, 82)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDeviceManufacturerNotificationTriggerFactory
  {
    [Deprecated("DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")]
    DeviceManufacturerNotificationTrigger Create(
      string triggerQualifier,
      bool oneShot);
  }
}
