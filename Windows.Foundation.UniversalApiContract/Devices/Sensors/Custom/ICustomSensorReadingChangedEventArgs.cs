// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Custom.ICustomSensorReadingChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors.Custom
{
  [ExclusiveTo(typeof (CustomSensorReadingChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1797267491, 53245, 19649, 143, 240, 226, 24, 35, 215, 111, 204)]
  internal interface ICustomSensorReadingChangedEventArgs
  {
    CustomSensorReading Reading { get; }
  }
}
