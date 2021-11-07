// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.VideoTransformEffectDefinition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;
using Windows.Media.Transcoding;
using Windows.UI;

namespace Windows.Media.Effects
{
  /// <summary>Represents the definition of a video transform effect.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VideoTransformEffectDefinition : 
    IVideoEffectDefinition,
    IVideoTransformEffectDefinition,
    IVideoTransformEffectDefinition2
  {
    /// <summary>Initializes a new instance of the VideoTransformEffectDefinition class.</summary>
    [MethodImpl]
    public extern VideoTransformEffectDefinition();

    /// <summary>Gets the activatable class ID of the video transform effect definition.</summary>
    /// <returns>The activatable class ID of the video transform effect definition.</returns>
    public extern string ActivatableClassId { [MethodImpl] get; }

    /// <summary>Gets the set of properties for configuring the VideoTransformEffectDefinition object.</summary>
    /// <returns>The set of properties for configuring the VideoTransformEffectDefinition object.</returns>
    public extern IPropertySet Properties { [MethodImpl] get; }

    /// <summary>Gets or sets the color that will be used to fill pixels in the frame that are not filled with video, such as when video is letterboxed.</summary>
    /// <returns>The color that will be used to fill pixels in the frame that are not filled with video</returns>
    public extern Color PaddingColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the output size of the video, in pixels.</summary>
    /// <returns>The output size of the video, in pixels.</returns>
    public extern Size OutputSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the rectangle within which the video will be cropped, specified in pixels.</summary>
    /// <returns>The rectangle within which the video will be cropped</returns>
    public extern Rect CropRectangle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the angle and direction in which the video will be rotated.</summary>
    /// <returns>The angle and direction in which the video will be rotated.</returns>
    public extern MediaRotation Rotation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the direction in which the video will be mirrored.</summary>
    /// <returns>The direction in which the video will be mirrored.</returns>
    public extern MediaMirroringOptions Mirror { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the media processing algorithm that is used for the video transform.</summary>
    /// <returns>The media processing algorithm that is used for the video transform.</returns>
    public extern MediaVideoProcessingAlgorithm ProcessingAlgorithm { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets a VideoTransformSphericalProjection object that allows you to configure the spherical projection parameters used by the video transform effect.</summary>
    /// <returns>A VideoTransformSphericalProjection object.</returns>
    public extern VideoTransformSphericalProjection SphericalProjection { [MethodImpl] get; }
  }
}
