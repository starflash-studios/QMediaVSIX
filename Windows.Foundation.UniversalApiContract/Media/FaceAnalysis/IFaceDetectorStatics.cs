// Decompiled with JetBrains decompiler
// Type: Windows.Media.FaceAnalysis.IFaceDetectorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media.FaceAnalysis
{
  [ExclusiveTo(typeof (FaceDetector))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3154390375, 36935, 13302, 136, 27, 103, 70, 193, 178, 24, 184)]
  internal interface IFaceDetectorStatics
  {
    [RemoteAsync]
    IAsyncOperation<FaceDetector> CreateAsync();

    IVectorView<BitmapPixelFormat> GetSupportedBitmapPixelFormats();

    bool IsBitmapPixelFormatSupported(BitmapPixelFormat bitmapPixelFormat);

    bool IsSupported { get; }
  }
}
