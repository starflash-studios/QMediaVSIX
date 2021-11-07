// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.ISurfaceImageSourceFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [ExclusiveTo(typeof (SurfaceImageSource))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(984752426, 61285, 19039, 191, 172, 115, 153, 62, 140, 18, 201)]
  internal interface ISurfaceImageSourceFactory
  {
    SurfaceImageSource CreateInstanceWithDimensions(
      int pixelWidth,
      int pixelHeight,
      object baseInterface,
      out object innerInterface);

    SurfaceImageSource CreateInstanceWithDimensionsAndOpacity(
      int pixelWidth,
      int pixelHeight,
      bool isOpaque,
      object baseInterface,
      out object innerInterface);
  }
}
