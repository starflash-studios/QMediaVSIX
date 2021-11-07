// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IFaceDetectionEffectFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.FaceAnalysis;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FaceDetectionEffectFrame))]
  [Guid(2326825363, 24008, 17531, 162, 71, 82, 112, 189, 128, 46, 206)]
  internal interface IFaceDetectionEffectFrame : IMediaFrame, IClosable
  {
    IVectorView<DetectedFace> DetectedFaces { get; }
  }
}
