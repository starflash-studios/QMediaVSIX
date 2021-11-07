// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ComboBoxTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides calculated values that can be referenced as **TemplatedParent** sources when defining templates for a ComboBox control. Not intended for general use.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class ComboBoxTemplateSettings : 
    DependencyObject,
    IComboBoxTemplateSettings,
    IComboBoxTemplateSettings2
  {
    /// <summary>Gets a value that reports the run-time layout slot height of the "Popup" part of a ComboBox in the "Opened" state.</summary>
    /// <returns>The run-time layout slot height, in pixels.</returns>
    public extern double DropDownOpenedHeight { [MethodImpl] get; }

    /// <summary>Gets a value that reports the run-time layout slot height of the "Popup" part of a ComboBox in the "Closed" state.</summary>
    /// <returns>The run-time layout slot height, in pixels.</returns>
    public extern double DropDownClosedHeight { [MethodImpl] get; }

    /// <summary>Gets a value that reports the run-time offset value that is useful for a **Split** animation of the "Popup" part of a ComboBox.</summary>
    /// <returns>The run-time offset value in pixels.</returns>
    public extern double DropDownOffset { [MethodImpl] get; }

    /// <summary>Gets a value that reports the selection direction in a ComboBox. This is either **Bottom** or **Top** depending on how DropDownOffset is set.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern AnimationDirection SelectedItemDirection { [MethodImpl] get; }

    /// <summary>Gets the minimum width value of the drop down content.</summary>
    /// <returns>The minimum width value of the drop down content.</returns>
    public extern double DropDownContentMinWidth { [MethodImpl] get; }
  }
}
