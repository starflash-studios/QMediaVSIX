#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;

using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using Windows.Storage.Streams;

using Microsoft.VisualStudio.Shell;

using QMediaVSIX.Environment.Utilities;

#endregion

namespace QMediaVSIX.Converters;

public static class ImageConverters {

  /// <summary>
  /// Creates a <see cref="BitmapSource"/> referencing the same handle as the given <paramref name="Icon"/> without creating any extra objects.
  /// </summary>
  /// <param name="Icon">The icon to retrieve a <see cref="BitmapSource"/> from.</param>
  /// <param name="IconSize">The size of the source icon.</param>
  /// <param name="SizeOptions">A value of the enumeration that specifies how to handle conversions.</param>
  /// <returns>A new <see cref="BitmapSource"/> instance with the same handle as the given <paramref name="Icon"/>.</returns>
  public static BitmapSource ToBitmapSource( this Icon Icon, Int32Rect? IconSize = null, BitmapSizeOptions? SizeOptions = null ) => Imaging.CreateBitmapSourceFromHIcon(Icon.Handle, IconSize ?? Int32Rect.Empty, SizeOptions ?? BitmapSizeOptions.FromEmptyOptions());

  /// <summary>
  /// Creates a <see cref="BitmapSource"/> based on the icon at the desired path and size.
  /// </summary>
  /// <param name="IconPath">The path to the icon to retrieve a <see cref="BitmapSource"/> from.</param>
  /// <param name="IconSize">The size of the desired icon.</param>
  /// <returns>A new <see cref="BitmapSource"/> instance.</returns>
  public static BitmapSource GetIconToBitmapSourceCustom( this string IconPath, int IconSize = 256 ) => IconsExtractor.ExtractIconFromFile(IconPath, IconSize).ToBitmapSource();

  /// <summary>
  /// Creates a <see cref="BitmapSource"/> based on the given path to the icon.
  /// </summary>
  /// <param name="IconPath">The path to the icon to retrieve a <see cref="BitmapSource"/> from.</param>
  /// <returns>A new <see cref="BitmapSource"/> instance based on the highest-quality icon extracted from the given path.</returns>
  public static BitmapSource GetBitmapSourceHQ( string IconPath ) => IconExtractor.ExtractIcon(IconPath).ToBitmapSource();

  /// <summary>
  /// Converts the given <see cref="Bitmap"/> into a <see cref="BitmapSource"/>.
  /// </summary>
  /// <param name="Bitmap">The image to convert.</param>
  /// <returns>A new <see cref="BitmapSource"/> instance.</returns>
  public static BitmapSource ToBitmapSource( this Bitmap Bitmap ) {
    BitmapData BitmapData = Bitmap.LockBits(
      new Rectangle(0, 0, Bitmap.Width, Bitmap.Height),
      ImageLockMode.ReadOnly, Bitmap.PixelFormat);

    BitmapSource BitmapSource = BitmapSource.Create(
      BitmapData.Width, BitmapData.Height,
      Bitmap.HorizontalResolution, Bitmap.VerticalResolution,
      PixelFormats.Bgr24, null,
      BitmapData.Scan0, BitmapData.Stride * BitmapData.Height, BitmapData.Stride);

    Bitmap.UnlockBits(BitmapData);

    return BitmapSource;
  }

  /// <summary>
  /// Converts the given <see cref="BitmapSource"/> into a <see cref="BitmapImage"/> with the given encoder.
  /// </summary>
  /// <typeparam name="T">The encoder to use (i.e. <see cref="PngBitmapEncoder"/>)</typeparam>
  /// <param name="Source">The original <see cref="BitmapSource"/> to convert.</param>
  /// <returns>The constructed <see cref="BitmapImage"/> made with the given encoder type (<typeparamref name="T"/>).</returns>
  public static BitmapImage ToBitmapImage<T>( this BitmapSource Source ) where T : BitmapEncoder, new() {
    T Encoder = new T();
    MemoryStream MemoryStream = new MemoryStream();
    BitmapImage BImg = new BitmapImage();

    Encoder.Frames.Add(BitmapFrame.Create(Source));
    Encoder.Save(MemoryStream);

    MemoryStream.Position = 0;
    BImg.BeginInit();
    BImg.StreamSource = MemoryStream;
    BImg.EndInit();

    MemoryStream.Close();

    return BImg;
  }

  /// <summary>
  /// A collection of ongoing conversions.
  /// </summary>
  public static readonly List<Guid> Conversions = new List<Guid>();

  /// <summary>
  /// Requests a thumbnail memory stream conversion, eventually invoking the action upon asynchronous conversion completion.
  /// </summary>
  /// <param name="ThumbnailStream">The memory stream to asynchronously read from.</param>
  /// <param name="Identifier">The identifier for this conversion. Used to determine if returned images are fresh or stale if multiple conversions occur frequently.</param>
  /// <param name="OnCompletion">The action to invoke with the identifier and converted <see cref="Windows.UI.Xaml.Media.Imaging.BitmapImage"/> upon task completion.</param>
  public static void RequestThumbnailConversion( this IRandomAccessStreamReference ThumbnailStream, out Guid Identifier, Action<Guid, BitmapImage> OnCompletion ) {
    Guid Id = Guid.NewGuid();
    Identifier = Id;
    _ = ThreadHelper.JoinableTaskFactory.RunAsync(async () => {
      BitmapImage Bmp = await ConvertToBitmapImageAsync(ThumbnailStream);
      OnCompletion(Id, Bmp);
    });
  }

  /// <summary>
  /// Asynchronously reads from the given memory stream and constructs a <see cref="BitmapImage"/>.
  /// </summary>
  /// <param name="Ref">The memory stream to asynchronously read from.</param>
  /// <returns>A constructed <see cref="BitmapImage"/>.</returns>
  public static async Task<BitmapImage> ConvertToBitmapImageAsync( this IRandomAccessStreamReference Ref ) {
    IRandomAccessStreamWithContentType Stream = await Ref.OpenReadAsync();
    byte[] Bytes = new byte[Stream.Size];
    await Stream.ReadAsync(Bytes.AsBuffer(), (uint)Stream.Size, InputStreamOptions.None);

    using ( InMemoryRandomAccessStream Ms = new InMemoryRandomAccessStream() ) {
      using ( DataWriter Writer = new DataWriter(Ms.GetOutputStreamAt(0)) ) {
        Writer.WriteBytes(Bytes);
        await Writer.StoreAsync();
      }

      BitmapImage Image = new BitmapImage();
      Image.BeginInit();
      Image.StreamSource = Ms.AsStreamForRead();
      Image.EndInit();

      return Image;
    }
  }
}