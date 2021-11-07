// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothLEAppearance
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  /// <summary>Provides functionality to determine the Bluetooth Low Energy (LE) Appearance information for a device. To get an instance of this class, call the BluetoothLEAppearance.FromRawValue method or the BluetoothLEAppearance.FromParts method.</summary>
  [Static(typeof (IBluetoothLEAppearanceStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class BluetoothLEAppearance : IBluetoothLEAppearance
  {
    /// <summary>Gets the appearance raw value of the Bluetooth LE device.</summary>
    /// <returns>The appearance raw value of the Bluetooth LE device.</returns>
    public extern ushort RawValue { [MethodImpl] get; }

    /// <summary>Gets the appearance category value of the Bluetooth LE device.</summary>
    /// <returns>The appearance category of the Bluetooth LE device. For more info see BluetoothLEAppearanceCategories</returns>
    public extern ushort Category { [MethodImpl] get; }

    /// <summary>Gets the appearance subcategory value of the Bluetooth LE device.</summary>
    /// <returns>The appearance subcategory of the Bluetooth LE device. For more info, see BluetoothLEAppearanceSubcategories</returns>
    public extern ushort SubCategory { [MethodImpl] get; }

    /// <summary>Creates a BluetoothLEAppearance object by supplying for raw integer values representing the Category and Subcategory of the Bluetooth LE device.</summary>
    /// <param name="rawValue">The raw integer value representing the appearance category and subcategory.</param>
    /// <returns>The Bluetooth LE appearance object that was created from the appearance category and subcategory.</returns>
    [MethodImpl]
    public static extern BluetoothLEAppearance FromRawValue(ushort rawValue);

    /// <summary>Creates a BluetoothLEAppearance object by supplying values for Category (see BluetoothLEAppearanceCategories ) and Subcategory (see BluetoothLEAppearanceSubcategories ) of the Bluetooth LE device.</summary>
    /// <param name="appearanceCategory">The Bluetooth LE appearance category. See BluetoothLEAppearanceCategories.</param>
    /// <param name="appearanceSubCategory">The Bluetooth LE appearance subcategory. See BluetoothLEAppearanceSubcategories.</param>
    /// <returns>The Bluetooth LE appearance object that was created from the appearance category and subcategory.</returns>
    [MethodImpl]
    public static extern BluetoothLEAppearance FromParts(
      ushort appearanceCategory,
      ushort appearanceSubCategory);
  }
}
