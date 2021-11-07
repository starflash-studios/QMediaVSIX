// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Media3D.Matrix3D
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Media3D
{
  /// <summary>Represents a 4 × 4 matrix that is used for transformations in a 3-D space. Used as a value for Matrix3DProjection.ProjectionMatrix.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public struct Matrix3D
  {
    /// <summary>The value of the first row and first column of this Matrix3D.</summary>
    public double M11;
    /// <summary>The value of the first row and second column of this Matrix3D.</summary>
    public double M12;
    /// <summary>The value of the first row and third column of this Matrix3D.</summary>
    public double M13;
    /// <summary>The value of the first row and fourth column of this Matrix3D.</summary>
    public double M14;
    /// <summary>The value of the second row and first column of this Matrix3D.</summary>
    public double M21;
    /// <summary>The value of the second row and second column of this Matrix3D.</summary>
    public double M22;
    /// <summary>The value of the second row and third column of this Matrix3D.</summary>
    public double M23;
    /// <summary>The value of the second row and fourth column of this Matrix3D.</summary>
    public double M24;
    /// <summary>The value of the third row and first column of this Matrix3D.</summary>
    public double M31;
    /// <summary>The value of the third row and second column of this Matrix3D.</summary>
    public double M32;
    /// <summary>The value of the third row and third column of this Matrix3D.</summary>
    public double M33;
    /// <summary>The value of the third row and fourth column of this Matrix3D.</summary>
    public double M34;
    /// <summary>The value of the fourth row and first column of this Matrix3D.</summary>
    public double OffsetX;
    /// <summary>The value of the fourth row and second column of this Matrix3D.</summary>
    public double OffsetY;
    /// <summary>The value of the fourth row and third column of this Matrix3D.</summary>
    public double OffsetZ;
    /// <summary>The value of the fourth row and fourth column of this Matrix3D.</summary>
    public double M44;
  }
}
