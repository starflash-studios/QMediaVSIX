// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisementDataTypesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [ExclusiveTo(typeof (BluetoothLEAdvertisementDataTypes))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1001801519, 1542, 17227, 167, 110, 116, 21, 159, 6, 132, 211)]
  internal interface IBluetoothLEAdvertisementDataTypesStatics
  {
    byte Flags { get; }

    byte IncompleteService16BitUuids { get; }

    byte CompleteService16BitUuids { get; }

    byte IncompleteService32BitUuids { get; }

    byte CompleteService32BitUuids { get; }

    byte IncompleteService128BitUuids { get; }

    byte CompleteService128BitUuids { get; }

    byte ShortenedLocalName { get; }

    byte CompleteLocalName { get; }

    byte TxPowerLevel { get; }

    byte SlaveConnectionIntervalRange { get; }

    byte ServiceSolicitation16BitUuids { get; }

    byte ServiceSolicitation32BitUuids { get; }

    byte ServiceSolicitation128BitUuids { get; }

    byte ServiceData16BitUuids { get; }

    byte ServiceData32BitUuids { get; }

    byte ServiceData128BitUuids { get; }

    byte PublicTargetAddress { get; }

    byte RandomTargetAddress { get; }

    byte Appearance { get; }

    byte AdvertisingInterval { get; }

    byte ManufacturerSpecificData { get; }
  }
}
