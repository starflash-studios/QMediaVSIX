// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IBrightnessOverrideSettingsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [Guid(3565673616, 28532, 17419, 179, 131, 95, 233, 108, 240, 11, 15)]
  [ExclusiveTo(typeof (BrightnessOverrideSettings))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IBrightnessOverrideSettingsStatics
  {
    BrightnessOverrideSettings CreateFromLevel(double level);

    BrightnessOverrideSettings CreateFromNits(float nits);

    BrightnessOverrideSettings CreateFromDisplayBrightnessOverrideScenario(
      DisplayBrightnessOverrideScenario overrideScenario);
  }
}
