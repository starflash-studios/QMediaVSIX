// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.LoadedImageSurface
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Represents a composition surface that an image can be downloaded, decoded and loaded onto. You can load an image using a Uniform Resource Identifier (URI) that references an image source file, or supplying a IRandomAccessStream.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (ILoadedImageSurfaceStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class LoadedImageSurface : ILoadedImageSurface, IClosable, ICompositionSurface
  {
    /// <summary>Gets the size of the decoded image in physical pixels.</summary>
    /// <returns>The size of the decoded image in physical pixels.</returns>
    public extern Size DecodedPhysicalSize { [MethodImpl] get; }

    /// <summary>Gets the size of the decoded image in device independent pixels.</summary>
    /// <returns>The size of the decoded image in device independent pixels.</returns>
    public extern Size DecodedSize { [MethodImpl] get; }

    /// <summary>Gets the natural size of the image in physical pixels, which is defined in the original image source.</summary>
    /// <returns>The natural size of the image in physical pixels.</returns>
    public extern Size NaturalSize { [MethodImpl] get; }

    /// <summary>Occurs when the image has been downloaded, decoded and loaded to the underlying ICompositionSurface.</summary>
    public extern event TypedEventHandler<LoadedImageSurface, LoadedImageSourceLoadCompletedEventArgs> LoadCompleted;

    [MethodImpl]
    public extern void Close();

    [Overload("StartLoadFromUriWithSize")]
    [MethodImpl]
    public static extern LoadedImageSurface StartLoadFromUri(
      Uri uri,
      Size desiredMaxSize);

    [Overload("StartLoadFromUri")]
    [MethodImpl]
    public static extern LoadedImageSurface StartLoadFromUri(Uri uri);

    /// <summary>Loads an image into a LoadedImageSurface from the provided IRandomAccessStream with the desired maximum size.</summary>
    /// <param name="stream">The stream from which the image is loaded.</param>
    /// <param name="desiredMaxSize">The desired maximum size of the image surface in device independent pixels.</param>
    /// <returns>An instance of LoadedImageSurface with the image loaded onto its surface.</returns>
    [Overload("StartLoadFromStreamWithSize")]
    [MethodImpl]
    public static extern LoadedImageSurface StartLoadFromStream(
      IRandomAccessStream stream,
      Size desiredMaxSize);

    /// <summary>Loads an image onto a LoadedImageSurface from the provided IRandomAccessStream at the natural size</summary>
    /// <param name="stream">The stream from which the image is loaded.</param>
    /// <returns>An instance of LoadedImageSurface with the image loaded onto its surface.</returns>
    [Overload("StartLoadFromStream")]
    [MethodImpl]
    public static extern LoadedImageSurface StartLoadFromStream(
      IRandomAccessStream stream);
  }
}
