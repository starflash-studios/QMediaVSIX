// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.LoopingSelectorPanel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>A panel for positioning and arranging child LoopingSelector elements.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class LoopingSelectorPanel : Canvas, ILoopingSelectorPanel, IScrollSnapPointsInfo
  {
    /// <summary>Gets a value that determines whether the horizontal snap points for the LoopingSelectorPanel are equidistant from each other.</summary>
    /// <returns>**True** if the horizontal snap points are equidistant from each other; otherwise, **false**.</returns>
    public extern bool AreHorizontalSnapPointsRegular { [MethodImpl] get; }

    /// <summary>Gets a value that determines whether the vertical snap points for the LoopingSelectorPanel are equidistant from each other.</summary>
    /// <returns>**True** if the vertical snap points are regular equidistant from each other; otherwise, **false**.</returns>
    public extern bool AreVerticalSnapPointsRegular { [MethodImpl] get; }

    /// <summary>Occurs when the horizontal snap points change.</summary>
    public extern event EventHandler<object> HorizontalSnapPointsChanged;

    /// <summary>Occurs when the vertical snap points change.</summary>
    public extern event EventHandler<object> VerticalSnapPointsChanged;

    /// <summary>Returns a read-only collection of numbers that represent the irregular snap points for the specified orientation.</summary>
    /// <param name="orientation">The orientation of the requested snap points.</param>
    /// <param name="alignment">The alignment used by the caller when applying the requested snap points.</param>
    /// <returns>A read-only collection of numbers that represent the irregular snap points for the specified orientation, or an empty collection when no irregular snap points are present.</returns>
    [MethodImpl]
    public extern IVectorView<float> GetIrregularSnapPoints(
      Orientation orientation,
      SnapPointsAlignment alignment);

    /// <summary>Returns a read-only collection of numbers that represent the regular snap points for the specified orientation.</summary>
    /// <param name="orientation">The orientation of the requested snap points.</param>
    /// <param name="alignment">The alignment used by the caller when applying the requested snap points.</param>
    /// <param name="offset">The offset of the first snap point.</param>
    /// <returns>A read-only collection of numbers that represent the regular snap points for the specified orientation, or an empty collection when no regular snap points are present.</returns>
    [MethodImpl]
    public extern float GetRegularSnapPoints(
      Orientation orientation,
      SnapPointsAlignment alignment,
      out float offset);
  }
}
