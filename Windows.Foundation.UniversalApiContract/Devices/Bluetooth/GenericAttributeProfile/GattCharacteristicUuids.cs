// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristicUuids
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>Represents an enumeration of the most well known Characteristic UUID values, and provides convenience methods for working with GATT characteristic UUIDs, and static properties providing characteristic UUIDs for common GATT characteristics.</summary>
  [Static(typeof (IGattCharacteristicUuidsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IGattCharacteristicUuidsStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class GattCharacteristicUuids
  {
    /// <summary>Gets the Bluetooth SIG-defined AlertCategoryId characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined AlertCategoryId characteristic UUID.</returns>
    public static extern Guid AlertCategoryId { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-Defined AlertCategoryIdBitMask characteristic UUID. To view a list of all Bluetooth SIG-defined characteristic UUIDs, see Bluetooth SIG-defined Characteristic UUIDs.</summary>
    /// <returns>The Bluetooth SIG-defined AlertCategoryIdBitMask characteristic UUID.</returns>
    public static extern Guid AlertCategoryIdBitMask { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined AlertLevel characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined AlertLevel characteristic UUID.</returns>
    public static extern Guid AlertLevel { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined AlertNotificationControlPoint characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined AlertNotificationControlPoint characteristic UUID.</returns>
    public static extern Guid AlertNotificationControlPoint { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined AlertStatus characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined AllertStatus characteristic UUID.</returns>
    public static extern Guid AlertStatus { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined GapAppearance characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined GapAppearance characteristic UUID.</returns>
    public static extern Guid GapAppearance { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined BootKeyboardInputReport characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined BootKayboardInputReport characteristic UUID.</returns>
    public static extern Guid BootKeyboardInputReport { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined BootKeyboardOutputReport characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined characteristic UUID.</returns>
    public static extern Guid BootKeyboardOutputReport { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined BootMouseInputReport characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined BootMouseInputReport characteristic UUID.</returns>
    public static extern Guid BootMouseInputReport { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined CurrentTime characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined CurrentTime characteristic UUID.</returns>
    public static extern Guid CurrentTime { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined CyclingPowerControlPoint characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined CyclingPowerControlPoint characteristic UUID.</returns>
    public static extern Guid CyclingPowerControlPoint { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined CyclingPowerFeature characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined CyclingPowerFeature characterisitc UUID.</returns>
    public static extern Guid CyclingPowerFeature { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined CyclingPowerMeasurement characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined CyclingPowerMeasurement characteristic UUID.</returns>
    public static extern Guid CyclingPowerMeasurement { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined CyclingPowerVector characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined CyclingPowerVector characteristic UUID.</returns>
    public static extern Guid CyclingPowerVector { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined DateTime characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined DateTime characteristic UUID.</returns>
    public static extern Guid DateTime { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined DayDateTime characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined DayDateTime characteristic UUID.</returns>
    public static extern Guid DayDateTime { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined DayOfWeek characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined DayOfWeek characteristic UUID.</returns>
    public static extern Guid DayOfWeek { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined GapDeviceName characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined GapDeviceName characteristic UUID.</returns>
    public static extern Guid GapDeviceName { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined DstOffset characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined DstOffset characteristic UUID.</returns>
    public static extern Guid DstOffset { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined ExactTime256 characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined ExactTime256 characteristic UUID.</returns>
    public static extern Guid ExactTime256 { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined FirmwareRevisionString characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined FirmwareRevisionString characteristic UUID.</returns>
    public static extern Guid FirmwareRevisionString { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined HardwareRevisionString characterisitc UUID.</summary>
    /// <returns>The Bluetooth SIG-defined HardwareRevisionString characteristic UUID.</returns>
    public static extern Guid HardwareRevisionString { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined HidControlPoint characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined HidControlPoint characteristic UUID.</returns>
    public static extern Guid HidControlPoint { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined HidInformation characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined HidInformation characteristic UUID.</returns>
    public static extern Guid HidInformation { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Ieee1107320601RegulatoryCertificationDataList characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Ieee1107320601RegulatoryCertificationDataList characteristic UUID.</returns>
    public static extern Guid Ieee1107320601RegulatoryCertificationDataList { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined LnControlPoint characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined LnControlPoint characteristic UUID.</returns>
    public static extern Guid LnControlPoint { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined LnFeature characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined LnFeature characteristic UUID.</returns>
    public static extern Guid LnFeature { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined LocalTimeInformation characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined LocalTimeInformation characteristic UUID.</returns>
    public static extern Guid LocalTimeInformation { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined LocationAndSpeed characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined LocationAndSpeed characteristic UUID.</returns>
    public static extern Guid LocationAndSpeed { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined ManufacturerNameString characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined ManufacturerNameString characteristic UUID.</returns>
    public static extern Guid ManufacturerNameString { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined ModelNumberString UUID.</summary>
    /// <returns>The Bluetooth SIG-defined ModelNumberString UUID.</returns>
    public static extern Guid ModelNumberString { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Navigation characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Navigation characteristic UUID.</returns>
    public static extern Guid Navigation { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined NewAlert characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined NewAlert characteristic UUID.</returns>
    public static extern Guid NewAlert { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined GapPeripheralPreferredConnectionParameters characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined GapPeripheralPreferredConnectionParameters characteristic UUID.</returns>
    public static extern Guid GapPeripheralPreferredConnectionParameters { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth GapPeripheralPrivacyFlag characterisitc UUID.</summary>
    /// <returns>The Bluetooth GapPeripheralPrivacyFlag characteristic UUID.</returns>
    public static extern Guid GapPeripheralPrivacyFlag { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined PnpId characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined PnpId characteristic UUID.</returns>
    public static extern Guid PnpId { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined PositionQuality characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined PositionQuality characteristic UUID.</returns>
    public static extern Guid PositionQuality { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined ProtocolMode characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined ProtocolMode characteristic UUID.</returns>
    public static extern Guid ProtocolMode { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined GapReconnectionAddress characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined GapReconnectionAddress characteristic UUID.</returns>
    public static extern Guid GapReconnectionAddress { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined ReferenceTimeInformation characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined ReferenceTimeInformation characteristic UUID.</returns>
    public static extern Guid ReferenceTimeInformation { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Report characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Report characteristic UUID.</returns>
    public static extern Guid Report { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined ReportMap characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined ReportMap characteristic UUID.</returns>
    public static extern Guid ReportMap { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined RingerControlPoint characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined RingerControlPoint characteristic UUID.</returns>
    public static extern Guid RingerControlPoint { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined RingerSetting characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined RingerSetting characteristic UUID.</returns>
    public static extern Guid RingerSetting { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined ScanIntervalWindow characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined ScanIntervalWindow characteristic UUID.</returns>
    public static extern Guid ScanIntervalWindow { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined ScanRefresh characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined ScanRefresh characteristic UUID.</returns>
    public static extern Guid ScanRefresh { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined SerialNumberString characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined SerialNumberString characteristic UUID.</returns>
    public static extern Guid SerialNumberString { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined GattServiceChanged characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined GattServiceChanged characteristic UUID.</returns>
    public static extern Guid GattServiceChanged { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined SoftwareRevisionString characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined SoftwareRevisionString characteristic UUID.</returns>
    public static extern Guid SoftwareRevisionString { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined SupportedNewAlertCategory characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined SupportedNewAlertCategory characteristic UUID.</returns>
    public static extern Guid SupportedNewAlertCategory { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined SupportUnreadAlertCategory characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined SupportUnreadAlertCategory characteristic UUID.</returns>
    public static extern Guid SupportUnreadAlertCategory { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined SystemId characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined SystemId characteristic UUID.</returns>
    public static extern Guid SystemId { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined TimeAccuracy characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined TimeAccuracy characteristic UUID.</returns>
    public static extern Guid TimeAccuracy { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined TimeSource characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined TimeSource characteristic UUID.</returns>
    public static extern Guid TimeSource { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined TimeUpdateControlPoint characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined TimeUpdateControlPoint characteristic UUID.</returns>
    public static extern Guid TimeUpdateControlPoint { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined TimeUpdateState characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined TimeUpdateState characteristic UUID.</returns>
    public static extern Guid TimeUpdateState { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined TimeWithDst characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined TimeWithDst characteristic UUID.</returns>
    public static extern Guid TimeWithDst { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined TimeZone characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined TimeZone characteristic UUID.</returns>
    public static extern Guid TimeZone { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined TxPowerLevel characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined TxPowerLevel characteristic UUID.</returns>
    public static extern Guid TxPowerLevel { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined UnreadAlertStatus characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined UnreadAlertStatus characteristic UUID.</returns>
    public static extern Guid UnreadAlertStatus { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Battery Level Characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Battery Level Characteristic UUID.</returns>
    public static extern Guid BatteryLevel { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Blood Pressure Feature Characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Blood Pressure Feature Characteristic UUID.</returns>
    public static extern Guid BloodPressureFeature { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Blood Pressure Measurement Characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Blood Pressure Measurement Characteristic UUID.</returns>
    public static extern Guid BloodPressureMeasurement { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Body Sensor Location Characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Body Sensor Location Characteristic UUID.</returns>
    public static extern Guid BodySensorLocation { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Csc Feature Characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Csc Feature Characteristic UUID.</returns>
    public static extern Guid CscFeature { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Csc Measurement Characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Csc Measurement Characteristic UUID.</returns>
    public static extern Guid CscMeasurement { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Glucose Feature Characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Glucose Feature Characteristic UUID.</returns>
    public static extern Guid GlucoseFeature { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Glucose Measurement Characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Glucose Measurement Characteristic UUID.</returns>
    public static extern Guid GlucoseMeasurement { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Glucose Measurement Context Characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Glucose Measurement Context Characteristic UUID.</returns>
    public static extern Guid GlucoseMeasurementContext { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Heart Rate Control Point Characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Heart Rate Control Point Characteristic UUID.</returns>
    public static extern Guid HeartRateControlPoint { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Heart Rate Measurement Characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Heart Rate Measurement Characteristic UUID.</returns>
    public static extern Guid HeartRateMeasurement { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Intermediate Cuff Pressure Characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Intermediate Cuff Pressure Characteristic UUID.</returns>
    public static extern Guid IntermediateCuffPressure { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Intermediate Temperature Characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Intermediate Temperature Characteristic UUID.</returns>
    public static extern Guid IntermediateTemperature { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Measurement Interval Characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Measurement Interval Characteristic UUID.</returns>
    public static extern Guid MeasurementInterval { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Record Access Control Point Characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Record Access Control Point Characteristic UUID.</returns>
    public static extern Guid RecordAccessControlPoint { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Rsc Feature Characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Rsc Feature Characteristic UUID.</returns>
    public static extern Guid RscFeature { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Rsc Measurement Characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Rsc Measurement Characteristic UUID.</returns>
    public static extern Guid RscMeasurement { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined SC Control Point Characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined SC Control Point Characteristic UUID.</returns>
    public static extern Guid SCControlPoint { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Sensor Location Characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Sensor Location Characteristic UUID.</returns>
    public static extern Guid SensorLocation { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Temperature Measurement Characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Temperature Measurement Characteristic UUID.</returns>
    public static extern Guid TemperatureMeasurement { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Temperature Type Characteristic UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Temperature Type Characteristic UUID.</returns>
    public static extern Guid TemperatureType { [MethodImpl] get; }
  }
}
