// Decompiled with JetBrains decompiler
// Type: Windows.Media.FaceAnalysis.FaceTracker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media.FaceAnalysis
{
  /// <summary>Detects faces in VideoFrame objects and tracks faces across subsequent video frames.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IFaceTrackerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class FaceTracker : IFaceTracker
  {
    /// <summary>Asynchronously processes a VideoFrame for face detection.</summary>
    /// <param name="videoFrame">The VideoFrame in which faces are detected or tracked.</param>
    /// <returns>An asynchronous operation that returns a list of DetectedFace objects upon successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVector<DetectedFace>> ProcessNextFrameAsync(
      VideoFrame videoFrame);

    /// <summary>Gets or sets the minimum detectable face size, in pixels.</summary>
    /// <returns>The minimum detectable face size, in pixels.</returns>
    public extern BitmapSize MinDetectableFaceSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum detectable face size, in pixels.</summary>
    /// <returns>The maximum detectable face size, in pixels.</returns>
    public extern BitmapSize MaxDetectableFaceSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Creates a new instance of the FaceTracker class.</summary>
    /// <returns>An asynchronous operation that returns a FaceTracker instance upon successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<FaceTracker> CreateAsync();

    /// <summary>Returns a list of the bitmap pixels formats supported by the FaceTracker on the current device.</summary>
    /// <returns>A list of the bitmap pixels formats supported by the FaceTracker on the current device.</returns>
    [MethodImpl]
    public static extern IVectorView<BitmapPixelFormat> GetSupportedBitmapPixelFormats();

    /// <summary>Queries whether the specified bitmap pixel format is supported by the FaceTracker on the current device.</summary>
    /// <param name="bitmapPixelFormat">The bitmap pixel format for which support is queried.</param>
    /// <returns>True if the specified bitmap pixel format is supported; otherwise, false.</returns>
    [MethodImpl]
    public static extern bool IsBitmapPixelFormatSupported(BitmapPixelFormat bitmapPixelFormat);

    /// <summary>Gets a value indicating whether the FaceTracker class is supported on the current device.</summary>
    /// <returns>True if FaceTracker; otherwise, false.</returns>
    public static extern bool IsSupported { [MethodImpl] get; }
  }
}
