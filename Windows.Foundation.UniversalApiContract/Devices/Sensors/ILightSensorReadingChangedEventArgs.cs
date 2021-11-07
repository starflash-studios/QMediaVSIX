// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ILightSensorReadingChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (LightSensorReadingChangedEventArgs))]
  [Guid(2745365711, 9611, 16908, 184, 171, 142, 221, 96, 30, 207, 80)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILightSensorReadingChangedEventArgs
  {
    LightSensorReading Reading { get; }
  }
}
