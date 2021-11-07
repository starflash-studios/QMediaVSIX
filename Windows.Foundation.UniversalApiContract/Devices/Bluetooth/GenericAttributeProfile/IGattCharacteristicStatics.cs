// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattCharacteristicStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(1506496707, 22836, 20328, 161, 152, 235, 134, 79, 164, 78, 107)]
  [ExclusiveTo(typeof (GattCharacteristic))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGattCharacteristicStatics
  {
    [Deprecated("Use BluetoothUuidHelper instead of ConvertShortIdToUuid.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    Guid ConvertShortIdToUuid(ushort shortId);
  }
}
