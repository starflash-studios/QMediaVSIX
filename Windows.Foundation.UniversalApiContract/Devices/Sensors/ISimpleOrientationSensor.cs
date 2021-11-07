// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ISimpleOrientationSensor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SimpleOrientationSensor))]
  [Guid(1609906262, 8522, 19950, 163, 249, 97, 111, 26, 176, 111, 253)]
  internal interface ISimpleOrientationSensor
  {
    SimpleOrientation GetCurrentOrientation();

    event TypedEventHandler<SimpleOrientationSensor, SimpleOrientationSensorOrientationChangedEventArgs> OrientationChanged;
  }
}
