// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IVideoTransformSphericalProjection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Media.MediaProperties;
using Windows.Media.Playback;

namespace Windows.Media.Effects
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (VideoTransformSphericalProjection))]
  [Guid(3477340656, 39922, 19513, 159, 65, 224, 34, 81, 74, 132, 104)]
  internal interface IVideoTransformSphericalProjection
  {
    bool IsEnabled { get; set; }

    SphericalVideoFrameFormat FrameFormat { get; set; }

    SphericalVideoProjectionMode ProjectionMode { get; set; }

    double HorizontalFieldOfViewInDegrees { get; set; }

    Quaternion ViewOrientation { get; set; }
  }
}
