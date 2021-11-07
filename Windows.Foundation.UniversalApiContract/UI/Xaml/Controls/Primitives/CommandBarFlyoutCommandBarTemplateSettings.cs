// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.CommandBarFlyoutCommandBarTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides calculated values that can be referenced as **TemplatedParent** sources when defining templates for a CommandBarFlyout control. Not intended for general use.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CommandBarFlyoutCommandBarTemplateSettings : 
    DependencyObject,
    ICommandBarFlyoutCommandBarTemplateSettings
  {
    /// <summary>Gets the start position for the open animation.</summary>
    /// <returns>The start position for the animation.</returns>
    public extern double OpenAnimationStartPosition { [MethodImpl] get; }

    /// <summary>Gets the end position for the open animation.</summary>
    /// <returns>The end position for the animation.</returns>
    public extern double OpenAnimationEndPosition { [MethodImpl] get; }

    /// <summary>Gets the end position for the close animation.</summary>
    /// <returns>The end position for the animation.</returns>
    public extern double CloseAnimationEndPosition { [MethodImpl] get; }

    /// <summary>Gets the current width of the control.</summary>
    /// <returns>The current width of the control.</returns>
    public extern double CurrentWidth { [MethodImpl] get; }

    /// <summary>Gets the width of the control when expanded.</summary>
    /// <returns>The width of the control when expanded.</returns>
    public extern double ExpandedWidth { [MethodImpl] get; }

    /// <summary>Gets the amount of change for the width expansion.</summary>
    /// <returns>The amount of change for the width expansion.</returns>
    public extern double WidthExpansionDelta { [MethodImpl] get; }

    /// <summary>Gets the start position for the width expansion animation.</summary>
    /// <returns>The start position for the animation.</returns>
    public extern double WidthExpansionAnimationStartPosition { [MethodImpl] get; }

    /// <summary>Gets the end position for the width expansion animation.</summary>
    /// <returns>The end position for the animation.</returns>
    public extern double WidthExpansionAnimationEndPosition { [MethodImpl] get; }

    /// <summary>Gets the start position for the "more" button width expansion animation.</summary>
    /// <returns>The start position for the animation.</returns>
    public extern double WidthExpansionMoreButtonAnimationStartPosition { [MethodImpl] get; }

    /// <summary>Gets the end position for the "more" button width expansion animation.</summary>
    /// <returns>The end position for the animation.</returns>
    public extern double WidthExpansionMoreButtonAnimationEndPosition { [MethodImpl] get; }

    /// <summary>Gets the vertical position of the overflow when expanded up.</summary>
    /// <returns>The vertical position of the overflow when expanded up.</returns>
    public extern double ExpandUpOverflowVerticalPosition { [MethodImpl] get; }

    /// <summary>Gets the vertical position of the overflow when expanded down.</summary>
    /// <returns>The vertical position of the overflow when expanded down.</returns>
    public extern double ExpandDownOverflowVerticalPosition { [MethodImpl] get; }

    /// <summary>Gets the start position for the expand up animation.</summary>
    /// <returns>The start position for the animation.</returns>
    public extern double ExpandUpAnimationStartPosition { [MethodImpl] get; }

    /// <summary>Gets the end position for the expand up animation.</summary>
    /// <returns>The end position for the animation.</returns>
    public extern double ExpandUpAnimationEndPosition { [MethodImpl] get; }

    /// <summary>Gets the hold position for the expand up animation.</summary>
    /// <returns>The hold position for the animation.</returns>
    public extern double ExpandUpAnimationHoldPosition { [MethodImpl] get; }

    /// <summary>Gets the start position for the expand down animation.</summary>
    /// <returns>The start position for the animation.</returns>
    public extern double ExpandDownAnimationStartPosition { [MethodImpl] get; }

    /// <summary>Gets the end position for the expand down animation.</summary>
    /// <returns>The end position for the animation.</returns>
    public extern double ExpandDownAnimationEndPosition { [MethodImpl] get; }

    /// <summary>Gets the hold position for the expand down animation.</summary>
    /// <returns>The hold position for the animation.</returns>
    public extern double ExpandDownAnimationHoldPosition { [MethodImpl] get; }

    /// <summary>Gets the rectangle used to clip the content.</summary>
    /// <returns>The rectangle used to clip the content.</returns>
    public extern Rect ContentClipRect { [MethodImpl] get; }

    /// <summary>Gets the rectangle used to clip the overflow content.</summary>
    /// <returns>The rectangle used to clip the overflow content.</returns>
    public extern Rect OverflowContentClipRect { [MethodImpl] get; }
  }
}
