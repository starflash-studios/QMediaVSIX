// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAccelerometerReadingChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (AccelerometerReadingChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(9815643, 46764, 18266, 159, 68, 139, 50, 211, 90, 63, 37)]
  internal interface IAccelerometerReadingChangedEventArgs
  {
    AccelerometerReading Reading { get; }
  }
}
