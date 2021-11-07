// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.DeviceUseTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents an event that a Windows Runtime app can trigger to initiate a long-running operation with a device or sensor.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DeviceUseTrigger : IDeviceUseTrigger, IBackgroundTrigger
  {
    /// <summary>Constructor for DeviceUseTrigger. Takes no parameters.</summary>
    [MethodImpl]
    public extern DeviceUseTrigger();

    /// <summary>Triggers the background task and returns a DeviceTriggerResult indicating success or failure of the trigger request. Takes the *DeviceInformation.ID* of the device or sensor that the background task will access.</summary>
    /// <param name="deviceId">The *DeviceInformation.ID* of the device or sensor that the background task will access. It must match the device or sensor that will perform the background operation. It is used by Windows to ensure that policy requirements are met.</param>
    /// <returns>This method returns a DeviceTriggerResult when it completes asynchronously.</returns>
    [RemoteAsync]
    [Overload("RequestAsyncSimple")]
    [DefaultOverload]
    [MethodImpl]
    public extern IAsyncOperation<DeviceTriggerResult> RequestAsync(
      string deviceId);

    /// <summary>Triggers the background task and returns a DeviceTriggerResult indicating success or failure of the trigger request. Takes the *DeviceInformation.ID* of the device or sensor that the background task will access, and an optional app-specific string passed to the background task identifying which operation to perform.</summary>
    /// <param name="deviceId">The *DeviceInformation.ID* of the device or sensor that the background task will access. It must match the device or sensor that will perform the background operation. It is used by Windows to ensure that policy requirements are met.</param>
    /// <param name="arguments">Optional value. A string specified by your app and passed to the background task, identifying which operation to perform.</param>
    /// <returns>This method returns a DeviceTriggerResult when it completes asynchronously.</returns>
    [Overload("RequestAsyncWithArguments")]
    [DefaultOverload]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DeviceTriggerResult> RequestAsync(
      string deviceId,
      string arguments);
  }
}
