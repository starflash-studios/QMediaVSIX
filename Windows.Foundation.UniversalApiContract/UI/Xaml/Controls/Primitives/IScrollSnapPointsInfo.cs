// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IScrollSnapPointsInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Describes snap point behavior for objects that contain and present items.</summary>
  [WebHostHidden]
  [Guid(459084598, 58907, 19793, 190, 65, 253, 141, 220, 85, 197, 140)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IScrollSnapPointsInfo
  {
    /// <summary>Gets a value that indicates whether the horizontal snap points for the container are equidistant from each other.</summary>
    /// <returns>**true** if the horizontal snap points for the container are equidistant from each other; otherwise, **false**.</returns>
    bool AreHorizontalSnapPointsRegular { get; }

    /// <summary>Gets a value that indicates whether the vertical snap points for the container are equidistant from each other.</summary>
    /// <returns>**true** if the vertical snap points for the container are equidistant from each other; otherwise, **false**.</returns>
    bool AreVerticalSnapPointsRegular { get; }

    /// <summary>Occurs when the measurements for horizontal snap points change.</summary>
    event EventHandler<object> HorizontalSnapPointsChanged;

    /// <summary>Occurs when the measurements for vertical snap points change.</summary>
    event EventHandler<object> VerticalSnapPointsChanged;

    /// <summary>Returns the set of distances between irregular snap points for a specified orientation and alignment.</summary>
    /// <param name="orientation">The orientation/dimension for the desired snap point set.</param>
    /// <param name="alignment">The alignment to use when applying the snap points.</param>
    /// <returns>The read-only collection of snap point distances. Returns an empty collection when no snap points are present.</returns>
    IVectorView<float> GetIrregularSnapPoints(
      Orientation orientation,
      SnapPointsAlignment alignment);

    /// <summary>Gets the distance between regular snap points for a specified orientation and alignment.</summary>
    /// <param name="orientation">The orientation/dimension for the desired snap point set.</param>
    /// <param name="alignment">The alignment to use when applying the snap points.</param>
    /// <param name="offset">Out parameter. The offset of the first snap point.</param>
    /// <returns>The distance between the equidistant snap points. Returns 0 when no snap points are present.</returns>
    float GetRegularSnapPoints(
      Orientation orientation,
      SnapPointsAlignment alignment,
      out float offset);
  }
}
