// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAccelerometerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(3301213231, 55403, 18053, 178, 215, 51, 150, 247, 152, 213, 123)]
  [ExclusiveTo(typeof (Accelerometer))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAccelerometerStatics2
  {
    [Overload("GetDefaultWithAccelerometerReadingType")]
    Accelerometer GetDefault(AccelerometerReadingType readingType);
  }
}
