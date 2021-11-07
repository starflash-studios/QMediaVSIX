// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.BrightnessOverride
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  /// <summary>Overrides the screen brightness level setting on a device. This API provides the ability to have per-application brightness control on devices that support controllable brightness. </summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IBrightnessOverrideStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class BrightnessOverride : IBrightnessOverride
  {
    /// <summary>Indicates whether the device currently has at least one brightness controllable display. If TRUE, the device has at least one brightness controllable display that supports brightness override.</summary>
    /// <returns>
    /// </returns>
    public extern bool IsSupported { [MethodImpl] get; }

    /// <summary>BOOLEAN value that indicates whether the brightness override is active. If TRUE, the current brightness level matches the override brightness level. This property value will always be FALSE if StartOverride() isn’t called.</summary>
    /// <returns>
    /// </returns>
    public extern bool IsOverrideActive { [MethodImpl] get; }

    /// <summary>Gets the screen brightness level for this BrightnessOverride instance. The brightness level can be changed by calling SetBrightnessLevel().</summary>
    /// <returns>
    /// </returns>
    public extern double BrightnessLevel { [MethodImpl] get; }

    /// <summary>Sets the brightness level and the override options. When your app is ready to change the current brightness with what you want to override it with, call StartOverride().</summary>
    /// <param name="brightnessLevel">Brightness of the screen. Value should be in the range of 0.0 and 1.0, where 1.0 is for 100% brightness.</param>
    /// <param name="options">Options that modify the brightness level of the screen during the brightness override session.</param>
    [MethodImpl]
    public extern void SetBrightnessLevel(
      double brightnessLevel,
      DisplayBrightnessOverrideOptions options);

    /// <summary>Sets the brightness level, by specifying a scenario that has a well-known brightness level, and the override options of the brightness override.</summary>
    /// <param name="scenario">A scenario that has a well-known brightness level.</param>
    /// <param name="options">Options that modify the brightness level of the screen during the brightness override session.</param>
    [MethodImpl]
    public extern void SetBrightnessScenario(
      DisplayBrightnessScenario scenario,
      DisplayBrightnessOverrideOptions options);

    /// <summary>Gets the brightness level associated with the specified scenario.</summary>
    /// <param name="scenario">The enum value of the scenario that you want to retrieve the brightness level for, as defined in DisplayBrightnessScenario.</param>
    /// <returns>A value to indicate the brightness level.</returns>
    [MethodImpl]
    public extern double GetLevelForScenario(DisplayBrightnessScenario scenario);

    /// <summary>Request to start overriding the screen brightness level. The request to start overriding does not mean that the screen brightness level always changes to match the specified override brightness level. It's still up to the system to decide whether or not to honor this override request. Use IsOverrideActive and IsOverrideActiveChanged properties to determine if the system has honored the override request.</summary>
    [MethodImpl]
    public extern void StartOverride();

    /// <summary>Stops overriding the brightness level.</summary>
    [MethodImpl]
    public extern void StopOverride();

    /// <summary>Occurs when a brightness controllable display is detected or removed. This event is raised when the IsSupported property changes.</summary>
    public extern event TypedEventHandler<BrightnessOverride, object> IsSupportedChanged;

    /// <summary>Occurs when the screen brightness level either starts to match or stops to match the override brightness level. This event is raised when the IsOverrideActive property changes state.</summary>
    public extern event TypedEventHandler<BrightnessOverride, object> IsOverrideActiveChanged;

    /// <summary>Occurs when the screen brightness level changes.</summary>
    public extern event TypedEventHandler<BrightnessOverride, object> BrightnessLevelChanged;

    /// <summary>Returns a brightness override object. This method does not require CoreWindow so it can be used by apps that are running in the background.</summary>
    /// <returns>The brightness override object.</returns>
    [MethodImpl]
    public static extern BrightnessOverride GetDefaultForSystem();

    /// <summary>Returns a brightness override object. This method requires CoreWindow so it can only be used by apps that are currently running in a window. The returned BrightnessOverride object may not be the same between multiple GetForCurrentView() calls on the same thread.</summary>
    /// <returns>The brightness override object.</returns>
    [MethodImpl]
    public static extern BrightnessOverride GetForCurrentView();

    /// <summary>Saves the specified brightness override settings by committing these values to user settings. Use this method to persist the override settings after overriding stops. If a NULL object is passed in, the system turns on auto-brightness.</summary>
    /// <param name="value">The brightness override object.</param>
    /// <returns>BOOLEAN value to indicate if the operation is successful or not.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> SaveForSystemAsync(
      BrightnessOverride value);
  }
}
