// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattDescriptorUuids
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>Represents an enumeration of the most well known Descriptor UUID values, and provides convenience methods for working with GATT descriptor UUIDs, and static properties providing descriptor UUIDs for common GATT descriptors.</summary>
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IGattDescriptorUuidsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class GattDescriptorUuids
  {
    /// <summary>Gets the Bluetooth SIG-defined Characteristic Aggregate Format Descriptor UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Characteristic Aggregate Format Descriptor UUID.</returns>
    public static extern Guid CharacteristicAggregateFormat { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Characteristic Extended Properties Descriptor UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Characteristic Extended Properties Descriptor UUID.</returns>
    public static extern Guid CharacteristicExtendedProperties { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Characteristic Presentation Format Descriptor UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Characteristic Presentation Format Descriptor UUID.</returns>
    public static extern Guid CharacteristicPresentationFormat { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Characteristic User Description Descriptor UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Characteristic User Description Descriptor UUID.</returns>
    public static extern Guid CharacteristicUserDescription { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Client Characteristic Configuration Descriptor UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Client Characteristic Configuration Descriptor UUID.</returns>
    public static extern Guid ClientCharacteristicConfiguration { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Server Characteristic Configuration Descriptor UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Server Characteristic Configuration Descriptor UUID.</returns>
    public static extern Guid ServerCharacteristicConfiguration { [MethodImpl] get; }
  }
}
