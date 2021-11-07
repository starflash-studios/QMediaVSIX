// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IDeviceManufacturerNotificationTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Deprecated("DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DeviceManufacturerNotificationTrigger))]
  [Guid(2166852277, 16811, 5850, 134, 194, 127, 123, 240, 145, 47, 91)]
  internal interface IDeviceManufacturerNotificationTrigger : IBackgroundTrigger
  {
    string TriggerQualifier { [Deprecated("DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")] get; }

    bool OneShot { [Deprecated("DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
