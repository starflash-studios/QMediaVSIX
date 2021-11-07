// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.BitmapImage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  /// <summary>Provides the practical object source type for the Image.Source and ImageBrush.ImageSource properties. You can define a BitmapImage by using a Uniform Resource Identifier (URI) that references an image source file, or by calling SetSourceAsync and supplying a stream.</summary>
  [Static(typeof (IBitmapImageStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IBitmapImageStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IBitmapImageFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IBitmapImageStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class BitmapImage : BitmapSource, IBitmapImage, IBitmapImage2, IBitmapImage3
  {
    [MethodImpl]
    public extern BitmapImage(Uri uriSource);

    /// <summary>Initializes a new instance of the BitmapImage class.</summary>
    [MethodImpl]
    public extern BitmapImage();

    /// <summary>Gets or sets the BitmapCreateOptions for a BitmapImage.</summary>
    /// <returns>The BitmapCreateOptions used for this BitmapImage. The default is **None**. With this default, a BitmapImage uses cached content when it is available. For a BitmapImage that is created by referencing an image source file by Uniform Resource Identifier (URI), the Uniform Resource Identifier (URI) controls the internal caching scheme.</returns>
    public extern BitmapCreateOptions CreateOptions { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Uniform Resource Identifier (URI) of the graphics source file that generated this BitmapImage.</summary>
    /// <returns>An object describing the Uniform Resource Identifier (URI) of the graphics source file that generated this BitmapImage.</returns>
    public extern Uri UriSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the width to use for image decoding operations.</summary>
    /// <returns>The width (in pixels) to use for image decoding operations.</returns>
    public extern int DecodePixelWidth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the height to use for image decoding operations.</summary>
    /// <returns>The height (in pixels) to use for image decoding operations.</returns>
    public extern int DecodePixelHeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when a significant change has occurred in the download progress of the BitmapImage content.</summary>
    public extern event DownloadProgressEventHandler DownloadProgress;

    /// <summary>Occurs when the image source is downloaded and decoded with no failure. You can use this event to determine the size of an image before rendering it.</summary>
    public extern event RoutedEventHandler ImageOpened;

    /// <summary>Occurs when there is an error associated with image retrieval or format.</summary>
    public extern event ExceptionRoutedEventHandler ImageFailed;

    /// <summary>Gets or sets a value that determines how DecodePixelWidth and DecodePixelHeight values are interpreted for decoding operations.</summary>
    /// <returns>A value of the enumeration. The default is **Physical**.</returns>
    public extern DecodePixelType DecodePixelType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether an image is animated.</summary>
    /// <returns>**true** if the image is animated; otherwise, **false**.</returns>
    public extern bool IsAnimatedBitmap { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether an animated image is playing.</summary>
    /// <returns>**true** if the animated image is playing; otherwise, **false**.</returns>
    public extern bool IsPlaying { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether an animated image should play as soon as it loads.</summary>
    /// <returns>**true** if an animated image should play as soon as it loads; otherwise, **false**. The default is **true**.</returns>
    public extern bool AutoPlay { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Starts the animation of an animated image.</summary>
    [MethodImpl]
    public extern void Play();

    /// <summary>Ends the animation of an animated image.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>Identifies the IsAnimatedBitmap dependency property.</summary>
    /// <returns>The identifier for the IsAnimatedBitmap dependency property.</returns>
    public static extern DependencyProperty IsAnimatedBitmapProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsPlaying dependency property.</summary>
    /// <returns>The identifier for the IsPlaying dependency property.</returns>
    public static extern DependencyProperty IsPlayingProperty { [MethodImpl] get; }

    /// <summary>Identifies the AutoPlay dependency property.</summary>
    /// <returns>The identifier for the AutoPlay dependency property.</returns>
    public static extern DependencyProperty AutoPlayProperty { [MethodImpl] get; }

    /// <summary>Identifies the DecodePixelType dependency property.</summary>
    /// <returns>The identifier for the DecodePixelType dependency property.</returns>
    public static extern DependencyProperty DecodePixelTypeProperty { [MethodImpl] get; }

    /// <summary>Identifies the CreateOptions dependency property.</summary>
    /// <returns>The identifier for the CreateOptions dependency property.</returns>
    public static extern DependencyProperty CreateOptionsProperty { [MethodImpl] get; }

    /// <summary>Identifies the UriSource dependency property.</summary>
    /// <returns>The identifier for the UriSource dependency property.</returns>
    public static extern DependencyProperty UriSourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the DecodePixelWidth dependency property.</summary>
    /// <returns>The identifier for the DecodePixelWidth dependency property.</returns>
    public static extern DependencyProperty DecodePixelWidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the DecodePixelHeight dependency property.</summary>
    /// <returns>The identifier for the DecodePixelHeight dependency property.</returns>
    public static extern DependencyProperty DecodePixelHeightProperty { [MethodImpl] get; }
  }
}
