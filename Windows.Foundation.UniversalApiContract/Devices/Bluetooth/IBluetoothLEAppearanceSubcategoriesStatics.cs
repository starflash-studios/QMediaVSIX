// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEAppearanceSubcategoriesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Guid(3850085894, 8516, 16730, 131, 18, 113, 204, 242, 145, 248, 209)]
  [ExclusiveTo(typeof (BluetoothLEAppearanceSubcategories))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IBluetoothLEAppearanceSubcategoriesStatics
  {
    ushort Generic { get; }

    ushort SportsWatch { get; }

    ushort ThermometerEar { get; }

    ushort HeartRateBelt { get; }

    ushort BloodPressureArm { get; }

    ushort BloodPressureWrist { get; }

    ushort Keyboard { get; }

    ushort Mouse { get; }

    ushort Joystick { get; }

    ushort Gamepad { get; }

    ushort DigitizerTablet { get; }

    ushort CardReader { get; }

    ushort DigitalPen { get; }

    ushort BarcodeScanner { get; }

    ushort RunningWalkingInShoe { get; }

    ushort RunningWalkingOnShoe { get; }

    ushort RunningWalkingOnHip { get; }

    ushort CyclingComputer { get; }

    ushort CyclingSpeedSensor { get; }

    ushort CyclingCadenceSensor { get; }

    ushort CyclingPowerSensor { get; }

    ushort CyclingSpeedCadenceSensor { get; }

    ushort OximeterFingertip { get; }

    ushort OximeterWristWorn { get; }

    ushort LocationDisplay { get; }

    ushort LocationNavigationDisplay { get; }

    ushort LocationPod { get; }

    ushort LocationNavigationPod { get; }
  }
}
