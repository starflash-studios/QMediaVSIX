// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEAppearanceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2710814919, 17668, 20298, 155, 165, 205, 16, 84, 229, 224, 101)]
  [ExclusiveTo(typeof (BluetoothLEAppearance))]
  internal interface IBluetoothLEAppearanceStatics
  {
    BluetoothLEAppearance FromRawValue(ushort rawValue);

    BluetoothLEAppearance FromParts(
      ushort appearanceCategory,
      ushort appearanceSubCategory);
  }
}
