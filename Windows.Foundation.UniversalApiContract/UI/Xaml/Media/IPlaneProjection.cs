// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IPlaneProjection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Media3D;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3875023866, 26406, 18074, 178, 89, 165, 24, 131, 71, 202, 143)]
  [ExclusiveTo(typeof (PlaneProjection))]
  internal interface IPlaneProjection
  {
    double LocalOffsetX { get; set; }

    double LocalOffsetY { get; set; }

    double LocalOffsetZ { get; set; }

    double RotationX { get; set; }

    double RotationY { get; set; }

    double RotationZ { get; set; }

    double CenterOfRotationX { get; set; }

    double CenterOfRotationY { get; set; }

    double CenterOfRotationZ { get; set; }

    double GlobalOffsetX { get; set; }

    double GlobalOffsetY { get; set; }

    double GlobalOffsetZ { get; set; }

    Matrix3D ProjectionMatrix { get; }
  }
}
