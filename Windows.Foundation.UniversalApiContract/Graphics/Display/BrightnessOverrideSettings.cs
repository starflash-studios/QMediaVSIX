// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.BrightnessOverrideSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  /// <summary>Contains the settings to use when overriding the screen brightness with DisplayEnhancementOverride on a device.</summary>
  [Static(typeof (IBrightnessOverrideSettingsStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Threading(ThreadingModel.Both)]
  public sealed class BrightnessOverrideSettings : IBrightnessOverrideSettings
  {
    /// <summary>Gets the desired brightness level.</summary>
    /// <returns>The desired brightness level.</returns>
    public extern double DesiredLevel { [MethodImpl] get; }

    /// <summary>Gets the desired Nits level.</summary>
    /// <returns>If the BrightnessOverrideSettings object was created using CreateFromLevel, this value will map to the perceivable brightness in nits equal to the specified brightness level.</returns>
    public extern float DesiredNits { [MethodImpl] get; }

    /// <summary>Creates a BrightnessOverrideSettings object with the specified brightness level.</summary>
    /// <param name="level">The brightness level to use to create the override settings. The brightness level is a value ranging from [0.0, 1.0], where 0.0 corresponds to 0%</param>
    /// <returns>The override settings.</returns>
    [MethodImpl]
    public static extern BrightnessOverrideSettings CreateFromLevel(
      double level);

    /// <summary>Creates a BrightnessOverrideSettings object with the specified brightness in nits.</summary>
    /// <param name="nits">The brightness in nits to use to create the override settings.</param>
    /// <returns>The override settings.</returns>
    [MethodImpl]
    public static extern BrightnessOverrideSettings CreateFromNits(
      float nits);

    /// <summary>Creates a BrightnessOverrideSettings object with a brightness level corresponding to the specified brightness scenario.</summary>
    /// <param name="overrideScenario">The override scenario on which to base the settings.</param>
    /// <returns>The override settings.</returns>
    [MethodImpl]
    public static extern BrightnessOverrideSettings CreateFromDisplayBrightnessOverrideScenario(
      DisplayBrightnessOverrideScenario overrideScenario);
  }
}
