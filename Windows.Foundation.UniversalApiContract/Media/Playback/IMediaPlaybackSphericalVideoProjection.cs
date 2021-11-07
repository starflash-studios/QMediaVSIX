// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackSphericalVideoProjection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Media.MediaProperties;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlaybackSphericalVideoProjection))]
  [Guid(3557143420, 28430, 18017, 184, 238, 212, 135, 186, 151, 82, 213)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IMediaPlaybackSphericalVideoProjection
  {
    bool IsEnabled { get; set; }

    SphericalVideoFrameFormat FrameFormat { get; set; }

    double HorizontalFieldOfViewInDegrees { get; set; }

    Quaternion ViewOrientation { get; set; }

    SphericalVideoProjectionMode ProjectionMode { get; set; }
  }
}
