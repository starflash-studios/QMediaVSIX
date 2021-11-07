// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.SvgImageSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Media.Imaging
{
  /// <summary>Provides a source object for properties that use a Scalable Vector Graphics (SVG) source. You can define a SvgImageSource by using a Uniform Resource Identifier (URI) that references a SVG file, or by calling SetSourceAsync(IRandomAccessStream) and supplying a stream.</summary>
  [Static(typeof (ISvgImageSourceStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (ISvgImageSourceFactory), CompositionType.Public, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public class SvgImageSource : ImageSource, ISvgImageSource
  {
    /// <summary>Initializes a new instance of the SvgImageSource class.</summary>
    [MethodImpl]
    public extern SvgImageSource();

    [MethodImpl]
    public extern SvgImageSource(Uri uriSource);

    /// <summary>Gets or sets the Uniform Resource Identifier (URI) of the SVG source file that generated this SvgImageSource.</summary>
    /// <returns>An object describing the Uniform Resource Identifier (URI) of the SVG source file that generated this SvgImageSource.</returns>
    public extern Uri UriSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the width to use for SVG rasterization operations.</summary>
    /// <returns>The width (in logical pixels) to use for SVG decoding operations. The default is **Double.NaN**.</returns>
    public extern double RasterizePixelWidth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the height to use for SVG rasterization operations.</summary>
    /// <returns>The height (in logical pixels) to use for SVG decoding operations. The default is **Double.NaN**.</returns>
    public extern double RasterizePixelHeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the SVG source is downloaded and decoded with no failure.</summary>
    public extern event TypedEventHandler<SvgImageSource, SvgImageSourceOpenedEventArgs> Opened;

    /// <summary>Occurs when there is an error associated with SVG retrieval or format.</summary>
    public extern event TypedEventHandler<SvgImageSource, SvgImageSourceFailedEventArgs> OpenFailed;

    /// <summary>Sets the source SVG for a SvgImageSource by accessing a stream and processing the result asynchronously.</summary>
    /// <param name="streamSource">The stream source that sets the SVG source value.</param>
    /// <returns>A SvgImageSourceLoadStatus value that indicates whether the operation was successful. If it failed, indicates the reason for the failure.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SvgImageSourceLoadStatus> SetSourceAsync(
      IRandomAccessStream streamSource);

    /// <summary>Identifies the **UriSource** dependency property.</summary>
    /// <returns>The identifier for the **UriSource** dependency property.</returns>
    public static extern DependencyProperty UriSourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the **RasterizePixelWidth** dependency property.</summary>
    /// <returns>The identifier for the **RasterizePixelWidth** dependency property.</returns>
    public static extern DependencyProperty RasterizePixelWidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the **RasterizePixelHeight** dependency property.</summary>
    /// <returns>The identifier for the **RasterizePixelHeight** dependency property.</returns>
    public static extern DependencyProperty RasterizePixelHeightProperty { [MethodImpl] get; }
  }
}
