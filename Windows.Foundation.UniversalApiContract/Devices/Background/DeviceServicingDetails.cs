// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Background.DeviceServicingDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Background
{
  /// <summary>Used to provide the DeviceInformation.ID, expected duration, and arguments given by the app that triggered the background servicing task.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class DeviceServicingDetails : IDeviceServicingDetails
  {
    /// <summary>Gets the DeviceInformation.ID of the device the task is targeting. The background task can provide this to the `FromIdAsync` method of the appropriate device access class to open the device. For example, call UsbDevice.FromIdAsync in the Windows.Devices.Usb namespace to open a USB device.</summary>
    /// <returns>The *deviceId* parameter value from the originating RequestAsync call.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the arguments string provided by the app when it called RequestAsync on the DeviceServicingTrigger. This allows the app to easily pass parameters to the task when it invokes it.</summary>
    /// <returns>The *arguments* parameter value from the originating RequestAsync call.</returns>
    public extern string Arguments { [MethodImpl] get; }

    /// <summary>Gets the estimated duration provided by the app when it called RequestAsync on the DeviceServicingTrigger.</summary>
    /// <returns>The *expectedDuration* parameter value from the originating RequestAsync call.</returns>
    public extern TimeSpan ExpectedDuration { [MethodImpl] get; }
  }
}
