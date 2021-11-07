// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IPointerPointTransform
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Provides generalized transformation functions.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1298129231, 47228, 16424, 188, 156, 89, 233, 148, 127, 176, 86)]
  public interface IPointerPointTransform
  {
    /// <summary>Gets the inverse of the specified transformation.</summary>
    /// <returns>The inverse of the pointer transformation.</returns>
    IPointerPointTransform Inverse { get; }

    /// <summary>Attempts to perform the transformation on the specified input point.</summary>
    /// <param name="inPoint">The original input point.</param>
    /// <param name="outPoint">The transformed input point.</param>
    /// <returns>True if *inPoint* was transformed successfully; otherwise, false.</returns>
    bool TryTransform(Point inPoint, out Point outPoint);

    /// <summary>Transforms the specified bounding rectangle.</summary>
    /// <param name="rect">The bounding rectangle to transform.</param>
    /// <returns>The smallest, axis-aligned bounding box that encloses *rect* after the transformation. (An axis-aligned bounding box is one which has all sides parallel to the coordinate axes.)</returns>
    Rect TransformBounds(Rect rect);
  }
}
