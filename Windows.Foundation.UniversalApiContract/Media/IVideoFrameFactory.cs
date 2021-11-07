// Decompiled with JetBrains decompiler
// Type: Windows.Media.IVideoFrameFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media
{
  [Guid(21720425, 8744, 19602, 146, 255, 80, 195, 128, 211, 231, 118)]
  [ExclusiveTo(typeof (VideoFrame))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVideoFrameFactory
  {
    VideoFrame Create(BitmapPixelFormat format, int width, int height);

    VideoFrame CreateWithAlpha(
      BitmapPixelFormat format,
      int width,
      int height,
      BitmapAlphaMode alpha);
  }
}
