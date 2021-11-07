// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackSphericalVideoProjection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Media.MediaProperties;

namespace Windows.Media.Playback
{
  /// <summary>Manages the spherical video projection settings for a MediaPlaybackSession.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class MediaPlaybackSphericalVideoProjection : IMediaPlaybackSphericalVideoProjection
  {
    /// <summary>Gets or sets a value indicating whether spherical video projection is enabled.</summary>
    /// <returns>True if spherical video projection is enabled. Otherwise, false.</returns>
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies the frame format used for spherical video projection.</summary>
    /// <returns>A value that specifies the frame format used for spherical video projection.</returns>
    public extern SphericalVideoFrameFormat FrameFormat { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the horizontal field of view, expressed in degrees, used for spherical video projection.</summary>
    /// <returns>The horizontal field of view, expressed in degrees</returns>
    public extern double HorizontalFieldOfViewInDegrees { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a quaternion that specifies the current view orientation used to project spherical video.</summary>
    /// <returns>The current view orientation.</returns>
    public extern Quaternion ViewOrientation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies the projection mode used for spherical video.</summary>
    /// <returns>A value that specifies the projection mode used for spherical video.</returns>
    public extern SphericalVideoProjectionMode ProjectionMode { [MethodImpl] get; [MethodImpl] set; }
  }
}
