// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattDeviceServiceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattDeviceService))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(426573858, 64173, 17884, 174, 91, 42, 195, 24, 78, 132, 219)]
  internal interface IGattDeviceServiceStatics
  {
    [Overload("FromIdAsync")]
    [RemoteAsync]
    IAsyncOperation<GattDeviceService> FromIdAsync(string deviceId);

    string GetDeviceSelectorFromUuid(Guid serviceUuid);

    [Deprecated("Use GetDeviceSelectorFromUuid instead of GetDeviceSelectorFromShortId.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    string GetDeviceSelectorFromShortId(ushort serviceShortId);

    [Deprecated("Use BluetoothUuidHelper instead of ConvertShortIdToUuid.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    Guid ConvertShortIdToUuid(ushort shortId);
  }
}
