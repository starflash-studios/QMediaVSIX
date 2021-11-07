// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothLEPreferredConnectionParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [Static(typeof (IBluetoothLEPreferredConnectionParametersStatics), 851968, "Windows.Foundation.UniversalApiContract")]
  public sealed class BluetoothLEPreferredConnectionParameters : 
    IBluetoothLEPreferredConnectionParameters
  {
    public extern ushort LinkTimeout { [MethodImpl] get; }

    public extern ushort ConnectionLatency { [MethodImpl] get; }

    public extern ushort MinConnectionInterval { [MethodImpl] get; }

    public extern ushort MaxConnectionInterval { [MethodImpl] get; }

    public static extern BluetoothLEPreferredConnectionParameters Balanced { [MethodImpl] get; }

    public static extern BluetoothLEPreferredConnectionParameters ThroughputOptimized { [MethodImpl] get; }

    public static extern BluetoothLEPreferredConnectionParameters PowerOptimized { [MethodImpl] get; }
  }
}
