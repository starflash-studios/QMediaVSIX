// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureVideoProfile2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Capture.Frames;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (MediaCaptureVideoProfile))]
  [Guid(2547894623, 38094, 18063, 147, 22, 252, 91, 194, 99, 143, 107)]
  internal interface IMediaCaptureVideoProfile2
  {
    IVectorView<MediaFrameSourceInfo> FrameSourceInfos { get; }

    IMapView<Guid, object> Properties { get; }
  }
}
