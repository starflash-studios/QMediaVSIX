// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.CommandBarTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides calculated values that can be referenced as **TemplatedParent** sources when defining templates for a CommandBar control. Not intended for general use.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CommandBarTemplateSettings : 
    DependencyObject,
    ICommandBarTemplateSettings,
    ICommandBarTemplateSettings2,
    ICommandBarTemplateSettings3,
    ICommandBarTemplateSettings4
  {
    /// <summary>Gets the height of the CommandBar content.</summary>
    /// <returns>The height of the CommandBar content.</returns>
    public extern double ContentHeight { [MethodImpl] get; }

    /// <summary>Gets the Rect that describes the clipped area of the overflow content.</summary>
    /// <returns>A Rect that describes the clipped area of the overflow content.</returns>
    public extern Rect OverflowContentClipRect { [MethodImpl] get; }

    /// <summary>Gets the minimum width value of the overflow content.</summary>
    /// <returns>The minimum width value of the overflow content.</returns>
    public extern double OverflowContentMinWidth { [MethodImpl] get; }

    /// <summary>Gets the maximum height value of the overflow content.</summary>
    /// <returns>The maximum height value of the overflow content.</returns>
    public extern double OverflowContentMaxHeight { [MethodImpl] get; }

    /// <summary>Gets the horizontal offset value of the overflow content.</summary>
    /// <returns>The horizontal offset value of the overflow content.</returns>
    public extern double OverflowContentHorizontalOffset { [MethodImpl] get; }

    /// <summary>Gets the height of the overflow content.</summary>
    /// <returns>The height of the overflow content.</returns>
    public extern double OverflowContentHeight { [MethodImpl] get; }

    /// <summary>Gets the height of the overflow content when the overflow direction is negative.</summary>
    /// <returns>The height of the overflow content when the overflow direction is negative.</returns>
    public extern double NegativeOverflowContentHeight { [MethodImpl] get; }

    /// <summary>Gets the maximum width value of the overflow content.</summary>
    /// <returns>The maximum width value of the overflow content.</returns>
    public extern double OverflowContentMaxWidth { [MethodImpl] get; }

    /// <summary>Gets the effective visibility of the command bar's overflow button.</summary>
    /// <returns>The effective visibility of the command bar's overflow button.</returns>
    public extern Visibility EffectiveOverflowButtonVisibility { [MethodImpl] get; }

    /// <summary>Gets the translation of the overflow content on the Y-axis in the compact state.</summary>
    /// <returns>The translation of the overflow content on the Y-axis in the compact state.</returns>
    public extern double OverflowContentCompactYTranslation { [MethodImpl] get; }

    /// <summary>Gets the translation of the overflow content on the Y-axis in the minimal state.</summary>
    /// <returns>The translation of the overflow content on the Y-axis in the minimal state.</returns>
    public extern double OverflowContentMinimalYTranslation { [MethodImpl] get; }

    /// <summary>Gets the translation of the overflow content on the Y-axis in the hidden state.</summary>
    /// <returns>The translation of the overflow content on the Y-axis in the hidden state.</returns>
    public extern double OverflowContentHiddenYTranslation { [MethodImpl] get; }
  }
}
