// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ProgressBarTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides calculated values that can be referenced as **TemplatedParent** sources when defining templates for a ProgressBar control. Not intended for general use.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ProgressBarTemplateSettings : DependencyObject, IProgressBarTemplateSettings
  {
    /// <summary>Gets the template-defined diameter of the "Ellipse" element that is animated in a templated ProgressBar.</summary>
    /// <returns>The "Ellipse" element width in pixels.</returns>
    public extern double EllipseDiameter { [MethodImpl] get; }

    /// <summary>Gets the template-defined offset position of the "Ellipse" element that is animated in a templated ProgressBar.</summary>
    /// <returns>The offset in pixels.</returns>
    public extern double EllipseOffset { [MethodImpl] get; }

    /// <summary>Gets the stopped point of the "Ellipse" animation that animates the ProgressBar.</summary>
    /// <returns>The stopped point of the Ellipse animation that animates the ProgressBar. This is internally calculated as 1/3 of the ActualWidth of the control.</returns>
    public extern double EllipseAnimationWellPosition { [MethodImpl] get; }

    /// <summary>Gets the "To" point of the "Ellipse" animation that animates the ProgressBar.</summary>
    /// <returns>The "To" point of the "Ellipse" animation that animates the ProgressBar. This is internally calculated as 2/3 of the ActualWidth of the control.</returns>
    public extern double EllipseAnimationEndPosition { [MethodImpl] get; }

    /// <summary>Gets the "From" point of the container animation that animates the ProgressBar.</summary>
    /// <returns>A double that represents the orientation-specific x- or y-value that is the"From" point of the animation.</returns>
    public extern double ContainerAnimationStartPosition { [MethodImpl] get; }

    /// <summary>Gets the target "To" point of the container animation that animates the ProgressBar.</summary>
    /// <returns>A double that represents the orientation-specific x- or y-value that is the target "To" point of the animation.</returns>
    public extern double ContainerAnimationEndPosition { [MethodImpl] get; }

    /// <summary>Gets the indicator length delta, which is useful for repositioning transitions.</summary>
    /// <returns>The delta in pixels.</returns>
    public extern double IndicatorLengthDelta { [MethodImpl] get; }
  }
}
