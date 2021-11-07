// Decompiled with JetBrains decompiler
// Type: Windows.Media.IVideoFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Graphics.Imaging;

namespace Windows.Media
{
  [ExclusiveTo(typeof (VideoFrame))]
  [Guid(213935653, 37116, 19602, 189, 149, 125, 237, 33, 129, 157, 28)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVideoFrame : IMediaFrame, IClosable
  {
    SoftwareBitmap SoftwareBitmap { get; }

    [RemoteAsync]
    IAsyncAction CopyToAsync(VideoFrame frame);

    IDirect3DSurface Direct3DSurface { get; }
  }
}
