// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.GeneralTransform
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Provides generalized transformation support for objects. GeneralTransform is a base class that's in the hierarchy of practical transform classes such as TranslateTransform.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IGeneralTransformFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public class GeneralTransform : DependencyObject, IGeneralTransform, IGeneralTransformOverrides
  {
    /// <summary>Provides base class initialization behavior for GeneralTransform -derived classes.</summary>
    [MethodImpl]
    protected extern GeneralTransform();

    /// <summary>Gets the inverse transformation of this GeneralTransform, if possible.</summary>
    /// <returns>An inverse of this instance, if possible; otherwise null.</returns>
    public extern GeneralTransform Inverse { [MethodImpl] get; }

    /// <summary>Uses this transformation object's logic to transform the specified point, and returns the result.</summary>
    /// <param name="point">The point to transform using the transformation logic.</param>
    /// <returns>The result of transforming *point*.</returns>
    [MethodImpl]
    public extern Point TransformPoint(Point point);

    /// <summary>Attempts to transform the specified point and returns a value that indicates whether the transformation was successful.</summary>
    /// <param name="inPoint">The point to transform.</param>
    /// <param name="outPoint">The result of transforming *inPoint*.</param>
    /// <returns>**true** if *inPoint* was transformed; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool TryTransform(Point inPoint, out Point outPoint);

    /// <summary>Transforms the specified bounding box and returns an axis-aligned bounding box that is exactly large enough to contain it.</summary>
    /// <param name="rect">The bounding box to transform.</param>
    /// <returns>The smallest axis-aligned bounding box possible that contains the transformed *rect*.</returns>
    [MethodImpl]
    public extern Rect TransformBounds(Rect rect);

    extern GeneralTransform IGeneralTransformOverrides.InverseCore { [MethodImpl] get; }

    [MethodImpl]
    extern bool IGeneralTransformOverrides.TryTransformCore(
      Point inPoint,
      out Point outPoint);

    [MethodImpl]
    extern Rect IGeneralTransformOverrides.TransformBoundsCore(
      Rect rect);
  }
}
