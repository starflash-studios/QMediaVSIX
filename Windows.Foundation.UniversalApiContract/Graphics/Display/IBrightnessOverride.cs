// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IBrightnessOverride
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (BrightnessOverride))]
  [Guid(2529780250, 49475, 17298, 190, 221, 74, 126, 149, 116, 200, 253)]
  internal interface IBrightnessOverride
  {
    bool IsSupported { get; }

    bool IsOverrideActive { get; }

    double BrightnessLevel { get; }

    void SetBrightnessLevel(double brightnessLevel, DisplayBrightnessOverrideOptions options);

    void SetBrightnessScenario(
      DisplayBrightnessScenario scenario,
      DisplayBrightnessOverrideOptions options);

    double GetLevelForScenario(DisplayBrightnessScenario scenario);

    void StartOverride();

    void StopOverride();

    event TypedEventHandler<BrightnessOverride, object> IsSupportedChanged;

    event TypedEventHandler<BrightnessOverride, object> IsOverrideActiveChanged;

    event TypedEventHandler<BrightnessOverride, object> BrightnessLevelChanged;
  }
}
