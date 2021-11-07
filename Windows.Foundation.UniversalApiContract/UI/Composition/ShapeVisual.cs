// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ShapeVisual
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Represents a visual tree node that is the root of a CompositionShape.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772165)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class ShapeVisual : ContainerVisual, IShapeVisual
  {
    /// <summary>Gets the collection of CompositionShapes that this shape visual tree is composed of.</summary>
    /// <returns>The collection of CompositionShapes that this shape visual tree is composed of.</returns>
    public extern CompositionShapeCollection Shapes { [MethodImpl] get; }

    /// <summary>Gets or sets the CompositionViewBox that maps shape visual tree coordinates onto the visual.</summary>
    /// <returns>The CompositionViewBox that maps shape visual tree coordinates onto the visual.</returns>
    public extern CompositionViewBox ViewBox { [MethodImpl] get; [MethodImpl] set; }
  }
}
