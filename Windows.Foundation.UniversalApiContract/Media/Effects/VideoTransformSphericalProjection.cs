// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.VideoTransformSphericalProjection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Media.MediaProperties;
using Windows.Media.Playback;

namespace Windows.Media.Effects
{
  /// <summary>Enables configuration of the spherical projection parameters used by the VideoTransformEffectDefinition.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class VideoTransformSphericalProjection : IVideoTransformSphericalProjection
  {
    /// <summary>Gets or sets a value specifying whether spherical projection is enabled for the VideoTransformEffectDefinition.</summary>
    /// <returns>True if spherical projection is enabled; otherwise, false.</returns>
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value from the SphericalVideoFrameFormat enumeration specifying the spherical projection format of the video.</summary>
    /// <returns>The spherical projection format of the video.</returns>
    public extern SphericalVideoFrameFormat FrameFormat { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies the projection mode used for spherical video.</summary>
    /// <returns>A value that specifies the projection mode used for spherical video.</returns>
    public extern SphericalVideoProjectionMode ProjectionMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the horizontal field of view, expressed in degrees, used for spherical video projection.</summary>
    /// <returns>The horizontal field of view, expressed in degrees.</returns>
    public extern double HorizontalFieldOfViewInDegrees { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a quaternion that specifies the current view orientation used to project spherical video.</summary>
    /// <returns>The current view orientation.</returns>
    public extern Quaternion ViewOrientation { [MethodImpl] get; [MethodImpl] set; }
  }
}
