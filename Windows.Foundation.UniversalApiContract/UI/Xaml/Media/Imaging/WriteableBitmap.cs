// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.WriteableBitmap
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Media.Imaging
{
  /// <summary>Provides a BitmapSource that can be written to and updated.</summary>
  [Activatable(typeof (IWriteableBitmapFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WriteableBitmap : BitmapSource, IWriteableBitmap
  {
    /// <summary>Initializes a new instance of the WriteableBitmap class.</summary>
    /// <param name="pixelWidth">The width of the bitmap in pixels.</param>
    /// <param name="pixelHeight">The height of the bitmap in pixels.</param>
    [MethodImpl]
    public extern WriteableBitmap(int pixelWidth, int pixelHeight);

    /// <summary>Gets an access for the direct buffer where each pixel of the WriteableBitmap is written to.</summary>
    /// <returns>A reference to the pixel buffer.</returns>
    public extern IBuffer PixelBuffer { [MethodImpl] get; }

    /// <summary>Requests a draw or redraw of the entire bitmap.</summary>
    [MethodImpl]
    public extern void Invalidate();
  }
}
