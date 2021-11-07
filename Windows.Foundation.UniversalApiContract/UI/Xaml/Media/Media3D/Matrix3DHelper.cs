// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Media3D.Matrix3DHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Media3D
{
  /// <summary>Provides static utilities for Matrix3D. C# and Microsoft Visual Basic code should use members of Matrix3D instead.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IMatrix3DHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class Matrix3DHelper : IMatrix3DHelper
  {
    /// <summary>Gets a static constructed Matrix3D where the values established are representative of an **Identity** transform. C# and Microsoft Visual Basic code should use Identity instead.</summary>
    /// <returns>A static constructed Matrix3D where the values established are representative of an **Identity** transform.</returns>
    public static extern Matrix3D Identity { [MethodImpl] get; }

    /// <summary>Multiplies the specified matrices. C# and Microsoft Visual Basic code should use the multiplication operator instead. </summary>
    /// <param name="matrix1">The first matrix to multiply.</param>
    /// <param name="matrix2">The second matrix to multiply.</param>
    /// <returns>A new Matrix3D that is the result of multiplication.</returns>
    [MethodImpl]
    public static extern Matrix3D Multiply(Matrix3D matrix1, Matrix3D matrix2);

    /// <summary>Defines a new Matrix3D value, using element values for each of the possible values of a Matrix3D structure. C# and Microsoft Visual Basic code should use Matrix3D constructor instead.</summary>
    /// <param name="m11">The value to set for **M11** of the Matrix3D.</param>
    /// <param name="m12">The value to set for **M12** of the Matrix3D..</param>
    /// <param name="m13">The value to set for **M13** of the Matrix3D.</param>
    /// <param name="m14">The value to set for **M14** of the Matrix3D.</param>
    /// <param name="m21">The value to set for **M21** of the Matrix3D.</param>
    /// <param name="m22">The value to set for **M22** of the Matrix3D.</param>
    /// <param name="m23">The value to set for **M23** of the Matrix3D.</param>
    /// <param name="m24">The value to set for **M24** of the Matrix3D.</param>
    /// <param name="m31">The value to set for **M31** of the Matrix3D.</param>
    /// <param name="m32">The value to set for **M32** of the Matrix3D.</param>
    /// <param name="m33">The value to set for **M33** of the Matrix3D.</param>
    /// <param name="m34">The value to set for **M34** of the Matrix3D.</param>
    /// <param name="offsetX">The value to set for **OffsetX** (row 4, column 1) of the Matrix3D.</param>
    /// <param name="offsetY">The value to set for **OffsetY** (row 4, column 2) of the Matrix3D.</param>
    /// <param name="offsetZ">The value to set for **OffsetZ** (row 4, column 3) of the Matrix3D.</param>
    /// <param name="m44">The value to set for **M44** of the Matrix3D.</param>
    /// <returns>The created Matrix3D.</returns>
    [MethodImpl]
    public static extern Matrix3D FromElements(
      double m11,
      double m12,
      double m13,
      double m14,
      double m21,
      double m22,
      double m23,
      double m24,
      double m31,
      double m32,
      double m33,
      double m34,
      double offsetX,
      double offsetY,
      double offsetZ,
      double m44);

    /// <summary>Returns whether the provided Matrix3D is invertible. C# and Microsoft Visual Basic code should use HasInverse instead.</summary>
    /// <param name="target">The target Matrix3D to evaluate.</param>
    /// <returns>**true** if the Matrix3D has an inverse; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool GetHasInverse(Matrix3D target);

    /// <summary>Returns whether the provided Matrix3D represents an **Identity** transform. C# and Microsoft Visual Basic code should use IsIdentity instead.</summary>
    /// <param name="target">The target Matrix3D to evaluate.</param>
    /// <returns>**true** if the Matrix3D represents an **Identity** transform; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool GetIsIdentity(Matrix3D target);

    /// <summary>Returns a potentially new Matrix3D value that represents the inversion of the provided Matrix3D. C# and Microsoft Visual Basic code should use Invert instead.</summary>
    /// <param name="target">The target Matrix3D to evaluate.</param>
    /// <returns>The inversion result Matrix3D.</returns>
    [MethodImpl]
    public static extern Matrix3D Invert(Matrix3D target);
  }
}
