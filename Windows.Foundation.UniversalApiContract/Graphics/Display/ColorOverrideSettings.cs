// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.ColorOverrideSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  /// <summary>Contains the settings to use when overriding the screen color settings with DisplayEnhancementOverride on a device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Static(typeof (IColorOverrideSettingsStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class ColorOverrideSettings : IColorOverrideSettings
  {
    /// <summary>Retrieves the desired color override scenario.</summary>
    /// <returns>The display color override scenario.</returns>
    public extern DisplayColorOverrideScenario DesiredDisplayColorOverrideScenario { [MethodImpl] get; }

    /// <summary>Creates a set of color override settings, based on the specified override scenario.</summary>
    /// <param name="overrideScenario">The override scenario to use.</param>
    /// <returns>The color override settings.</returns>
    [MethodImpl]
    public static extern ColorOverrideSettings CreateFromDisplayColorOverrideScenario(
      DisplayColorOverrideScenario overrideScenario);
  }
}
