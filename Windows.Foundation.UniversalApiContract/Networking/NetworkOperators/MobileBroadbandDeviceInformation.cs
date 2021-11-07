// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandDeviceInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Sms;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Represents the current state of the mobile broadband network device for the account.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class MobileBroadbandDeviceInformation : 
    IMobileBroadbandDeviceInformation,
    IMobileBroadbandDeviceInformation2,
    IMobileBroadbandDeviceInformation3,
    IMobileBroadbandDeviceInformation4
  {
    /// <summary>Gets the readiness status of the mobile broadband network device.</summary>
    /// <returns>The readiness status of the mobile broadband network device.</returns>
    public extern NetworkDeviceStatus NetworkDeviceStatus { [MethodImpl] get; }

    /// <summary>Gets the name of the manufacturer of the mobile broadband network device.</summary>
    /// <returns>The name of the manufacturer of the mobile broadband network device.</returns>
    public extern string Manufacturer { [MethodImpl] get; }

    /// <summary>Gets the name of the model of the mobile broadband network device.</summary>
    /// <returns>The name of the model of the mobile broadband network device.</returns>
    public extern string Model { [MethodImpl] get; }

    /// <summary>Gets the device-specific firmware information for the mobile broadband network device.</summary>
    /// <returns>The device-specific firmware information for the mobile broadband network device.</returns>
    public extern string FirmwareInformation { [MethodImpl] get; }

    /// <summary>Gets the cellular technology used by the mobile broadband network device.</summary>
    /// <returns>The cellular technology used by the mobile broadband network device.</returns>
    public extern CellularClass CellularClass { [MethodImpl] get; }

    /// <summary>Gets the cellular data services supported by the mobile broadband network device.</summary>
    /// <returns>The cellular data services supported by the mobile broadband network device.</returns>
    public extern DataClasses DataClasses { [MethodImpl] get; }

    /// <summary>Gets the name of the data class when the DataClasses property returns **Custom**.</summary>
    /// <returns>The name of the data class when the DataClasses property returns **Custom**.</returns>
    public extern string CustomDataClass { [MethodImpl] get; }

    /// <summary>Gets the value that uniquely identifies the mobile broadband device to the network provider.</summary>
    /// <returns>The value that uniquely identifies the mobile broadband device to the network provider.</returns>
    public extern string MobileEquipmentId { [MethodImpl] get; }

    /// <summary>Gets the telephone numbers for the mobile broadband device.</summary>
    /// <returns>The telephone numbers for the mobile broadband device.</returns>
    public extern IVectorView<string> TelephoneNumbers { [MethodImpl] get; }

    /// <summary>Gets the subscriber identifier for the mobile broadband network device.</summary>
    /// <returns>The subscriber identifier for the mobile broadband network device.</returns>
    public extern string SubscriberId { [MethodImpl] get; }

    /// <summary>Gets the SIM integrated circuit card identifier (ICCID) for the mobile broadband network device.</summary>
    /// <returns>The SIM integrated circuit card identifier (ICCID) for the mobile broadband network device.</returns>
    public extern string SimIccId { [MethodImpl] get; }

    /// <summary>Gets a value indicating the type of Mobile Broadband device.</summary>
    /// <returns>A value indicating the type of Mobile Broadband device.</returns>
    public extern MobileBroadbandDeviceType DeviceType { [MethodImpl] get; }

    /// <summary>Gets the DeviceInformation Id of the mobile broadband device.</summary>
    /// <returns>The DeviceInformation Id of the mobile broadband device.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets a value indicating the radio state of the device.</summary>
    /// <returns>A value indicating the radio state of the device.</returns>
    public extern MobileBroadbandRadioState CurrentRadioState { [MethodImpl] get; }

    /// <summary>Gets a MobileBroadbandPinManager object for the mobile broadband device.</summary>
    /// <returns>A MobileBroadbandPinManager object for the mobile broadband device.</returns>
    public extern MobileBroadbandPinManager PinManager { [MethodImpl] get; }

    /// <summary>Gets the revision of the mobile broadband device.</summary>
    /// <returns>The revision of the mobile broadband device.</returns>
    public extern string Revision { [MethodImpl] get; }

    /// <summary>Gets the serial number of the mobile broadband device.</summary>
    /// <returns>The serial number of the mobile broadband device.</returns>
    public extern string SerialNumber { [MethodImpl] get; }

    /// <summary>Gets the Service Provider Name (SPN) for the mobile broadband device.</summary>
    /// <returns>The string value of the SPN obtained from the SIM card.</returns>
    public extern string SimSpn { [MethodImpl] get; }

    /// <summary>Gets the Public Land Mobile Network (PLMN) name for the mobile broadband device.</summary>
    /// <returns>The string value of the PLMN obtained from the SIM card.</returns>
    public extern string SimPnn { [MethodImpl] get; }

    /// <summary>Gets the Group Identifier Level 1 (GID1) of the mobile broadband network device.</summary>
    /// <returns>THe string value of the GID1 obtained from the SIM card.</returns>
    public extern string SimGid1 { [MethodImpl] get; }

    public extern MobileBroadbandSlotManager SlotManager { [MethodImpl] get; }
  }
}
