// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionViewBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>Represents a container that maps shape visual tree coordinates onto the visual.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772165)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CompositionViewBox : CompositionObject, ICompositionViewBox
  {
    /// <summary>Gets or sets the horizontal alignment ratio of the view box.</summary>
    /// <returns>The horizontal alignment ratio of the view box.</returns>
    public extern float HorizontalAlignmentRatio { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the offset of the view box.</summary>
    /// <returns>The offset of the view box.</returns>
    public extern Vector2 Offset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the height and width of the view box.</summary>
    /// <returns>The height and width of the view box.</returns>
    public extern Vector2 Size { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies how content fits into the available space.</summary>
    /// <returns>An enumeration value that specifies how content fits into the available space. The default is **Uniform**.</returns>
    public extern CompositionStretch Stretch { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the vertical alignment ratio of the view box.</summary>
    /// <returns>The vertical alignment ratio of the view box.</returns>
    public extern float VerticalAlignmentRatio { [MethodImpl] get; [MethodImpl] set; }
  }
}
