// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.LampArray
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Storage.Streams;
using Windows.System;
using Windows.UI;

namespace Windows.Devices.Lights
{
  /// <summary>Represents a LampArray device attached the system.  Currently, only HID LampArrays are supported.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Static(typeof (ILampArrayStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  public sealed class LampArray : ILampArray
  {
    /// <summary>Gets the plug and play (PnP) device identifier of the underlying LampArray device.</summary>
    /// <returns>The plug and play (PnP) device identifier of the underlying LampArray device.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>The hardware vendor Id of the underlying device.</summary>
    /// <returns>The hardware vendor Id.</returns>
    public extern ushort HardwareVendorId { [MethodImpl] get; }

    /// <summary>The hardware product Id of the underlying device.</summary>
    /// <returns>The hardware product Id.</returns>
    public extern ushort HardwareProductId { [MethodImpl] get; }

    /// <summary>The hardware version of the underlying device.</summary>
    /// <returns>The hardware version.</returns>
    public extern ushort HardwareVersion { [MethodImpl] get; }

    /// <summary>The LampArrayKind describing this device.</summary>
    /// <returns>The LampArrayKind for the device.</returns>
    public extern LampArrayKind LampArrayKind { [MethodImpl] get; }

    /// <summary>The number of lamps part of this LampArray.</summary>
    /// <returns>The number of lamps in the LampArray.</returns>
    public extern int LampCount { [MethodImpl] get; }

    /// <summary>Minimal interval (required by the device) between the system sending two updates for any one lamp.  This is comparable to the effective device refresh rate.</summary>
    /// <returns>The time interval between updates for a lamp.</returns>
    public extern TimeSpan MinUpdateInterval { [MethodImpl] get; }

    /// <summary>Gets the logical bounding box encompassing the LampArray.</summary>
    /// <returns>The value of the bounding box.</returns>
    public extern Vector3 BoundingBox { [MethodImpl] get; }

    /// <summary>Gets or sets the enabled state.</summary>
    /// <returns>True if the device is enabled; otherwise false.</returns>
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the overall brightness of the LampArray, where 0.0 is completely off and 1.0 is maximum brightness.</summary>
    /// <returns>The current brightness level of the LampArray. Default is 1.0.</returns>
    public extern double BrightnessLevel { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value indicating whether the LampArray device is connected to the system.</summary>
    /// <returns>True if the LampArray is connected; otherwise, false.</returns>
    public extern bool IsConnected { [MethodImpl] get; }

    /// <summary>Boolean indicating whether any lamp is mapped to a virtual key.</summary>
    /// <returns>Returns true if any lamp on the LampArray is mapped to a virtual key.</returns>
    public extern bool SupportsVirtualKeys { [MethodImpl] get; }

    /// <summary>Fetches the LampInfo corresponding to the lamp index.</summary>
    /// <param name="lampIndex">The index. Must be between 0 and LampCount - 1.</param>
    /// <returns>The LampInfo corresponding to lampIndex.</returns>
    [MethodImpl]
    public extern LampInfo GetLampInfo(int lampIndex);

    /// <summary>Searches for all lamp indices that are bound to the specific VirtualKey</summary>
    /// <param name="key">The VirtualKey.</param>
    /// <returns>Array of all lamp indices that are bound to the specific VirtualKey.  Array is empty if no lamp indices are found bound to the VirtualKey.</returns>
    [MethodImpl]
    public extern int[] GetIndicesForKey(VirtualKey key);

    /// <summary>Searches for all lamp indices that are bound to the specified LampPurposes.</summary>
    /// <param name="purposes">The LampPurposes.</param>
    /// <returns>Array of all lamp indices that are bound to the specific LampPurposes.  Array is empty if no lamp indices are found bound to the LampPurposes.</returns>
    [MethodImpl]
    public extern int[] GetIndicesForPurposes(LampPurposes purposes);

    /// <summary>Sets every lamp belonging to the LampArray to the desired color.</summary>
    /// <param name="desiredColor">Desired color to set every lamp to.</param>
    [MethodImpl]
    public extern void SetColor(Color desiredColor);

    /// <summary>Sets the lamp corresponding to the index to the desired color.</summary>
    /// <param name="lampIndex">The lamp index.</param>
    /// <param name="desiredColor">The desired color.</param>
    [MethodImpl]
    public extern void SetColorForIndex(int lampIndex, Color desiredColor);

    /// <summary>Sets all lamps specified to the same color.</summary>
    /// <param name="desiredColor">The desired color.</param>
    /// <param name="lampIndexes">Array of lamp indexes to set.</param>
    [MethodImpl]
    public extern void SetSingleColorForIndices(Color desiredColor, int[] lampIndexes);

    /// <summary>Sets the color for multiple lamps. Position within each array maps lamp index to desired color.</summary>
    /// <param name="desiredColors">Array of desired colors.</param>
    /// <param name="lampIndexes">Array of corresponding lamp indexes to modify.</param>
    [MethodImpl]
    public extern void SetColorsForIndices(Color[] desiredColors, int[] lampIndexes);

    /// <summary>Sets the color for all lamps that map to the key. Multiple lamps can map to the same key.</summary>
    /// <param name="desiredColor">The desired color.</param>
    /// <param name="key">The VirtualKey.</param>
    [MethodImpl]
    public extern void SetColorsForKey(Color desiredColor, VirtualKey key);

    /// <summary>Sets the color of multiple lamps, corresponding to mapped keys.  Position within each array maps keys to desired color.</summary>
    /// <param name="desiredColors">Array of desired colors.</param>
    /// <param name="keys">Array of corresponding VirtualKeys to modify.</param>
    [MethodImpl]
    public extern void SetColorsForKeys(Color[] desiredColors, VirtualKey[] keys);

    /// <summary>Sets the color of multiple lamps, corresponding to LampPurposes.</summary>
    /// <param name="desiredColor">Array of desired colors.</param>
    /// <param name="purposes">Array of corresponding LampPurposes to modify.</param>
    [MethodImpl]
    public extern void SetColorsForPurposes(Color desiredColor, LampPurposes purposes);

    /// <summary>Asynchronously sends a message identified by the message identifer argument.</summary>
    /// <param name="messageId">The identifer of a message.</param>
    /// <param name="message">An IBuffer representing the message.</param>
    /// <returns>An asynchronous object, which can be awaited.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SendMessageAsync(int messageId, IBuffer message);

    /// <summary>Asynchronously retrieves an IBuffer representing the message identified by the message identifer argument.</summary>
    /// <param name="messageId">The identifer of a message.</param>
    /// <returns>An asynchronous object which, on completion, contains the requested message.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> RequestMessageAsync(int messageId);

    /// <summary>Retrieves an Advanced Query Syntax (AQS) string encompassing all LampArray devices on the system.</summary>
    /// <returns>An AQS string encompassing all LampArray devices on the system.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Retrieves a LampArray object asynchronously for the LampArray device that has the specified plug and play (PnP) device identifier/device instance path.</summary>
    /// <param name="deviceId">The device identifier/device instance path of the device. To obtain the value, get the DeviceInformation.Id property value retrieved from DeviceWatcher</param>
    /// <returns>Returns an `IAsyncOperation(LampArray)` object that returns the results of the operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<LampArray> FromIdAsync(
      string deviceId);
  }
}
