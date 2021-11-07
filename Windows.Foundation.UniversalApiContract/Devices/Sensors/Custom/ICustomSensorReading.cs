// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Custom.ICustomSensorReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors.Custom
{
  [Guid(1677741901, 17514, 17254, 168, 122, 95, 150, 50, 104, 236, 83)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CustomSensorReading))]
  internal interface ICustomSensorReading
  {
    DateTime Timestamp { get; }

    IMapView<string, object> Properties { get; }
  }
}
