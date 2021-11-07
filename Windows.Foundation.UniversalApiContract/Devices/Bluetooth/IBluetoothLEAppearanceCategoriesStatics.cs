// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEAppearanceCategoriesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Guid(1833784574, 1130, 16773, 170, 182, 130, 76, 240, 97, 8, 97)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (BluetoothLEAppearanceCategories))]
  internal interface IBluetoothLEAppearanceCategoriesStatics
  {
    ushort Uncategorized { get; }

    ushort Phone { get; }

    ushort Computer { get; }

    ushort Watch { get; }

    ushort Clock { get; }

    ushort Display { get; }

    ushort RemoteControl { get; }

    ushort EyeGlasses { get; }

    ushort Tag { get; }

    ushort Keyring { get; }

    ushort MediaPlayer { get; }

    ushort BarcodeScanner { get; }

    ushort Thermometer { get; }

    ushort HeartRate { get; }

    ushort BloodPressure { get; }

    ushort HumanInterfaceDevice { get; }

    ushort GlucoseMeter { get; }

    ushort RunningWalking { get; }

    ushort Cycling { get; }

    ushort PulseOximeter { get; }

    ushort WeightScale { get; }

    ushort OutdoorSportActivity { get; }
  }
}
