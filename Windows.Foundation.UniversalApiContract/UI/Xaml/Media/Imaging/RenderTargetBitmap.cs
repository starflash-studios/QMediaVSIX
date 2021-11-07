// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.RenderTargetBitmap
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Media.Imaging
{
  /// <summary>Represents an image source that can be populated with the combined contents of a XAML visual tree. See  for some notable limitations on which XAML visuals can be captured in a RenderTargetBitmap.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IRenderTargetBitmapStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class RenderTargetBitmap : ImageSource, IRenderTargetBitmap
  {
    /// <summary>Initializes a new instance of the RenderTargetBitmap class.</summary>
    [MethodImpl]
    public extern RenderTargetBitmap();

    /// <summary>Gets the width of the rendered bitmap in pixels.</summary>
    /// <returns>The width of the rendered bitmap in pixels.</returns>
    public extern int PixelWidth { [MethodImpl] get; }

    /// <summary>Gets the height of the rendered bitmap in pixels.</summary>
    /// <returns>The height of the rendered bitmap in pixels.</returns>
    public extern int PixelHeight { [MethodImpl] get; }

    /// <summary>Renders a snapshot of a UIElement visual tree to an image source.</summary>
    /// <param name="element">A UIElement that represents the visual tree fragment to render.</param>
    /// <returns>When this method returns, an IAsyncAction object that can be used to control the asynchronous operation.</returns>
    [Overload("RenderAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RenderAsync(UIElement element);

    /// <summary>Renders a snapshot of a UIElement visual tree to an image source. Specify values for *scaledWidth* and *scaledHeight* to alter the original source's rendering dimension.</summary>
    /// <param name="element">A UIElement that represents the visual tree fragment to render.</param>
    /// <param name="scaledWidth">Specifies the target width at which to render. The default is 0. *scaledWidth* and/or *scaledHeight* can be optional; see Remarks.</param>
    /// <param name="scaledHeight">Specifies the target height at which to render. The default is 0. *scaledWidth* and/or *scaledHeight* can be optional; see Remarks.</param>
    /// <returns>When this method returns, an IAsyncAction object that can be used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [Overload("RenderToSizeAsync")]
    [MethodImpl]
    public extern IAsyncAction RenderAsync(
      UIElement element,
      int scaledWidth,
      int scaledHeight);

    /// <summary>Retrieves the previously rendered RenderTargetBitmap image as a buffered stream of bytes in **BGRA8** format.</summary>
    /// <returns>When this method returns, an IBuffer stream that contains bytes. This is the binary data for the image and can be converted to a byte array in **BGRA8** format</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> GetPixelsAsync();

    /// <summary>Identifies the PixelWidth dependency property.</summary>
    /// <returns>The identifier for the PixelWidth dependency property.</returns>
    public static extern DependencyProperty PixelWidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the PixelHeight dependency property.</summary>
    /// <returns>The identifier for the PixelHeight dependency property.</returns>
    public static extern DependencyProperty PixelHeightProperty { [MethodImpl] get; }
  }
}
