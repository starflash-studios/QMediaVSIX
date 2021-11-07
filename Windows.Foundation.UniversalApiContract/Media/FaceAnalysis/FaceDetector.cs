// Decompiled with JetBrains decompiler
// Type: Windows.Media.FaceAnalysis.FaceDetector
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
  /// <summary>Detects faces in a SoftwareBitmap.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IFaceDetectorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class FaceDetector : IFaceDetector
  {
    /// <summary>Asynchronously detects faces in the provided SoftwareBitmap.</summary>
    /// <param name="image">The image data to be processed for face detection.</param>
    /// <returns>An asynchronous operation that returns a list of DetectedFace objects upon successful completion.</returns>
    [Overload("DetectFacesAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVector<DetectedFace>> DetectFacesAsync(
      SoftwareBitmap image);

    /// <summary>Asynchronously detects faces in the provided SoftwareBitmap within the specified search area.</summary>
    /// <param name="image">The image data to be processed for face detection.</param>
    /// <param name="searchArea">The bounds within the SoftwareBitmap in which face detection will be performed.</param>
    /// <returns>An asynchronous operation that returns a list of DetectedFace objects upon successful completion.</returns>
    [RemoteAsync]
    [Overload("DetectFacesWithSearchAreaAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVector<DetectedFace>> DetectFacesAsync(
      SoftwareBitmap image,
      BitmapBounds searchArea);

    /// <summary>Gets or sets the minimum detectable face size, in pixels.</summary>
    /// <returns>The minimum detectable face size, in pixels.</returns>
    public extern BitmapSize MinDetectableFaceSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum detectable face size, in pixels.</summary>
    /// <returns>The maximum detectable face size, in pixels.</returns>
    public extern BitmapSize MaxDetectableFaceSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Creates a new instance of the FaceDetector class.</summary>
    /// <returns>An asynchronous operation that returns a FaceDetector instance upon successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<FaceDetector> CreateAsync();

    /// <summary>Returns a list of the bitmap pixels formats supported by the FaceDetector on the current device.</summary>
    /// <returns>A list of the bitmap pixels formats supported by the FaceDetector on the current device.</returns>
    [MethodImpl]
    public static extern IVectorView<BitmapPixelFormat> GetSupportedBitmapPixelFormats();

    /// <summary>Queries whether the specified bitmap pixel format is supported by the FaceDetector on the current device.</summary>
    /// <param name="bitmapPixelFormat">The bitmap pixel format for which support is queried.</param>
    /// <returns>True if the specified bitmap pixel format is supported; otherwise, false.</returns>
    [MethodImpl]
    public static extern bool IsBitmapPixelFormatSupported(BitmapPixelFormat bitmapPixelFormat);

    /// <summary>Gets a value indicating whether the FaceDetector class is supported on the current device.</summary>
    /// <returns>True if FaceDetector; otherwise, false.</returns>
    public static extern bool IsSupported { [MethodImpl] get; }
  }
}
