// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.DisplayEnhancementOverride
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  /// <summary>Contains the base features that describe how to override setting displays.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IDisplayEnhancementOverrideStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  public sealed class DisplayEnhancementOverride : IDisplayEnhancementOverride
  {
    /// <summary>Gets and sets the color override settings.</summary>
    /// <returns>The color override settings. A null ColorOverrideSettings property means that the DisplayEnhancementOverride object does not want to override color settings. This property is null by default.</returns>
    public extern ColorOverrideSettings ColorOverrideSettings { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the brightness override settings.</summary>
    /// <returns>The brightness override settings. A null BrightnessOverrideSettings property means that the DisplayEnhancementOverride does not want to override brightness settings. This property is null by default.</returns>
    public extern BrightnessOverrideSettings BrightnessOverrideSettings { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that describes whether the current display settings can be overridden.</summary>
    /// <returns>**True** if the DisplayEnhancementOverride object can successfully override the system's brightness and/or color with its current configuration at the moment that CanOverrideis queried. This can be used to test if override control can be obtained without having to call RequestOverride.</returns>
    public extern bool CanOverride { [MethodImpl] get; }

    /// <summary>Gets a value that describes whether the display enhancement overrides are active.</summary>
    /// <returns>**True** if the display enhancement override object is currently overriding the system's brightness and/or color settings. Otherwise, **false**.</returns>
    public extern bool IsOverrideActive { [MethodImpl] get; }

    /// <summary>Retrieves the current display enhancement overide capabilities.</summary>
    /// <returns>The current display enhancement override capabilities.</returns>
    [MethodImpl]
    public extern DisplayEnhancementOverrideCapabilities GetCurrentDisplayEnhancementOverrideCapabilities();

    /// <summary>Requests that the current display be overridden with the current display override settings.</summary>
    [MethodImpl]
    public extern void RequestOverride();

    /// <summary>Notifies the system that this display enhancement object no longer wants to apply its settings.</summary>
    [MethodImpl]
    public extern void StopOverride();

    /// <summary>Raised when the ability to override the display settings have been changed.</summary>
    public extern event TypedEventHandler<DisplayEnhancementOverride, object> CanOverrideChanged;

    /// <summary>Raised when the IsOverrideActive property is changed.</summary>
    public extern event TypedEventHandler<DisplayEnhancementOverride, object> IsOverrideActiveChanged;

    /// <summary>Raised when the display enhancement override capabilities have been changed.</summary>
    public extern event TypedEventHandler<DisplayEnhancementOverride, DisplayEnhancementOverrideCapabilitiesChangedEventArgs> DisplayEnhancementOverrideCapabilitiesChanged;

    /// <summary>Retrieves a display enhancement override object for the current view.</summary>
    /// <returns>The display enhancement override object for the current view.</returns>
    [MethodImpl]
    public static extern DisplayEnhancementOverride GetForCurrentView();
  }
}
