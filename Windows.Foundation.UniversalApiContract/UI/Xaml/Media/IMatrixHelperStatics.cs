// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IMatrixHelperStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MatrixHelper))]
  [WebHostHidden]
  [Guid(3246786214, 14836, 19338, 132, 3, 40, 229, 229, 240, 51, 180)]
  internal interface IMatrixHelperStatics
  {
    Matrix Identity { get; }

    Matrix FromElements(
      double m11,
      double m12,
      double m21,
      double m22,
      double offsetX,
      double offsetY);

    bool GetIsIdentity(Matrix target);

    Point Transform(Matrix target, Point point);
  }
}
