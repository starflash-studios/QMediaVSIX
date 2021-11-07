// Decompiled with JetBrains decompiler
// Type: Windows.Media.FaceAnalysis.IFaceTrackerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media.FaceAnalysis
{
  [ExclusiveTo(typeof (FaceTracker))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3915551128, 6145, 16293, 147, 46, 49, 215, 103, 175, 108, 77)]
  internal interface IFaceTrackerStatics
  {
    [RemoteAsync]
    IAsyncOperation<FaceTracker> CreateAsync();

    IVectorView<BitmapPixelFormat> GetSupportedBitmapPixelFormats();

    bool IsBitmapPixelFormatSupported(BitmapPixelFormat bitmapPixelFormat);

    bool IsSupported { get; }
  }
}
