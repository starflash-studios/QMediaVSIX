// Decompiled with JetBrains decompiler
// Type: Windows.Media.FaceAnalysis.IFaceTracker
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
  [Guid(1806073228, 43073, 17440, 147, 230, 36, 32, 161, 136, 79, 207)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFaceTracker
  {
    [RemoteAsync]
    IAsyncOperation<IVector<DetectedFace>> ProcessNextFrameAsync(
      VideoFrame videoFrame);

    BitmapSize MinDetectableFaceSize { get; set; }

    BitmapSize MaxDetectableFaceSize { get; set; }
  }
}
