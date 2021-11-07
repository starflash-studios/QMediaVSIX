// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.FocusControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Provides functionality for controlling the focus settings on a capture device.</summary>
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FocusControl : IFocusControl, IFocusControl2
  {
    /// <summary>Gets a value that specifies if the capture device supports the focus control.</summary>
    /// <returns>**true** if the capture device supports the FocusControl; otherwise, **false**.</returns>
    public extern bool Supported { [MethodImpl] get; }

    /// <summary>Gets the focus presets that the capture device supports.</summary>
    /// <returns>The supported focus presets.</returns>
    public extern IVectorView<FocusPreset> SupportedPresets { [MethodImpl] get; }

    /// <summary>Gets the focus preset.</summary>
    /// <returns>The focus preset.</returns>
    public extern FocusPreset Preset { [MethodImpl] get; }

    /// <summary>Asynchronously sets the focus Preset.</summary>
    /// <param name="preset">The focus preset to set the Preset property to.</param>
    /// <returns>The object that is used to control the asynchronous operation.</returns>
    [Overload("SetPresetAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetPresetAsync(FocusPreset preset);

    /// <summary>Asynchronously sets the focus Preset, specifying if the operation must complete before the device is focused.</summary>
    /// <param name="preset">The focus preset to set the Preset property to.</param>
    /// <param name="completeBeforeFocus">Specifies if the asynchronous operation must complete before the device is focused.</param>
    /// <returns>The object that is used to control the asynchronous operation.</returns>
    [Overload("SetPresetWithCompletionOptionAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetPresetAsync(
      FocusPreset preset,
      bool completeBeforeFocus);

    /// <summary>Gets the minimum focus length.</summary>
    /// <returns>The minimum focus length.</returns>
    public extern uint Min { [MethodImpl] get; }

    /// <summary>Gets the maximum focus length.</summary>
    /// <returns>The maximum focus.</returns>
    public extern uint Max { [MethodImpl] get; }

    /// <summary>Gets the smallest focus increment supported by the capture device.</summary>
    /// <returns>The smallest focus increment.</returns>
    public extern uint Step { [MethodImpl] get; }

    /// <summary>Gets the current value that the focus is set to.</summary>
    /// <returns>The value that the focus is set to. The minimum and maximum values for the focus are specified by Min and Max.</returns>
    public extern uint Value { [MethodImpl] get; }

    /// <summary>Asynchronously sets the focus Value.</summary>
    /// <param name="focus">The value to set the focus to. The minimum and maximum values are specified by Min and Max.</param>
    /// <returns>The object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetValueAsync(uint focus);

    /// <summary>Asynchronously focuses the device.</summary>
    /// <returns>The object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction FocusAsync();

    /// <summary>Gets a value that specifics if the capture device supports the FocusChanged event.</summary>
    /// <returns>**true** if the focus changed event is supported; otherwise, **false**.</returns>
    public extern bool FocusChangedSupported { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether WaitForFocus is supported by the capture device.</summary>
    /// <returns>A value indicating whether WaitForFocus is supported by the capture device.</returns>
    public extern bool WaitForFocusSupported { [MethodImpl] get; }

    /// <summary>Gets a list of values indicating the focus modes that are supported by the capture device.</summary>
    /// <returns>A list of values indicating the focus modes that are supported by the capture device.</returns>
    public extern IVectorView<FocusMode> SupportedFocusModes { [MethodImpl] get; }

    /// <summary>Gets a list of values indicating the manual focus distances that are supported by the capture device.</summary>
    /// <returns>A list of values indicating the manual focus distances that are supported by the capture device.</returns>
    public extern IVectorView<ManualFocusDistance> SupportedFocusDistances { [MethodImpl] get; }

    /// <summary>Gets a list of values indicating the auto focus ranges that are supported by the capture device.</summary>
    /// <returns>A list of values indicating the auto focus ranges that are supported by the capture device.</returns>
    public extern IVectorView<AutoFocusRange> SupportedFocusRanges { [MethodImpl] get; }

    /// <summary>Gets the capture device's current focus mode.</summary>
    /// <returns>The capture device's current focus mode.</returns>
    public extern FocusMode Mode { [MethodImpl] get; }

    /// <summary>Gets a MediaCaptureFocusState value indicating the current focus state of the capture device.</summary>
    /// <returns>A value indicating the current focus state of the capture device.</returns>
    public extern MediaCaptureFocusState FocusState { [MethodImpl] get; }

    /// <summary>Unlocks the capture device's focus if it has previously been locked with a call to LockAsync.</summary>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction UnlockAsync();

    /// <summary>Locks the capture device's focus.</summary>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction LockAsync();

    /// <summary>Configures the FocusControl object with values specified in the provided FocusSettings object.</summary>
    /// <param name="settings">The focus settings to use to configure the FocusControl object.</param>
    [MethodImpl]
    public extern void Configure(FocusSettings settings);
  }
}
