// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.PivotPanel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Displays the items in a Pivot control.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PivotPanel : Panel, IPivotPanel, IScrollSnapPointsInfo
  {
    /// <summary>Initializes a new instance of the PivotPanel class.</summary>
    [MethodImpl]
    public extern PivotPanel();

    /// <summary>This property is reserved for internal use and is not intended to be used in your code.</summary>
    /// <returns>Reserved.</returns>
    public extern bool AreHorizontalSnapPointsRegular { [MethodImpl] get; }

    /// <summary>This property is reserved for internal use and is not intended to be used in your code.</summary>
    /// <returns>Reserved.</returns>
    public extern bool AreVerticalSnapPointsRegular { [MethodImpl] get; }

    /// <summary>This property is reserved for internal use and is not intended to be used in your code.</summary>
    public extern event EventHandler<object> HorizontalSnapPointsChanged;

    /// <summary>This property is reserved for internal use and is not intended to be used in your code.</summary>
    public extern event EventHandler<object> VerticalSnapPointsChanged;

    /// <summary>This property is reserved for internal use and is not intended to be used in your code.</summary>
    /// <param name="orientation">Reserved.</param>
    /// <param name="alignment">Reserved.</param>
    /// <returns>Reserved.</returns>
    [MethodImpl]
    public extern IVectorView<float> GetIrregularSnapPoints(
      Orientation orientation,
      SnapPointsAlignment alignment);

    /// <summary>This property is reserved for internal use and is not intended to be used in your code.</summary>
    /// <param name="orientation">Reserved.</param>
    /// <param name="alignment">Reserved.</param>
    /// <param name="offset">Reserved.</param>
    /// <returns>Reserved.</returns>
    [MethodImpl]
    public extern float GetRegularSnapPoints(
      Orientation orientation,
      SnapPointsAlignment alignment,
      out float offset);
  }
}
