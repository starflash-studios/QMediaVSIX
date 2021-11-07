// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ProgressRingTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides calculated values that can be referenced as **TemplatedParent** sources when defining templates for a ProgressRing control. Not intended for general use.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ProgressRingTemplateSettings : DependencyObject, IProgressRingTemplateSettings
  {
    /// <summary>Gets the template-defined diameter of the "Ellipse" element that is animated in a templated ProgressRing.</summary>
    /// <returns>The "Ellipse" width in pixels.</returns>
    public extern double EllipseDiameter { [MethodImpl] get; }

    /// <summary>Gets the template-defined offset position of the "Ellipse" element that is animated in a templated ProgressRing.</summary>
    /// <returns>The offset in pixels.</returns>
    public extern Thickness EllipseOffset { [MethodImpl] get; }

    /// <summary>Gets the maximum bounding size of the progress ring as rendered.</summary>
    /// <returns>The maximum bounding size of the progress ring as rendered, in pixels.</returns>
    public extern double MaxSideLength { [MethodImpl] get; }
  }
}
