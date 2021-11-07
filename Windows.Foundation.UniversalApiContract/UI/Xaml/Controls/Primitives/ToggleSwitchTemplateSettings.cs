// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ToggleSwitchTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides calculated values that can be referenced as **TemplatedParent** sources when defining templates for a ToggleSwitch control. Not intended for general use.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class ToggleSwitchTemplateSettings : DependencyObject, IToggleSwitchTemplateSettings
  {
    /// <summary>Gets the calculated value of the offset for the "knob" element of the ToggleSwitch, calculated for an "On" action and current switch position.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double KnobCurrentToOnOffset { [MethodImpl] get; }

    /// <summary>Gets the calculated value of the offset for the "knob" element of the ToggleSwitch, calculated for an "Off" action and current switch position.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double KnobCurrentToOffOffset { [MethodImpl] get; }

    /// <summary>Gets the calculated value of the offset for the "knob" element of the ToggleSwitch, in "On" to "Off" direction.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double KnobOnToOffOffset { [MethodImpl] get; }

    /// <summary>Gets the calculated value of the offset for the "knob" element of the ToggleSwitch, in "Off" to "On" direction.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double KnobOffToOnOffset { [MethodImpl] get; }

    /// <summary>Gets the calculated value of the offset for the "curtain" element of the ToggleSwitch, calculated for an "On" action and current switch position.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double CurtainCurrentToOnOffset { [MethodImpl] get; }

    /// <summary>Gets the calculated value of the offset for the "curtain" element of the ToggleSwitch, calculated for an "Off" action and current switch position.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double CurtainCurrentToOffOffset { [MethodImpl] get; }

    /// <summary>Gets the calculated value of the offset for the "curtain" element of the ToggleSwitch, in "On" to "Off" direction.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double CurtainOnToOffOffset { [MethodImpl] get; }

    /// <summary>Gets the calculated value of the offset for the "curtain" element of the ToggleSwitch, in "Off" to "On" direction.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double CurtainOffToOnOffset { [MethodImpl] get; }
  }
}
