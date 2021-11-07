// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.ISvgImageSourceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [WebHostHidden]
  [ExclusiveTo(typeof (SvgImageSource))]
  [Guid(2623944910, 48849, 19115, 172, 187, 211, 226, 24, 93, 49, 90)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISvgImageSourceStatics
  {
    DependencyProperty UriSourceProperty { get; }

    DependencyProperty RasterizePixelWidthProperty { get; }

    DependencyProperty RasterizePixelHeightProperty { get; }
  }
}
