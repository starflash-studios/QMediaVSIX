// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMediaFrameFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Capture.Frames
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1905273678, 45689, 19095, 169, 219, 189, 90, 47, 183, 143, 57)]
  [ExclusiveTo(typeof (MediaFrameFormat))]
  internal interface IMediaFrameFormat
  {
    string MajorType { get; }

    string Subtype { get; }

    MediaRatio FrameRate { get; }

    IMapView<Guid, object> Properties { get; }

    VideoMediaFrameFormat VideoFormat { get; }
  }
}
