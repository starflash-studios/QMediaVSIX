// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattLocalCharacteristicResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattLocalCharacteristicResult))]
  [Guid(2037767835, 368, 17303, 150, 102, 146, 248, 99, 241, 46, 230)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattLocalCharacteristicResult
  {
    GattLocalCharacteristic Characteristic { get; }

    BluetoothError Error { get; }
  }
}
