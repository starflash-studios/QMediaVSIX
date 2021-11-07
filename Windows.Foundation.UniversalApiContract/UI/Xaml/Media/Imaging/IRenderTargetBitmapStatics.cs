// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IRenderTargetBitmapStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RenderTargetBitmap))]
  [Guid(4037144558, 49457, 19776, 156, 71, 247, 215, 207, 43, 7, 127)]
  [WebHostHidden]
  internal interface IRenderTargetBitmapStatics
  {
    DependencyProperty PixelWidthProperty { get; }

    DependencyProperty PixelHeightProperty { get; }
  }
}
