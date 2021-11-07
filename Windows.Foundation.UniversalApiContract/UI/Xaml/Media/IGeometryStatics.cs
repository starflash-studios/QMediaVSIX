// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IGeometryStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Geometry))]
  [Guid(2054204044, 2822, 18015, 182, 55, 154, 71, 229, 167, 1, 17)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeometryStatics
  {
    Geometry Empty { get; }

    double StandardFlatteningTolerance { get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty TransformProperty { [ConditionallyIndependentlyAnimatable] get; }
  }
}
