// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.Preview.GazeDevicePreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.HumanInterfaceDevice;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input.Preview
{
  /// <summary>Supports the ability to identify and manage all connected eye-tracker devices.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GazeDevicePreview : IGazeDevicePreview
  {
    /// <summary>Gets a unique identifier for the eye-tracking device.</summary>
    /// <returns>The unique identifier.</returns>
    public extern uint Id { [MethodImpl] get; }

    /// <summary>Gets whether the eye-tracking device can detect and track the user's eyes.</summary>
    /// <returns>True, if the device can track the user's eyes; otherwise, false.</returns>
    public extern bool CanTrackEyes { [MethodImpl] get; }

    /// <summary>Gets whether the eye-tracking device can detect and track the user's head.</summary>
    /// <returns>True, if the device can track the user's head; otherwise, false.</returns>
    public extern bool CanTrackHead { [MethodImpl] get; }

    /// <summary>Gets the configuration state of the eye-tracking device.</summary>
    /// <returns>The congiguration state.</returns>
    public extern GazeDeviceConfigurationStatePreview ConfigurationState { [MethodImpl] get; }

    /// <summary>Asynchronously requests the eye-tracking device start its calibration process.</summary>
    /// <returns>True, if calibration completes successfully; otherwise, false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestCalibrationAsync();

    /// <summary>Retrieves the numeric control description for the eye-tracking device.</summary>
    /// <param name="usagePage">The usage page for the eye-tracking device.</param>
    /// <param name="usageId">The usage identifier for the eye-tracking device.</param>
    /// <returns>A vector of HidNumericControlDescription objects.</returns>
    [MethodImpl]
    public extern IVectorView<HidNumericControlDescription> GetNumericControlDescriptions(
      ushort usagePage,
      ushort usageId);

    /// <summary>Retrieves the boolean control descriptions for the eye-tracking device.</summary>
    /// <param name="usagePage">The usage page for the eye-tracking device.</param>
    /// <param name="usageId">The usage identifier for the eye-tracking device.</param>
    /// <returns>A vector of HidNumericControlDescription objects.</returns>
    [MethodImpl]
    public extern IVectorView<HidBooleanControlDescription> GetBooleanControlDescriptions(
      ushort usagePage,
      ushort usageId);
  }
}
