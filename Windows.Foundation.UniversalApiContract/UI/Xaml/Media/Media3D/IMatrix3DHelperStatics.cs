// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Media3D.IMatrix3DHelperStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Media3D
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2456048734, 57688, 20084, 136, 153, 104, 145, 96, 189, 47, 140)]
  [ExclusiveTo(typeof (Matrix3DHelper))]
  internal interface IMatrix3DHelperStatics
  {
    Matrix3D Identity { get; }

    Matrix3D Multiply(Matrix3D matrix1, Matrix3D matrix2);

    Matrix3D FromElements(
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

    bool GetHasInverse(Matrix3D target);

    bool GetIsIdentity(Matrix3D target);

    Matrix3D Invert(Matrix3D target);
  }
}
