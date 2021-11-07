// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothLEAppearanceCategories
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  /// <summary>Indicates the appearance category code of the Bluetooth LE device.</summary>
  [DualApiPartition(version = 1)]
  [Static(typeof (IBluetoothLEAppearanceCategoriesStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public static class BluetoothLEAppearanceCategories
  {
    /// <summary>Gets the uncategorized appearance category code.</summary>
    /// <returns>The appearance category code for an uncategorized Bluetooth LE device.</returns>
    public static extern ushort Uncategorized { [MethodImpl] get; }

    /// <summary>Gets the phone appearance category code.</summary>
    /// <returns>The appearance category code for a phone Bluetooth LE device.</returns>
    public static extern ushort Phone { [MethodImpl] get; }

    /// <summary>Gets the computer appearance category code.</summary>
    /// <returns>The appearance category code for a computer Bluetooth LE device.</returns>
    public static extern ushort Computer { [MethodImpl] get; }

    /// <summary>Gets the watch appearance category code.</summary>
    /// <returns>The appearance category code for a watch Bluetooth LE device.</returns>
    public static extern ushort Watch { [MethodImpl] get; }

    /// <summary>Gets the clock appearance category code.</summary>
    /// <returns>The appearance category code for a clock Bluetooth LE device.</returns>
    public static extern ushort Clock { [MethodImpl] get; }

    /// <summary>Gets the display appearance category code.</summary>
    /// <returns>The appearance category code for a display Bluetooth LE device.</returns>
    public static extern ushort Display { [MethodImpl] get; }

    /// <summary>Gets the remote control appearance category code.</summary>
    /// <returns>The appearance category code for a remote control Bluetooth LE device.</returns>
    public static extern ushort RemoteControl { [MethodImpl] get; }

    /// <summary>Gets the eye glasses appearance category code.</summary>
    /// <returns>The appearance category code for an eye glasses Bluetooth LE device.</returns>
    public static extern ushort EyeGlasses { [MethodImpl] get; }

    /// <summary>Gets the tag appearance category code.</summary>
    /// <returns>The appearance category code for a tag Bluetooth LE device.</returns>
    public static extern ushort Tag { [MethodImpl] get; }

    /// <summary>Gets the key ring appearance category code.</summary>
    /// <returns>The appearance category code for a key ring Bluetooth LE device.</returns>
    public static extern ushort Keyring { [MethodImpl] get; }

    /// <summary>Gets the media player appearance category code.</summary>
    /// <returns>The appearance category code for a media player Bluetooth LE device.</returns>
    public static extern ushort MediaPlayer { [MethodImpl] get; }

    /// <summary>Gets the barcode scanner appearance category code.</summary>
    /// <returns>The appearance category code for a barcode scanner Bluetooth LE device.</returns>
    public static extern ushort BarcodeScanner { [MethodImpl] get; }

    /// <summary>Gets the thermometer appearance category code.</summary>
    /// <returns>The appearance category code for a thermometer Bluetooth LE device.</returns>
    public static extern ushort Thermometer { [MethodImpl] get; }

    /// <summary>Gets the heart rate appearance category code.</summary>
    /// <returns>The appearance category code for a heart rate Bluetooth LE device.</returns>
    public static extern ushort HeartRate { [MethodImpl] get; }

    /// <summary>Gets the blood pressure appearance category code.</summary>
    /// <returns>The appearance category code for a blood pressure Bluetooth LE device.</returns>
    public static extern ushort BloodPressure { [MethodImpl] get; }

    /// <summary>Gets the human interface device appearance category code.</summary>
    /// <returns>The appearance category code for a human interface device Bluetooth LE device.</returns>
    public static extern ushort HumanInterfaceDevice { [MethodImpl] get; }

    /// <summary>Gets the glucose meter appearance category code.</summary>
    /// <returns>The appearance category code for a glucose meter Bluetooth LE device.</returns>
    public static extern ushort GlucoseMeter { [MethodImpl] get; }

    /// <summary>Gets the running or walking appearance category code.</summary>
    /// <returns>The appearance category code for a running or walking Bluetooth LE device.</returns>
    public static extern ushort RunningWalking { [MethodImpl] get; }

    /// <summary>Gets the cycling appearance category code.</summary>
    /// <returns>The appearance category code for a cycling Bluetooth LE device.</returns>
    public static extern ushort Cycling { [MethodImpl] get; }

    /// <summary>Gets the pulse oximeter appearance category code.</summary>
    /// <returns>The appearance category code for a pulse oximeter Bluetooth LE device.</returns>
    public static extern ushort PulseOximeter { [MethodImpl] get; }

    /// <summary>Gets the weight scale appearance category code.</summary>
    /// <returns>The appearance category code for a weight scale Bluetooth LE device.</returns>
    public static extern ushort WeightScale { [MethodImpl] get; }

    /// <summary>Gets the outdoor sport activity appearance category code.</summary>
    /// <returns>The appearance category code for an outdoor sport activity Bluetooth LE device.</returns>
    public static extern ushort OutdoorSportActivity { [MethodImpl] get; }
  }
}
