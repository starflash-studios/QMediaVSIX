// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.CameraCaptureUI
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.Capture
{
  /// <summary>Provides a full window UI for capturing audio, video, and photos from a camera. As well as controls for trimming video, time delayed capture, and camera settings.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.None)]
  [Threading(ThreadingModel.STA)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class CameraCaptureUI : ICameraCaptureUI
  {
    /// <summary>Create a new CameraCaptureUI object.</summary>
    [MethodImpl]
    public extern CameraCaptureUI();

    /// <summary>Provides settings for capturing photos. The settings include aspect ratio, image size, format, resolution, and whether or not cropping is allowed by the user interface (UI).</summary>
    /// <returns>An object containing settings for capturing photos.</returns>
    public extern CameraCaptureUIPhotoCaptureSettings PhotoSettings { [MethodImpl] get; }

    /// <summary>Provides settings for capturing videos. The settings include format, maximum resolution, maximum duration, and whether or not to allow trimming.</summary>
    /// <returns>An object that provides settings for capturing videos.</returns>
    public extern CameraCaptureUIVideoCaptureSettings VideoSettings { [MethodImpl] get; }

    /// <summary>Launches the CameraCaptureUI user interface.</summary>
    /// <param name="mode">Specifies whether the user interface that will be shown allows the user to capture a photo, capture a video, or capture both photos and videos.</param>
    /// <returns>When this operation completes, a StorageFile object is returned.</returns>
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> CaptureFileAsync(
      CameraCaptureUIMode mode);
  }
}
