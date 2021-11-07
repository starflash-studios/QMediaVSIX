// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IsoSpeedControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Provides functionality for controlling the ISO film speed settings on a capture device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.MTA)]
  [DualApiPartition(version = 100859904)]
  public sealed class IsoSpeedControl : IIsoSpeedControl, IIsoSpeedControl2
  {
    /// <summary>Gets a value the specifies if the capture device supports the ISO speed control.</summary>
    /// <returns>**true** if the ISO control is supported; otherwise, **false**.</returns>
    public extern bool Supported { [MethodImpl] get; }

    /// <summary>Gets the ISO presets that the capture device supports.</summary>
    /// <returns>The supported ISO presets.</returns>
    public extern IVectorView<IsoSpeedPreset> SupportedPresets { [Deprecated("SupportedPresets may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the ISO film speed preset.</summary>
    /// <returns>The ISO speed preset.</returns>
    public extern IsoSpeedPreset Preset { [Deprecated("Preset may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Asynchronously sets the ISO film speed Preset.</summary>
    /// <deprecated type="deprecate">SetPresetAsync may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead</deprecated>
    /// <param name="preset">The ISO preset value to set the Preset property to.</param>
    /// <returns>The object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [Deprecated("SetPresetAsync may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncAction SetPresetAsync(IsoSpeedPreset preset);

    /// <summary>Gets the minimum ISO speed supported by the capture device.</summary>
    /// <returns>The minimum ISO speed supported by the capture device.</returns>
    public extern uint Min { [MethodImpl] get; }

    /// <summary>Gets the maximum ISO speed supported by the capture device.</summary>
    /// <returns>The maximum ISO speed supported by the capture device.</returns>
    public extern uint Max { [MethodImpl] get; }

    /// <summary>Gets the smallest ISO speed increment supported by the capture device.</summary>
    /// <returns>The smallest ISO speed increment supported by the capture device.</returns>
    public extern uint Step { [MethodImpl] get; }

    /// <summary>Gets the current ISO speed value.</summary>
    /// <returns>The current ISO speed value.</returns>
    public extern uint Value { [MethodImpl] get; }

    /// <summary>Sets the ISO speed value.</summary>
    /// <param name="isoSpeed">The ISO speed value.</param>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetValueAsync(uint isoSpeed);

    /// <summary>Gets a value indicating whether auto ISO speed is enabled.</summary>
    /// <returns>A value indicating whether auto ISO speed is enabled.</returns>
    public extern bool Auto { [MethodImpl] get; }

    /// <summary>Sets the ISO speed to automatic.</summary>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetAutoAsync();
  }
}
