// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattValueChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>Represents the arguments received by a GattCharacteristic.ValueChanged event handler used to process characteristic value change notification and indication events sent by a Bluetooth LE device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GattValueChangedEventArgs : IGattValueChangedEventArgs
  {
    /// <summary>Gets the new Characteristic Value.</summary>
    /// <returns>The new Characteristic Value.</returns>
    public extern IBuffer CharacteristicValue { [MethodImpl] get; }

    /// <summary>Gets the time at which the system was notified of the Characteristic Value change.</summary>
    /// <returns>The time at which the system was notified of the Characteristic Value change.</returns>
    public extern DateTime Timestamp { [MethodImpl] get; }
  }
}
