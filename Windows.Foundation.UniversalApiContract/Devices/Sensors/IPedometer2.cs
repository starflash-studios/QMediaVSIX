// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IPedometer2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(3852732127, 11137, 19165, 178, 255, 119, 171, 108, 152, 186, 25)]
  [ExclusiveTo(typeof (Pedometer))]
  internal interface IPedometer2
  {
    IMapView<PedometerStepKind, PedometerReading> GetCurrentReadings();
  }
}
