// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IOrientationSensorReadingChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (OrientationSensorReadingChangedEventArgs))]
  [Guid(19665286, 50106, 18108, 174, 101, 122, 152, 153, 108, 191, 184)]
  internal interface IOrientationSensorReadingChangedEventArgs
  {
    OrientationSensorReading Reading { get; }
  }
}
