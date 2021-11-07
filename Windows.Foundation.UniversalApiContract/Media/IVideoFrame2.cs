// Decompiled with JetBrains decompiler
// Type: Windows.Media.IVideoFrame2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(943162381, 13164, 17254, 141, 70, 6, 7, 152, 115, 108, 93)]
  [ExclusiveTo(typeof (VideoFrame))]
  internal interface IVideoFrame2
  {
    [RemoteAsync]
    [Overload("CopyToWithBoundsAsync")]
    IAsyncAction CopyToAsync(
      VideoFrame frame,
      IReference<BitmapBounds> sourceBounds,
      IReference<BitmapBounds> destinationBounds);
  }
}
