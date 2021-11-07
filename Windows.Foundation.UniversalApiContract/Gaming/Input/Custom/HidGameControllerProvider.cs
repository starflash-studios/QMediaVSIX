// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.HidGameControllerProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  /// <summary>Represents the underlying device for a HID (Human Interface Device) game controller.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  public sealed class HidGameControllerProvider : IHidGameControllerProvider, IGameControllerProvider
  {
    /// <summary>The usage ID of the top-level collection.</summary>
    /// <returns>The usage ID of the top-level collection.</returns>
    public extern ushort UsageId { [MethodImpl] get; }

    /// <summary>The usage page of the top-level collection.</summary>
    /// <returns>The usage page of the top-level collection.</returns>
    public extern ushort UsagePage { [MethodImpl] get; }

    /// <summary>Gets the specified HID (Human Interface Device) feature report from the controller.</summary>
    /// <param name="reportId">The ID of the report to get.</param>
    /// <param name="reportBuffer">The buffer in which the report data is returned.</param>
    [MethodImpl]
    public extern void GetFeatureReport(byte reportId, [Out] byte[] reportBuffer);

    /// <summary>Sends the specified HID (Human Interface Device) feature report to the device.</summary>
    /// <param name="reportId">The ID of the report to send.</param>
    /// <param name="reportBuffer">The buffer containing the report data to send.</param>
    [MethodImpl]
    public extern void SendFeatureReport(byte reportId, byte[] reportBuffer);

    /// <summary>Sends the specified HID (Human Interface Device) output report to the device.</summary>
    /// <param name="reportId">The ID of the report to send.</param>
    /// <param name="reportBuffer">The buffer containing the report data to send.</param>
    [MethodImpl]
    public extern void SendOutputReport(byte reportId, byte[] reportBuffer);

    /// <summary>The firmware version of the controller.</summary>
    /// <returns>The firmware version of the controller.</returns>
    public extern GameControllerVersionInfo FirmwareVersionInfo { [MethodImpl] get; }

    /// <summary>The hardware product ID of the controller.</summary>
    /// <returns>The hardware product ID of the controller.</returns>
    public extern ushort HardwareProductId { [MethodImpl] get; }

    /// <summary>The hardware vendor ID of the controller.</summary>
    /// <returns>The hardware vendor ID of the controller.</returns>
    public extern ushort HardwareVendorId { [MethodImpl] get; }

    /// <summary>Contains information on the hardware version of the controller.</summary>
    /// <returns>Contains information on the hardware version of the controller.</returns>
    public extern GameControllerVersionInfo HardwareVersionInfo { [MethodImpl] get; }

    /// <summary>Boolean value indicating whether the controller is connected.</summary>
    /// <returns>Boolean value indicating whether the controller is connected.</returns>
    public extern bool IsConnected { [MethodImpl] get; }
  }
}
