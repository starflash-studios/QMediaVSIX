// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristicProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>Specifies the values for the GATT characteristic properties as well as the GATT Extended Characteristic Properties Descriptor.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum GattCharacteristicProperties : uint
  {
    /// <summary>The characteristic doesn’t have any properties that apply.</summary>
    None = 0,
    /// <summary>The characteristic supports broadcasting</summary>
    Broadcast = 1,
    /// <summary>The characteristic is readable</summary>
    Read = 2,
    /// <summary>The characteristic supports Write Without Response</summary>
    WriteWithoutResponse = 4,
    /// <summary>The characteristic is writable</summary>
    Write = 8,
    /// <summary>The characteristic is notifiable</summary>
    Notify = 16, // 0x00000010
    /// <summary>The characteristic is indicatable</summary>
    Indicate = 32, // 0x00000020
    /// <summary>The characteristic supports signed writes</summary>
    AuthenticatedSignedWrites = 64, // 0x00000040
    /// <summary>The ExtendedProperties Descriptor is present</summary>
    ExtendedProperties = 128, // 0x00000080
    /// <summary>The characteristic supports reliable writes</summary>
    ReliableWrites = 256, // 0x00000100
    /// <summary>The characteristic has writable auxiliaries</summary>
    WritableAuxiliaries = 512, // 0x00000200
  }
}
