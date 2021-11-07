// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IVirtualSurfaceImageSourceFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(984752426, 49068, 4576, 138, 146, 105, 228, 71, 36, 1, 155)]
  [ExclusiveTo(typeof (VirtualSurfaceImageSource))]
  internal interface IVirtualSurfaceImageSourceFactory
  {
    VirtualSurfaceImageSource CreateInstanceWithDimensions(
      int pixelWidth,
      int pixelHeight);

    VirtualSurfaceImageSource CreateInstanceWithDimensionsAndOpacity(
      int pixelWidth,
      int pixelHeight,
      bool isOpaque);
  }
}
