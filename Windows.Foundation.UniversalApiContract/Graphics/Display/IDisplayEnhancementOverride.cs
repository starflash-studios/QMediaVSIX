// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IDisplayEnhancementOverride
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (DisplayEnhancementOverride))]
  [Guid(1117099215, 55674, 19202, 164, 40, 92, 66, 146, 247, 245, 34)]
  internal interface IDisplayEnhancementOverride
  {
    ColorOverrideSettings ColorOverrideSettings { get; set; }

    BrightnessOverrideSettings BrightnessOverrideSettings { get; set; }

    bool CanOverride { get; }

    bool IsOverrideActive { get; }

    DisplayEnhancementOverrideCapabilities GetCurrentDisplayEnhancementOverrideCapabilities();

    void RequestOverride();

    void StopOverride();

    event TypedEventHandler<DisplayEnhancementOverride, object> CanOverrideChanged;

    event TypedEventHandler<DisplayEnhancementOverride, object> IsOverrideActiveChanged;

    event TypedEventHandler<DisplayEnhancementOverride, DisplayEnhancementOverrideCapabilitiesChangedEventArgs> DisplayEnhancementOverrideCapabilitiesChanged;
  }
}
