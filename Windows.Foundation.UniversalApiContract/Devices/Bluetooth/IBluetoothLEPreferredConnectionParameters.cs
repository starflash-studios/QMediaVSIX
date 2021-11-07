// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEPreferredConnectionParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (BluetoothLEPreferredConnectionParameters))]
  [Guid(4076094276, 29554, 24443, 155, 52, 41, 201, 68, 245, 167, 21)]
  internal interface IBluetoothLEPreferredConnectionParameters
  {
    ushort LinkTimeout { get; }

    ushort ConnectionLatency { get; }

    ushort MinConnectionInterval { get; }

    ushort MaxConnectionInterval { get; }
  }
}
