// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.DeviceConnectionChangeTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a trigger that launches a background task when the connection status of a device changes.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IDeviceConnectionChangeTriggerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class DeviceConnectionChangeTrigger : 
    IDeviceConnectionChangeTrigger,
    IBackgroundTrigger
  {
    /// <summary>Gets the device Id associated with the device.</summary>
    /// <returns>The device Id associated with the device.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets whether the system can maintain a connection to the specified device.</summary>
    /// <returns>True if the system can maintain a connection to the specified device; Otherwise, false. If false, an attempt to register a trigger with MaintainConnection = true will throw an exception. The default value of this property is true for Bluetooth LE devices and false for all other device types.</returns>
    public extern bool CanMaintainConnection { [MethodImpl] get; }

    /// <summary>Gets or sets whether the system should automatically attempt to keep the referenced device connected.</summary>
    /// <returns>True of the system should try to keep the device connected; Otherwise, false. Default is false.</returns>
    public extern bool MaintainConnection { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Begins an asynchronous operation to get the DeviceConnectionChangeTrigger associated with the specified Id.</summary>
    /// <param name="deviceId">The device Id with which to find the associated trigger.</param>
    /// <returns>The DeviceConnectionChangeTrigger object associated with the specified device Id.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<DeviceConnectionChangeTrigger> FromIdAsync(
      string deviceId);
  }
}
