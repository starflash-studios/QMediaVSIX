// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.CameraCaptureUIVideoCaptureSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Provides settings for capturing videos. The settings include format, maximum resolution, maximum duration, and whether or not to allow trimming.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CameraCaptureUIVideoCaptureSettings : ICameraCaptureUIVideoCaptureSettings
  {
    /// <summary>Determines the format for storing captured videos.</summary>
    /// <returns>A value indicating the format for storing captured videos.</returns>
    public extern CameraCaptureUIVideoFormat Format { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Determines the maximum resolution that the user can select.</summary>
    /// <returns>The maximum resolution that the user can select.</returns>
    public extern CameraCaptureUIMaxVideoResolution MaxResolution { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Determines the maximum duration of a video.</summary>
    /// <returns>The maximum duration of a video. If this property is set to zero, no maximum duration is enforced.</returns>
    public extern float MaxDurationInSeconds { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Determines whether or not the video trimming user interface will be enabled.</summary>
    /// <returns>True, if the user will be allowed to trim videos; otherwise, false.</returns>
    public extern bool AllowTrimming { [MethodImpl] get; [MethodImpl] set; }
  }
}
