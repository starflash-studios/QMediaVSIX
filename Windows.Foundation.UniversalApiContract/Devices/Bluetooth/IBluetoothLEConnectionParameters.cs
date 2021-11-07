// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEConnectionParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (BluetoothLEConnectionParameters))]
  [Guid(868943729, 36265, 20623, 163, 102, 28, 163, 136, 201, 41, 171)]
  internal interface IBluetoothLEConnectionParameters
  {
    ushort LinkTimeout { get; }

    ushort ConnectionLatency { get; }

    ushort ConnectionInterval { get; }
  }
}
