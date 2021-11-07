// Decompiled with JetBrains decompiler
// Type: Windows.Media.FaceAnalysis.IFaceDetector
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media.FaceAnalysis
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(381055708, 65135, 12567, 141, 149, 195, 240, 77, 81, 99, 12)]
  [ExclusiveTo(typeof (FaceDetector))]
  internal interface IFaceDetector
  {
    [RemoteAsync]
    [Overload("DetectFacesAsync")]
    IAsyncOperation<IVector<DetectedFace>> DetectFacesAsync(
      SoftwareBitmap image);

    [Overload("DetectFacesWithSearchAreaAsync")]
    [RemoteAsync]
    IAsyncOperation<IVector<DetectedFace>> DetectFacesAsync(
      SoftwareBitmap image,
      BitmapBounds searchArea);

    BitmapSize MinDetectableFaceSize { get; set; }

    BitmapSize MaxDetectableFaceSize { get; set; }
  }
}
