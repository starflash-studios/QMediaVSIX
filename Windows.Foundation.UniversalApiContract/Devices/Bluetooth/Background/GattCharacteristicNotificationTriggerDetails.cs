// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.GattCharacteristicNotificationTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Background
{
  /// <summary>Provides information about the Bluetooth LE device that caused this trigger to fire.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class GattCharacteristicNotificationTriggerDetails : 
    IGattCharacteristicNotificationTriggerDetails,
    IGattCharacteristicNotificationTriggerDetails2
  {
    /// <summary>Gets the GATT characteristic that changed.</summary>
    /// <returns>The GATT characteristic that changed.</returns>
    public extern GattCharacteristic Characteristic { [MethodImpl] get; }

    /// <summary>Gets a byte stream containing the new value of the characteristic.</summary>
    /// <returns>A byte stream containing the new value of the characteristic.</returns>
    public extern IBuffer Value { [MethodImpl] get; }

    /// <summary>Gets the error status for the trigger.</summary>
    /// <returns>Gets the error status for the trigger.</returns>
    public extern BluetoothError Error { [MethodImpl] get; }

    /// <summary>Gets the event trigger mode.</summary>
    /// <returns>Gets the event trigger mode.</returns>
    public extern BluetoothEventTriggeringMode EventTriggeringMode { [MethodImpl] get; }

    /// <summary>Gets the value changes events for this trigger.</summary>
    /// <returns>Gets the value changes events for this trigger.</returns>
    public extern IVectorView<GattValueChangedEventArgs> ValueChangedEvents { [MethodImpl] get; }
  }
}
