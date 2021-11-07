// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ILinearGradientBrushFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(182486556, 7802, 20461, 152, 87, 234, 140, 170, 121, 132, 144)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LinearGradientBrush))]
  [WebHostHidden]
  internal interface ILinearGradientBrushFactory
  {
    LinearGradientBrush CreateInstanceWithGradientStopCollectionAndAngle(
      GradientStopCollection gradientStopCollection,
      double angle);
  }
}
