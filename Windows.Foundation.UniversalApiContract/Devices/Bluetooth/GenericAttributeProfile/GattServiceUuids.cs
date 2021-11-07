// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceUuids
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>Represents an enumeration of the most well known Service UUID values, and provides convenience methods for working with GATT service UUIDs, and static properties providing service UUIDs for common GATT services. To view a list of all Bluetooth SIG-defined service UUIDs, see Bluetooth SIG-defined Service UUIDs.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IGattServiceUuidsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IGattServiceUuidsStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 1)]
  public static class GattServiceUuids
  {
    /// <summary>Gets the Bluetooth SIG-defined AlertNotification Service UUID.</summary>
    /// <returns>The Bluetooth SIG-defined AlertNotification Service UUID.</returns>
    public static extern Guid AlertNotification { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined CurrentTime service UUID.</summary>
    /// <returns>The Bluetooth SIG-defined CurrentTime service UUID.</returns>
    public static extern Guid CurrentTime { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined CyclingPower service UUID.</summary>
    /// <returns>The Bluetooth SIG-defined CyclingPower service UUID.</returns>
    public static extern Guid CyclingPower { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined DeviceInformation service UUID.</summary>
    /// <returns>The Bluetooth SIG-defined DeviceInformation UUID.</returns>
    public static extern Guid DeviceInformation { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined HumanInterfaceDevice service UUID.</summary>
    /// <returns>The Bluetooth SIG-defined HumanInterfaceDevice service UUID.</returns>
    public static extern Guid HumanInterfaceDevice { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined ImmediateAlert service UUID.</summary>
    /// <returns>The Bluetooth SIG-defined ImmediateAlert service UUID.</returns>
    public static extern Guid ImmediateAlert { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined LinkLoss service UUID.</summary>
    /// <returns>The Bluetooth SIG-defined LinkLoss service UUID.</returns>
    public static extern Guid LinkLoss { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined LocationAndNavigation service UUID.</summary>
    /// <returns>The Bluetooth SIG-defined LocationAndNavigation service UUID.</returns>
    public static extern Guid LocationAndNavigation { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined NextDstChange service UUID.</summary>
    /// <returns>The Bluetooth SIG-defined NextDstChange service UUID.</returns>
    public static extern Guid NextDstChange { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined PhoneAlertStatus service UUID.</summary>
    /// <returns>The Bluetooth SIG-defined PhoneAlertStatus service UUID.</returns>
    public static extern Guid PhoneAlertStatus { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined ReferenceTimeUpdate service UUID.</summary>
    /// <returns>The Bluetooth SIG-defined ReferenceTimeUpdate service UUID.</returns>
    public static extern Guid ReferenceTimeUpdate { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined ScanParameters service UUID.</summary>
    /// <returns>The Bluetooth SIG-defined ScanParameters service UUID.</returns>
    public static extern Guid ScanParameters { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined TxPower service UUID.</summary>
    /// <returns>The Bluetooth SIG-defined TxPower service UUID.</returns>
    public static extern Guid TxPower { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Battery Service UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Battery Service UUID.</returns>
    public static extern Guid Battery { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Blood Pressure Service UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Blood Pressure Service UUID.</returns>
    public static extern Guid BloodPressure { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Cycling Speed And Cadence Service UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Cycling Speed And Cadence Service UUID.</returns>
    public static extern Guid CyclingSpeedAndCadence { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined UUID for the Generic Access Service.</summary>
    /// <returns>The Bluetooth SIG-defined UUID for the Generic Access Service.</returns>
    public static extern Guid GenericAccess { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined UUID for the Generic Attribute Service.</summary>
    /// <returns>The Bluetooth SIG-defined UUID for the Generic Attribute Service.</returns>
    public static extern Guid GenericAttribute { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Glucose Service UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Glucose Service UUID.</returns>
    public static extern Guid Glucose { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Health Thermometer Service UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Health Thermometer Service UUID.</returns>
    public static extern Guid HealthThermometer { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Heart Rate Service UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Heart Rate Service UUID.</returns>
    public static extern Guid HeartRate { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth SIG-defined Running Speed And Cadence Service UUID.</summary>
    /// <returns>The Bluetooth SIG-defined Running Speed And Cadence Service UUID.</returns>
    public static extern Guid RunningSpeedAndCadence { [MethodImpl] get; }
  }
}
