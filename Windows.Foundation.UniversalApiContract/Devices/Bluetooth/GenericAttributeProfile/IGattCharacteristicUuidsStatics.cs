// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattCharacteristicUuidsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(1492796806, 45534, 18188, 183, 222, 13, 17, 255, 68, 244, 183)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GattCharacteristicUuids))]
  internal interface IGattCharacteristicUuidsStatics
  {
    Guid BatteryLevel { get; }

    Guid BloodPressureFeature { get; }

    Guid BloodPressureMeasurement { get; }

    Guid BodySensorLocation { get; }

    Guid CscFeature { get; }

    Guid CscMeasurement { get; }

    Guid GlucoseFeature { get; }

    Guid GlucoseMeasurement { get; }

    Guid GlucoseMeasurementContext { get; }

    Guid HeartRateControlPoint { get; }

    Guid HeartRateMeasurement { get; }

    Guid IntermediateCuffPressure { get; }

    Guid IntermediateTemperature { get; }

    Guid MeasurementInterval { get; }

    Guid RecordAccessControlPoint { get; }

    Guid RscFeature { get; }

    Guid RscMeasurement { get; }

    Guid SCControlPoint { get; }

    Guid SensorLocation { get; }

    Guid TemperatureMeasurement { get; }

    Guid TemperatureType { get; }
  }
}
