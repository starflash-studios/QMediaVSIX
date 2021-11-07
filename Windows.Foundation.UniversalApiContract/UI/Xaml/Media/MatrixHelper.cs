// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.MatrixHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Provides static helper methods for processing Matrix values. C# and Microsoft Visual Basic code should use members of Matrix instead.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Static(typeof (IMatrixHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MatrixHelper : IMatrixHelper
  {
    /// <summary>Gets a static constructed Matrix where the values established are representative of an **Identity** transform. C# and Microsoft Visual Basic code should use Identity instead.</summary>
    /// <returns>A static constructed Matrix where the values established are representative of an **Identity** transform.</returns>
    public static extern Matrix Identity { [MethodImpl] get; }

    /// <summary>Creates a new Matrix based on provided initial Matrix data values. C# and Microsoft Visual Basic code should use Matrix constructor instead.</summary>
    /// <param name="m11">The initial value of **M11** for the created Matrix.</param>
    /// <param name="m12">The initial value of **M12** for the created Matrix.</param>
    /// <param name="m21">The initial value of **M21** for the created Matrix.</param>
    /// <param name="m22">The initial value of **M22** for the created Matrix.</param>
    /// <param name="offsetX">The initial value of **OffsetX** for the created Matrix.</param>
    /// <param name="offsetY">The initial value of **OffsetY** for the created Matrix.</param>
    /// <returns>The created Matrix.</returns>
    [MethodImpl]
    public static extern Matrix FromElements(
      double m11,
      double m12,
      double m21,
      double m22,
      double offsetX,
      double offsetY);

    /// <summary>Returns whether the provided Matrix represents an **Identity** transform. C# and Microsoft Visual Basic code should use IsIdentity instead.</summary>
    /// <param name="target">The target Matrix to evaluate.</param>
    /// <returns>**true** if the Matrix represents an **Identity** transform; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool GetIsIdentity(Matrix target);

    /// <summary>Transforms a provided Matrix using a Point input, and returns a Point result. C# and Microsoft Visual Basic code should use Transform instead.</summary>
    /// <param name="target">The target Matrix to evaluate.</param>
    /// <param name="point">The Point input for the transform operation.</param>
    /// <returns>The Point result of the transform.</returns>
    [MethodImpl]
    public static extern Point Transform(Matrix target, Point point);
  }
}
