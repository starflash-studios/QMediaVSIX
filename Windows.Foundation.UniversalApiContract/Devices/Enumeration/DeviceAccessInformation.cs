// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceAccessInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>Contains the information about access to a device.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IDeviceAccessInformationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DeviceAccessInformation : IDeviceAccessInformation
  {
    /// <summary>Raised when access to a device has changed.</summary>
    public extern event TypedEventHandler<DeviceAccessInformation, DeviceAccessChangedEventArgs> AccessChanged;

    /// <summary>The current device access status.</summary>
    /// <returns>The current device access status.</returns>
    public extern DeviceAccessStatus CurrentStatus { [MethodImpl] get; }

    /// <summary>Initializes a DeviceAccessInformation object based on a device id.</summary>
    /// <param name="deviceId">Id of the device to get DeviceAccessInformation about.</param>
    /// <returns>The DeviceAccessInformation object for the given device id.</returns>
    [MethodImpl]
    public static extern DeviceAccessInformation CreateFromId(string deviceId);

    /// <summary>Initializes a DeviceAccessInformation object based on a device class id.</summary>
    /// <param name="deviceClassId">Id of the device class to get DeviceAccessInformation about.</param>
    /// <returns>The DeviceAccessInformation object for the given device class id.</returns>
    [MethodImpl]
    public static extern DeviceAccessInformation CreateFromDeviceClassId(
      Guid deviceClassId);

    /// <summary>Initializes a DeviceAccessInformation object based on a given DeviceClass.</summary>
    /// <param name="deviceClass">Device class to get DeviceAccessInformation about.</param>
    /// <returns>The DeviceAccessInformation object for the given DeviceClass.</returns>
    [MethodImpl]
    public static extern DeviceAccessInformation CreateFromDeviceClass(
      DeviceClass deviceClass);
  }
}
