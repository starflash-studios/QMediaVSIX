// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.CapturedFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.Storage.Streams;

namespace Windows.Media.Capture
{
  /// <summary>Represents a captured video frame.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [GCPressure(amount = GCPressureAmount.High)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CapturedFrame : 
    ICapturedFrame,
    IRandomAccessStreamWithContentType,
    IContentTypeProvider,
    IRandomAccessStream,
    IOutputStream,
    IClosable,
    IInputStream,
    ICapturedFrameWithSoftwareBitmap,
    ICapturedFrame2
  {
    /// <summary>Gets the width of the captured frame.</summary>
    /// <returns>The width of the captured frame.</returns>
    public extern uint Width { [MethodImpl] get; }

    /// <summary>Gets the height of the captured frame</summary>
    /// <returns>The height of the frame.</returns>
    public extern uint Height { [MethodImpl] get; }

    /// <summary>Gets the size of the captured frame in bytes.</summary>
    /// <returns>The size of the captured frame in bytes.</returns>
    public extern ulong Size { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the input stream at the specified position.</summary>
    /// <param name="position">The position in the input stream.</param>
    /// <returns>The input stream.</returns>
    [MethodImpl]
    public extern IInputStream GetInputStreamAt(ulong position);

    /// <summary>Gets the output stream at the specified position.</summary>
    /// <param name="position">The position in the output stream.</param>
    /// <returns>The output stream.</returns>
    [MethodImpl]
    public extern IOutputStream GetOutputStreamAt(ulong position);

    /// <summary>Gets the position of the captured frame.</summary>
    /// <returns>The position of the captured frame.</returns>
    public extern ulong Position { [MethodImpl] get; }

    /// <summary>Seeks the stream to the specified position.</summary>
    /// <param name="position">The position in the stream to seek too.</param>
    [MethodImpl]
    public extern void Seek(ulong position);

    /// <summary>Creates a copy of the stream.</summary>
    /// <returns>The clone of the strem.</returns>
    [MethodImpl]
    public extern IRandomAccessStream CloneStream();

    /// <summary>Gets a value that indicates if the captured frame can be read from.</summary>
    /// <returns>**true** if the captured frame can be read from; otherwise, **false**.</returns>
    public extern bool CanRead { [MethodImpl] get; }

    /// <summary>Gets a value that indicates if the captured frame can be written to.</summary>
    /// <returns>**true** if the captured frame can be written to; otherwise, **false**.</returns>
    public extern bool CanWrite { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    /// <summary>Returns an asynchronous byte reader object.</summary>
    /// <param name="buffer">The buffer into which the asynchronous read operation places the bytes that are read.</param>
    /// <param name="count">The number of bytes to read that is less than or equal to the [Capacity](https://docs.microsoft.com/previous-versions/hh438363(v=vs.85)) value.</param>
    /// <param name="options">Specifies the type of the asynchronous read operation.</param>
    /// <returns>The asynchronous operation.</returns>
    [MethodImpl]
    public extern IAsyncOperationWithProgress<IBuffer, uint> ReadAsync(
      IBuffer buffer,
      uint count,
      InputStreamOptions options);

    /// <summary>Asynchronously writes the specified data to the stream.</summary>
    /// <param name="buffer">The data to write to the stream.</param>
    /// <returns>Represents an asynchronous operation that returns a result and reports progress.</returns>
    [MethodImpl]
    public extern IAsyncOperationWithProgress<uint, uint> WriteAsync(
      IBuffer buffer);

    /// <summary>Asynchronously commits and flushes all of the data of the CapturedFrame.</summary>
    /// <returns>When this method completes, a boolean value is returned which specifies **true** if the operation completed successfully; otherwise, **false**.</returns>
    [MethodImpl]
    public extern IAsyncOperation<bool> FlushAsync();

    /// <summary>Gets the content type of the captured frame.</summary>
    /// <returns>The content type of the captured frame.</returns>
    public extern string ContentType { [MethodImpl] get; }

    /// <summary>Gets a SoftwareBitmap object representing the captured frame.</summary>
    /// <returns>A SoftwareBitmap object representing the captured frame.</returns>
    public extern SoftwareBitmap SoftwareBitmap { [MethodImpl] get; }

    /// <summary>Gets an object containing capture control metadata for the CapturedFrame. Capture controls adjust capture settings such as ISO and exposure.</summary>
    /// <returns>An object containing capture control metadata for the CapturedFrame.</returns>
    public extern CapturedFrameControlValues ControlValues { [MethodImpl] get; }

    /// <summary>Gets an object containing bitmap properties for the CapturedFrame. These properties convey image metadata such as EXIF data.</summary>
    /// <returns>An object containing bitmap properties for the CapturedFrame.</returns>
    public extern BitmapPropertySet BitmapProperties { [MethodImpl] get; }
  }
}
