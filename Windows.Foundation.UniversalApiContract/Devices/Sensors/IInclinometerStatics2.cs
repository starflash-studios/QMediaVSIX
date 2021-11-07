// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IInclinometerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Inclinometer))]
  [Guid(71276405, 27166, 18844, 134, 224, 99, 140, 26, 134, 75, 0)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IInclinometerStatics2
  {
    Inclinometer GetDefaultForRelativeReadings();
  }
}
