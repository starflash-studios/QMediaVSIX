// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.MatrixTransform
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Creates an arbitrary affine matrix transformation that is used to manipulate objects or coordinate systems in a two-dimensional plane.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Static(typeof (IMatrixTransformStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MatrixTransform : Transform, IMatrixTransform
  {
    /// <summary>Initializes a new instance of the MatrixTransform class.</summary>
    [MethodImpl]
    public extern MatrixTransform();

    /// <summary>Gets or sets the Matrix that defines this transformation.</summary>
    /// <returns>The Matrix structure that defines this transformation. The default is an identity Matrix. An identity matrix has a value of 1 in coefficients [1,1], [2,2], and [3,3]; and a value of 0 in the rest of the coefficients.</returns>
    public extern Matrix Matrix { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Matrix dependency property.</summary>
    /// <returns>The identifier for the Matrix dependency property.</returns>
    public static extern DependencyProperty MatrixProperty { [MethodImpl] get; }
  }
}
