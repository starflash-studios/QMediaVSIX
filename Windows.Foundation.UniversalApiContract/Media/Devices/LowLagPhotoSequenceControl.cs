// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.LowLagPhotoSequenceControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Devices
{
  /// <summary>Provides functionality for managing the low shutter lag photo sequence mode on the capture device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.MTA)]
  public sealed class LowLagPhotoSequenceControl : ILowLagPhotoSequenceControl
  {
    /// <summary>Gets a value that specifies if the capture device supports low shutter lag photo sequence mode.</summary>
    /// <returns>**true** if photo sequence mode is supported; otherwise, **false**.</returns>
    public extern bool Supported { [MethodImpl] get; }

    /// <summary>Gets the maximum number of past photos that can be stored.</summary>
    /// <returns>The maximum number of past photos.</returns>
    public extern uint MaxPastPhotos { [MethodImpl] get; }

    /// <summary>Gets the maximum number of photos that can be taken per second.</summary>
    /// <returns>The maximum number of photos per second.</returns>
    public extern float MaxPhotosPerSecond { [MethodImpl] get; }

    /// <summary>Gets or sets a value that specifies the number of past photos to store.</summary>
    /// <returns>The number of past photos to store. To determine the maximum number of past photos that can be stored, check the MaxPastPhotos property.</returns>
    public extern uint PastPhotoLimit { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the number of photos that are taken per second.</summary>
    /// <returns>The number of photos taken per second.</returns>
    public extern float PhotosPerSecondLimit { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the highest frame rate supported when video and photos sequences are being captured concurrently.</summary>
    /// <param name="captureProperties">The media encoding properties.</param>
    /// <returns>The highest concurrent frames per second.</returns>
    [MethodImpl]
    public extern MediaRatio GetHighestConcurrentFrameRate(
      IMediaEncodingProperties captureProperties);

    /// <summary>Gets the current frame rate at which pictures can be taken.</summary>
    /// <returns>The current frame rate.</returns>
    [MethodImpl]
    public extern MediaRatio GetCurrentFrameRate();

    /// <summary>Gets a value that enables and disables thumbnail support in photo sequence mode.</summary>
    /// <returns>**true** if thumbnails are enabled; otherwise, **false**.</returns>
    public extern bool ThumbnailEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the media format for the thumbnails.</summary>
    /// <returns>The media format for the thumbnails.</returns>
    public extern MediaThumbnailFormat ThumbnailFormat { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the desired size for thumbnails, which is the largest length of the image, either width or height.</summary>
    /// <returns>The desired thumbnail size.</returns>
    public extern uint DesiredThumbnailSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that specifies if hardware acceleration is supported for thumbnails in photo sequence mode.</summary>
    /// <returns>**true** if hardware acceleration is supported for thumbnails in photo sequence mode; otherwise, **false**.</returns>
    public extern uint HardwareAcceleratedThumbnailSupported { [MethodImpl] get; }
  }
}
