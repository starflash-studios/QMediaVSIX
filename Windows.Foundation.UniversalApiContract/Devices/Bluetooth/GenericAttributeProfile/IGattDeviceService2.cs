// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattDeviceService2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattDeviceService))]
  [Guid(4233384459, 2829, 18184, 186, 224, 159, 253, 148, 137, 188, 89)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGattDeviceService2 : IGattDeviceService, IClosable
  {
    BluetoothLEDevice Device { [Deprecated("Use Session instead of Device property.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    IVectorView<GattDeviceService> ParentServices { [Deprecated("ParentServices may be altered or unavailable in future releases.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("Use GetCharacteristicsAsync instead of GetAllCharacteristics.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IVectorView<GattCharacteristic> GetAllCharacteristics();

    [Deprecated("Use GetIncludedServicesAsync instead of GetAllIncludedServices.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IVectorView<GattDeviceService> GetAllIncludedServices();
  }
}
