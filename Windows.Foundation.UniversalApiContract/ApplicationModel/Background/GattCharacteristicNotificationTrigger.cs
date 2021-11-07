// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.GattCharacteristicNotificationTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth.Background;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a trigger that launches a background task when an incoming change notification is received for a Bluetooth LE GATT characteristic.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IGattCharacteristicNotificationTriggerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IGattCharacteristicNotificationTriggerFactory2), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GattCharacteristicNotificationTrigger : 
    IGattCharacteristicNotificationTrigger,
    IBackgroundTrigger,
    IGattCharacteristicNotificationTrigger2
  {
    /// <summary>Initializes a new instance of the **GattCharacteristicNotificationTrigger** class with the specified characteristic and triggering mode.</summary>
    /// <param name="characteristic">The GATT characteristic that you want value change notifications for.</param>
    /// <param name="eventTriggeringMode">Specifies when the trigger is activated.</param>
    [MethodImpl]
    public extern GattCharacteristicNotificationTrigger(
      GattCharacteristic characteristic,
      BluetoothEventTriggeringMode eventTriggeringMode);

    /// <summary>Initializes a new instance of the GattCharacteristicNotificationTrigger class.</summary>
    /// <param name="characteristic">The GATT characteristic for which value change notifications are desired.</param>
    [MethodImpl]
    public extern GattCharacteristicNotificationTrigger(GattCharacteristic characteristic);

    /// <summary>Gets the GATT characteristic for which value change notifications are desired.</summary>
    /// <returns>The GATT characteristic for which value change notifications are desired.</returns>
    public extern GattCharacteristic Characteristic { [MethodImpl] get; }

    /// <summary>Gets the mode for the trigger. The mode specifies when the trigger is activated.</summary>
    /// <returns>The trigger mode.</returns>
    public extern BluetoothEventTriggeringMode EventTriggeringMode { [MethodImpl] get; }
  }
}
