// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.LineDisplay
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents a line display device.</summary>
  [Static(typeof (ILineDisplayStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ILineDisplayStatics2), 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  public sealed class LineDisplay : ILineDisplay, ILineDisplay2, IClosable
  {
    /// <summary>Gets the DeviceInformation.Id of the line display.</summary>
    /// <returns>The DeviceInformation.Id of the line display.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the capabilities of the specified line display.</summary>
    /// <returns>The capabilities of the line display.</returns>
    public extern LineDisplayCapabilities Capabilities { [MethodImpl] get; }

    /// <summary>Gets the physical device name.</summary>
    /// <returns>The physical device name given by the UnifiedPOS specification.</returns>
    public extern string PhysicalDeviceName { [MethodImpl] get; }

    /// <summary>Gets the physical device description.</summary>
    /// <returns>The physical device description given by the UnifiedPOS specification.</returns>
    public extern string PhysicalDeviceDescription { [MethodImpl] get; }

    /// <summary>Gets the device control description of the line display.</summary>
    /// <returns>The control description of the line display.</returns>
    public extern string DeviceControlDescription { [MethodImpl] get; }

    /// <summary>Gets the device control version number of the line display.</summary>
    /// <returns>The UnifiedPOS control version number of the line display, formatted as a string.</returns>
    public extern string DeviceControlVersion { [MethodImpl] get; }

    /// <summary>Gets the service version number of the line display.</summary>
    /// <returns>The UnifiedPOS service version number, formatted as a string.</returns>
    public extern string DeviceServiceVersion { [MethodImpl] get; }

    /// <summary>Attempts to gain exclusive access to the line display.</summary>
    /// <returns>When the method completes, it returns a ClaimedLineDisplay.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ClaimedLineDisplay> ClaimAsync();

    /// <summary>Gets the current power status of the device.</summary>
    /// <returns>The power status of the device.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<LineDisplayPowerStatus> CheckPowerStatusAsync();

    [MethodImpl]
    public extern void Close();

    /// <summary>Gets the standard UnifiedPOS statistics category selector strings.</summary>
    /// <returns>The standard UnifiedPOS statistics category selector strings.</returns>
    public static extern LineDisplayStatisticsCategorySelector StatisticsCategorySelector { [MethodImpl] get; }

    /// <summary>Creates a LineDisplay object from the DeviceInformation.Id.</summary>
    /// <param name="deviceId">The DeviceInformation.Id that identifies a specific line display, which can be retrieved from the DeviceId property.</param>
    /// <returns>The line display specified by the unique device identifier. Returns a null object in the following cases:</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<LineDisplay> FromIdAsync(
      string deviceId);

    /// <summary>Returns the first available line display.</summary>
    /// <returns>The first available line display. Returns a null object in the following cases:</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<LineDisplay> GetDefaultAsync();

    /// <summary>Gets an Advanced Query Syntax (AQS) string that you can use to list the available line displays.</summary>
    /// <returns>An Advanced Query Syntax string that is used to enumerate available line displays.</returns>
    [Overload("GetDeviceSelector")]
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Gets an Advanced Query Syntax (AQS) string that you can use to list the line displays available over the specified connection types</summary>
    /// <param name="connectionTypes">A list of the connection types to check for available line displays.</param>
    /// <returns>An AQS string that is used to enumerate the line displays available over the specified connection types</returns>
    [Overload("GetDeviceSelectorWithConnectionTypes")]
    [MethodImpl]
    public static extern string GetDeviceSelector(PosConnectionTypes connectionTypes);
  }
}
