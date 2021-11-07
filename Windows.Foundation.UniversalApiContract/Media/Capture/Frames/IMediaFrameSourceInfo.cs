// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMediaFrameSourceInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.Media.Capture.Frames
{
  [Guid(2277362125, 17921, 16527, 145, 207, 3, 131, 24, 205, 10, 243)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaFrameSourceInfo))]
  internal interface IMediaFrameSourceInfo
  {
    string Id { get; }

    MediaStreamType MediaStreamType { get; }

    MediaFrameSourceKind SourceKind { get; }

    MediaFrameSourceGroup SourceGroup { get; }

    DeviceInformation DeviceInformation { get; }

    IMapView<Guid, object> Properties { get; }

    SpatialCoordinateSystem CoordinateSystem { get; }
  }
}
