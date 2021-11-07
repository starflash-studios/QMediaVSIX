// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothLEAppearanceSubcategories
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  /// <summary>Indicates the appearance subcategory code of the Bluetooth LE device. For more info on how sub categories map to categories, see the Bluetooth Specification.</summary>
  [DualApiPartition(version = 1)]
  [Static(typeof (IBluetoothLEAppearanceSubcategoriesStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public static class BluetoothLEAppearanceSubcategories
  {
    /// <summary>Gets the generic appearance subcategory code.</summary>
    /// <returns>The appearance subcategory code for a generic Bluetooth LE device.</returns>
    public static extern ushort Generic { [MethodImpl] get; }

    /// <summary>Gets the sports watch appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.RunningWalking appearance category.</summary>
    /// <returns>The appearance subcategory code for a sports watch Bluetooth LE device.</returns>
    public static extern ushort SportsWatch { [MethodImpl] get; }

    /// <summary>Gets the ear thermometer appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.RunningWalking appearance category.</summary>
    /// <returns>The appearance subcategory code for a ear thermometer Bluetooth LE device.</returns>
    public static extern ushort ThermometerEar { [MethodImpl] get; }

    /// <summary>Gets the heart rate belt appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.HeartRate appearance category.</summary>
    /// <returns>The appearance subcategory code for a heart rate belt Bluetooth LE device.</returns>
    public static extern ushort HeartRateBelt { [MethodImpl] get; }

    /// <summary>Gets the blood pressure arm appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.BloodPressure appearance category.</summary>
    /// <returns>The appearance subcategory code for a blood pressure arm Bluetooth LE device.</returns>
    public static extern ushort BloodPressureArm { [MethodImpl] get; }

    /// <summary>Gets the blood pressure wrist appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.BloodPressure appearance category.</summary>
    /// <returns>The appearance subcategory code for a blood pressure wrist Bluetooth LE device.</returns>
    public static extern ushort BloodPressureWrist { [MethodImpl] get; }

    /// <summary>Gets the keyboard appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.HumanInterfaceDevice appearance category.</summary>
    /// <returns>The appearance subcategory code for a keyboard Bluetooth LE device.</returns>
    public static extern ushort Keyboard { [MethodImpl] get; }

    /// <summary>Gets the mouse appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.HumanInterfaceDevice appearance category.</summary>
    /// <returns>The appearance subcategory code for a mouse Bluetooth LE device.</returns>
    public static extern ushort Mouse { [MethodImpl] get; }

    /// <summary>Gets the joystick appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.HumanInterfaceDevice appearance category.</summary>
    /// <returns>The appearance subcategory code for a joystick Bluetooth LE device.</returns>
    public static extern ushort Joystick { [MethodImpl] get; }

    /// <summary>Gets the gamepad appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.HumanInterfaceDevice appearance category.</summary>
    /// <returns>The appearance subcategory code for a gamepad Bluetooth LE device.</returns>
    public static extern ushort Gamepad { [MethodImpl] get; }

    /// <summary>Gets the digitizer tablet appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.HumanInterfaceDevice appearance category.</summary>
    /// <returns>The appearance subcategory code for a digitizer tablet Bluetooth LE device.</returns>
    public static extern ushort DigitizerTablet { [MethodImpl] get; }

    /// <summary>Gets the card reader appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.HumanInterfaceDevice appearance category.</summary>
    /// <returns>The appearance subcategory code for a card reader Bluetooth LE device.</returns>
    public static extern ushort CardReader { [MethodImpl] get; }

    /// <summary>Gets the digital pen appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.HumanInterfaceDevice appearance category.</summary>
    /// <returns>The appearance subcategory code for a digital pen Bluetooth LE device.</returns>
    public static extern ushort DigitalPen { [MethodImpl] get; }

    /// <summary>Gets the pulse barcode scanner appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.HumanInterfaceDevice appearance category.</summary>
    /// <returns>The appearance subcategory code for a barcode scanner Bluetooth LE device.</returns>
    public static extern ushort BarcodeScanner { [MethodImpl] get; }

    /// <summary>Gets the running or walking in shoe appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.RunningWalking appearance category.</summary>
    /// <returns>The appearance subcategory code for a running or walking in shoe Bluetooth LE device.</returns>
    public static extern ushort RunningWalkingInShoe { [MethodImpl] get; }

    /// <summary>Gets the running or walking on shoe appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.RunningWalking appearance category.</summary>
    /// <returns>The appearance subcategory code for a running or walking on shoe Bluetooth LE device.</returns>
    public static extern ushort RunningWalkingOnShoe { [MethodImpl] get; }

    /// <summary>Gets the running or walking on hip appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.RunningWalking appearance category.</summary>
    /// <returns>The appearance subcategory code for a running or walking on hip Bluetooth LE device.</returns>
    public static extern ushort RunningWalkingOnHip { [MethodImpl] get; }

    /// <summary>Gets the cycling computer appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.Cycling appearance category.</summary>
    /// <returns>The appearance subcategory code for a cycling computer Bluetooth LE device.</returns>
    public static extern ushort CyclingComputer { [MethodImpl] get; }

    /// <summary>Gets the cycling speed sensor appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.Cycling appearance category.</summary>
    /// <returns>The appearance subcategory code for a cycling speed sensor Bluetooth LE device.</returns>
    public static extern ushort CyclingSpeedSensor { [MethodImpl] get; }

    /// <summary>Gets the cycling cadence sensor appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.Cycling appearance category.</summary>
    /// <returns>The appearance subcategory code for a cycling cadence sensor Bluetooth LE device.</returns>
    public static extern ushort CyclingCadenceSensor { [MethodImpl] get; }

    /// <summary>Gets the cycling power sensor appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.Cycling appearance category.</summary>
    /// <returns>The appearance subcategory code for a cycling power sensor Bluetooth LE device.</returns>
    public static extern ushort CyclingPowerSensor { [MethodImpl] get; }

    /// <summary>Gets the cycling speed cadence sensor appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.Cycling appearance category.</summary>
    /// <returns>The appearance subcategory code for a cycling speed cadence sensor Bluetooth LE device.</returns>
    public static extern ushort CyclingSpeedCadenceSensor { [MethodImpl] get; }

    /// <summary>Gets the oximeter fingertip appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.PulseOximeter appearance category.</summary>
    /// <returns>The appearance subcategory code for a oximeter fingertip Bluetooth LE device.</returns>
    public static extern ushort OximeterFingertip { [MethodImpl] get; }

    /// <summary>Gets the oximeter wrist worn appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.PulseOximeter appearance category.</summary>
    /// <returns>The appearance subcategory code for a oximeter wrist worn Bluetooth LE device.</returns>
    public static extern ushort OximeterWristWorn { [MethodImpl] get; }

    /// <summary>Gets the location display appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.OutdoorSportActivity appearance category.</summary>
    /// <returns>The appearance subcategory code for a location display Bluetooth LE device.</returns>
    public static extern ushort LocationDisplay { [MethodImpl] get; }

    /// <summary>Gets the location navigation display appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.OutdoorSportActivity appearance category.</summary>
    /// <returns>The appearance subcategory code for a location navigation display Bluetooth LE device.</returns>
    public static extern ushort LocationNavigationDisplay { [MethodImpl] get; }

    /// <summary>Gets the location pod appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.OutdoorSportActivity appearance category.</summary>
    /// <returns>The appearance subcategory code for a location pod Bluetooth LE device.</returns>
    public static extern ushort LocationPod { [MethodImpl] get; }

    /// <summary>Gets the location navigation pod appearance subcategory code. This is only applicable for Bluetooth LE devices that are part of the BluetoothLEAppearanceCategories.OutdoorSportActivity appearance category.</summary>
    /// <returns>The appearance subcategory code for a location navigation pod Bluetooth LE device.</returns>
    public static extern ushort LocationNavigationPod { [MethodImpl] get; }
  }
}
