// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.CameraCaptureUIPhotoCaptureSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Provides settings for capturing photos with CameraCaptureUI. The settings include aspect ratio, image size, format, resolution, and whether or not cropping is allowed by the user interface (UI).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CameraCaptureUIPhotoCaptureSettings : ICameraCaptureUIPhotoCaptureSettings
  {
    /// <summary>Determines the format that captured photos will be stored in.</summary>
    /// <returns>A value that indicates the format for captured photos.</returns>
    public extern CameraCaptureUIPhotoFormat Format { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Determines the maximum resolution the user will be able to select.</summary>
    /// <returns>A value that indicates the maximum resolution the user will be able to select.</returns>
    public extern CameraCaptureUIMaxPhotoResolution MaxResolution { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The exact size in pixels of the captured photo.</summary>
    /// <returns>The size of the captured photo.</returns>
    public extern Size CroppedSizeInPixels { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The aspect ratio of the captured photo.</summary>
    /// <returns>The aspect ratio of the captured photo. If zero, the aspect ratio is not enforced.</returns>
    public extern Size CroppedAspectRatio { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Determines whether photo cropping will be enabled in the user interface for capture a photo.</summary>
    /// <returns>True, if photo cropping will be enabled; otherwise, false.</returns>
    public extern bool AllowCropping { [MethodImpl] get; [MethodImpl] set; }
  }
}
