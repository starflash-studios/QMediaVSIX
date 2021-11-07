// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothDeviceId
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  /// <summary>Represents a bluetooth device ID.</summary>
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IBluetoothDeviceIdStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class BluetoothDeviceId : IBluetoothDeviceId
  {
    /// <summary>Gets the bluetooth device ID.</summary>
    /// <returns>Gets the bluetooth device ID.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets a boolean indicating if this is a classic device.</summary>
    /// <returns>Gets a boolean indicating if this is a classic device.</returns>
    public extern bool IsClassicDevice { [MethodImpl] get; }

    /// <summary>Gets a boolean indicating if this is a LowEnergy device.</summary>
    /// <returns>Gets a boolean indicating if this is a LowEnergy device.</returns>
    public extern bool IsLowEnergyDevice { [MethodImpl] get; }

    /// <summary>Creates a BluetoothDeviceId object from the device ID.</summary>
    /// <param name="deviceId">The device ID.</param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public static extern BluetoothDeviceId FromId(string deviceId);
  }
}
