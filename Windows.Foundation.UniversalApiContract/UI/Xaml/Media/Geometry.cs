// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Geometry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Provides a base class for objects that define geometric shapes. Geometry objects can be used for clipping regions and as geometry definitions for rendering two-dimensional graphical data as a Path.</summary>
  [Composable(typeof (IGeometryFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IGeometryStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class Geometry : DependencyObject, IGeometry
  {
    /// <summary>Gets or sets the Transform object applied to a Geometry.</summary>
    /// <returns>The transformation applied to the Geometry. Note that this value may be a single Transform or a list of Transform items.</returns>
    public extern Transform Transform { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a Rect that specifies the axis-aligned bounding box of the Geometry.</summary>
    /// <returns>The axis-aligned bounding box of the Geometry.</returns>
    public extern Rect Bounds { [MethodImpl] get; }

    /// <summary>Gets an empty geometry object.</summary>
    /// <returns>The empty geometry object.</returns>
    public static extern Geometry Empty { [MethodImpl] get; }

    /// <summary>Gets the standard tolerance used for polygonal approximation.</summary>
    /// <returns>The standard tolerance. The default value is 0.25.</returns>
    public static extern double StandardFlatteningTolerance { [MethodImpl] get; }

    /// <summary>Identifies the Transform dependency property.</summary>
    /// <returns>The identifier for the Transform dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty TransformProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }
  }
}
