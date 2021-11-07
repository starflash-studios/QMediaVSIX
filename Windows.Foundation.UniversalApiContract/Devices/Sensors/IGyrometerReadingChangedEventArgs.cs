// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IGyrometerReadingChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(266279061, 28574, 17102, 141, 88, 56, 140, 10, 184, 53, 109)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GyrometerReadingChangedEventArgs))]
  internal interface IGyrometerReadingChangedEventArgs
  {
    GyrometerReading Reading { get; }
  }
}
