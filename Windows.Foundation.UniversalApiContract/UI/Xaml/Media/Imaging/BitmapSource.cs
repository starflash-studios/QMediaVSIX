// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.BitmapSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Media.Imaging
{
  /// <summary>Provides a source object for properties that use a bitmap-format image source.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IBitmapSourceFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IBitmapSourceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public class BitmapSource : ImageSource, IBitmapSource
  {
    /// <summary>Provides base class initialization behavior for BitmapSource -derived classes.</summary>
    [MethodImpl]
    protected extern BitmapSource();

    /// <summary>Gets the width of the bitmap in pixels.</summary>
    /// <returns>The width of the bitmap in pixels.</returns>
    public extern int PixelWidth { [MethodImpl] get; }

    /// <summary>Gets the height of the bitmap in pixels.</summary>
    /// <returns>The height of the bitmap in pixels.</returns>
    public extern int PixelHeight { [MethodImpl] get; }

    /// <summary>Sets the source image for a BitmapSource by accessing a stream. Most callers should use SetSourceAsync instead.</summary>
    /// <param name="streamSource">The stream source that sets the image source value.</param>
    [MethodImpl]
    public extern void SetSource(IRandomAccessStream streamSource);

    /// <summary>Sets the source image for a BitmapSource by accessing a stream and processing the result asynchronously.</summary>
    /// <param name="streamSource">The stream source that sets the image source value.</param>
    /// <returns>An asynchronous handler called when the operation is complete.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetSourceAsync(IRandomAccessStream streamSource);

    /// <summary>Identifies the PixelWidth dependency property.</summary>
    /// <returns>The identifier for the PixelWidth dependency property.</returns>
    public static extern DependencyProperty PixelWidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the PixelHeight dependency property.</summary>
    /// <returns>The identifier for the PixelHeight dependency property.</returns>
    public static extern DependencyProperty PixelHeightProperty { [MethodImpl] get; }
  }
}
