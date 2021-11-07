// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothSignalStrengthFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Guid(3749409681, 27573, 19710, 144, 177, 93, 115, 36, 237, 207, 127)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BluetoothSignalStrengthFilter))]
  internal interface IBluetoothSignalStrengthFilter
  {
    IReference<short> InRangeThresholdInDBm { get; set; }

    IReference<short> OutOfRangeThresholdInDBm { get; set; }

    IReference<TimeSpan> OutOfRangeTimeout { get; set; }

    IReference<TimeSpan> SamplingInterval { get; set; }
  }
}
