// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothSignalStrengthFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  /// <summary>Groups parameters used to configure received signal strength indicator (RSSI)-based filtering.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 1)]
  public sealed class BluetoothSignalStrengthFilter : IBluetoothSignalStrengthFilter
  {
    /// <summary>Create a new BluetoothSignalStrengthFilter object.</summary>
    [MethodImpl]
    public extern BluetoothSignalStrengthFilter();

    /// <summary>The minimum received signal strength indicator (RSSI) value in dBm on which RSSI events will be propagated or considered in range if the previous events were considered out of range.</summary>
    /// <returns>The minimum RSSI value in dBm on which RSSI events will be propagated or considered in range.</returns>
    public extern IReference<short> InRangeThresholdInDBm { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The minimum received signal strength indicator (RSSI) value in dBm on which RSSI events will be considered out of range.</summary>
    /// <returns>The minimum RSSI value in dBm on which RSSI events will be considered out of range.</returns>
    public extern IReference<short> OutOfRangeThresholdInDBm { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The timeout for a received signal strength indicator (RSSI) event to be considered out of range.</summary>
    /// <returns>The timeout for an RSSI event to be considered out of range.</returns>
    public extern IReference<TimeSpan> OutOfRangeTimeout { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The interval at which received signal strength indicator (RSSI) events are sampled.</summary>
    /// <returns>The interval at which RSSI events are sampled.</returns>
    public extern IReference<TimeSpan> SamplingInterval { [MethodImpl] get; [MethodImpl] set; }
  }
}
