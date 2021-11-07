// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Media3D.ICompositeTransform3D
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Media3D
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2306329345, 44941, 19189, 176, 132, 192, 142, 185, 112, 74, 190)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CompositeTransform3D))]
  internal interface ICompositeTransform3D
  {
    double CenterX { get; set; }

    double CenterY { get; set; }

    double CenterZ { get; set; }

    double RotationX { get; set; }

    double RotationY { get; set; }

    double RotationZ { get; set; }

    double ScaleX { get; set; }

    double ScaleY { get; set; }

    double ScaleZ { get; set; }

    double TranslateX { get; set; }

    double TranslateY { get; set; }

    double TranslateZ { get; set; }
  }
}
