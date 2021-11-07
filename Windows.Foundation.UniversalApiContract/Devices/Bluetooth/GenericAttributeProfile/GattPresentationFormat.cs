// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattPresentationFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>Represents the value of a single Presentation Format GATT Descriptor.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IGattPresentationFormatStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IGattPresentationFormatStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 1)]
  public sealed class GattPresentationFormat : IGattPresentationFormat
  {
    /// <summary>Gets the Format Type of the GattPresentationFormat object.</summary>
    /// <returns>The Format Type of the GattPresentationFormat object.</returns>
    public extern byte FormatType { [MethodImpl] get; }

    /// <summary>Gets the Exponent of the GattPresentationFormat object.</summary>
    /// <returns>The Exponent of the GattPresentationFormat object.</returns>
    public extern int Exponent { [MethodImpl] get; }

    /// <summary>Gets the Unit of the GattPresentationFormat object.</summary>
    /// <returns>The Unit of the GattPresentationFormat object.</returns>
    public extern ushort Unit { [MethodImpl] get; }

    /// <summary>Gets the Namespace of the GattPresentationFormat object.</summary>
    /// <returns>The Namespace of the GattPresentationFormat object.</returns>
    public extern byte Namespace { [MethodImpl] get; }

    /// <summary>Gets the Description of the GattPresentationFormat object.</summary>
    /// <returns>The Description of the GattPresentationFormat object.</returns>
    public extern ushort Description { [MethodImpl] get; }

    /// <summary>Creates a GattPresentationFormat object from parts.</summary>
    /// <param name="formatType">The Format Type.</param>
    /// <param name="exponent">The exponent.</param>
    /// <param name="unit">The unit.</param>
    /// <param name="namespaceId">The namespace ID.</param>
    /// <param name="description">The description.</param>
    /// <returns>An instance of GattPresentationFormat.</returns>
    [MethodImpl]
    public static extern GattPresentationFormat FromParts(
      byte formatType,
      int exponent,
      ushort unit,
      byte namespaceId,
      ushort description);

    /// <summary>Gets the value of the Bluetooth SIG Assigned Numbers Namespace.</summary>
    /// <returns>The value of the Bluetooth SIG Assigned Numbers Namespace.</returns>
    public static extern byte BluetoothSigAssignedNumbers { [MethodImpl] get; }
  }
}
