// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.VariablePhotoSequenceController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Devices.Core
{
  /// <summary>Represents the settings for a variable photo sequence.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.MTA)]
  public sealed class VariablePhotoSequenceController : IVariablePhotoSequenceController
  {
    /// <summary>Gets a value that indicates whether variable photo sequences are supported by the capture device.</summary>
    /// <returns>A value that indicates whether variable photo sequences are supported by the capture device.</returns>
    public extern bool Supported { [MethodImpl] get; }

    /// <summary>Gets the maximum number of photos that can be taken per second in a variable photo sequence.</summary>
    /// <returns>The maximum number of photos that can be taken per second in a variable photo sequence.</returns>
    public extern float MaxPhotosPerSecond { [MethodImpl] get; }

    /// <summary>Gets or sets the number of photos that are taken per second in a variable photo sequence.</summary>
    /// <returns>The number of photos that are taken per second in a variable photo sequence.</returns>
    public extern float PhotosPerSecondLimit { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the highest frame rate supported when video and a variable photo sequence are being captured concurrently.</summary>
    /// <param name="captureProperties">The media encoding properties.</param>
    /// <returns>The highest supported concurrent frame rate.</returns>
    [MethodImpl]
    public extern MediaRatio GetHighestConcurrentFrameRate(
      IMediaEncodingProperties captureProperties);

    /// <summary>Gets the current frame rate at which pictures can be taken in a variable photo sequence.</summary>
    /// <returns>The current frame rate at which pictures can be taken in a variable photo sequence.</returns>
    [MethodImpl]
    public extern MediaRatio GetCurrentFrameRate();

    /// <summary>Gets a FrameControlCapabilities object that provides information about the variable photo sequence capabilities of the capture device.</summary>
    /// <returns>A FrameControlCapabilities object that provides information about the variable photo sequence capabilities of the capture device.</returns>
    public extern FrameControlCapabilities FrameCapabilities { [MethodImpl] get; }

    /// <summary>Gets the list of FrameController objects that determine the settings for each frame in a variable photo sequence.</summary>
    /// <returns>The list of FrameController objects that determine the settings for each frame in a variable photo sequence.</returns>
    public extern IVector<FrameController> DesiredFrameControllers { [MethodImpl] get; }
  }
}
