// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IDepthMediaFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices.Core;
using Windows.Perception.Spatial;

namespace Windows.Media.Capture.Frames
{
  [ExclusiveTo(typeof (DepthMediaFrame))]
  [Guid(1192451663, 34121, 17856, 146, 91, 128, 211, 94, 253, 177, 10)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IDepthMediaFrame
  {
    MediaFrameReference FrameReference { get; }

    VideoMediaFrame VideoMediaFrame { get; }

    DepthMediaFrameFormat DepthFormat { get; }

    DepthCorrelatedCoordinateMapper TryCreateCoordinateMapper(
      CameraIntrinsics cameraIntrinsics,
      SpatialCoordinateSystem coordinateSystem);
  }
}
