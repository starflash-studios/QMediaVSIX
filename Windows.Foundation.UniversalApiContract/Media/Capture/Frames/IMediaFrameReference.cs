// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMediaFrameReference
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.Media.Capture.Frames
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaFrameReference))]
  [Guid(4139288129, 61660, 16452, 141, 201, 150, 28, 237, 208, 91, 173)]
  internal interface IMediaFrameReference : IClosable
  {
    MediaFrameSourceKind SourceKind { get; }

    MediaFrameFormat Format { get; }

    IReference<global::Windows.Foundation.TimeSpan> SystemRelativeTime { get; }

    global::Windows.Foundation.TimeSpan Duration { get; }

    IMapView<Guid, object> Properties { get; }

    BufferMediaFrame BufferMediaFrame { get; }

    VideoMediaFrame VideoMediaFrame { get; }

    SpatialCoordinateSystem CoordinateSystem { get; }
  }
}
