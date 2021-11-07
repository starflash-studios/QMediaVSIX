// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IFileIOStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FileIO))]
  [Guid(2289308139, 32596, 18226, 165, 240, 94, 67, 227, 184, 194, 245)]
  internal interface IFileIOStatics
  {
    [Overload("ReadTextAsync")]
    [RemoteAsync]
    IAsyncOperation<string> ReadTextAsync(IStorageFile file);

    [RemoteAsync]
    [Overload("ReadTextWithEncodingAsync")]
    IAsyncOperation<string> ReadTextAsync(
      IStorageFile file,
      UnicodeEncoding encoding);

    [Overload("WriteTextAsync")]
    [RemoteAsync]
    IAsyncAction WriteTextAsync(IStorageFile file, string contents);

    [RemoteAsync]
    [Overload("WriteTextWithEncodingAsync")]
    IAsyncAction WriteTextAsync(
      IStorageFile file,
      string contents,
      UnicodeEncoding encoding);

    [Overload("AppendTextAsync")]
    [RemoteAsync]
    IAsyncAction AppendTextAsync(IStorageFile file, string contents);

    [RemoteAsync]
    [Overload("AppendTextWithEncodingAsync")]
    IAsyncAction AppendTextAsync(
      IStorageFile file,
      string contents,
      UnicodeEncoding encoding);

    [RemoteAsync]
    [Overload("ReadLinesAsync")]
    IAsyncOperation<IVector<string>> ReadLinesAsync(IStorageFile file);

    [RemoteAsync]
    [Overload("ReadLinesWithEncodingAsync")]
    IAsyncOperation<IVector<string>> ReadLinesAsync(
      IStorageFile file,
      UnicodeEncoding encoding);

    [Overload("WriteLinesAsync")]
    IAsyncAction WriteLinesAsync(IStorageFile file, IIterable<string> lines);

    [Overload("WriteLinesWithEncodingAsync")]
    IAsyncAction WriteLinesAsync(
      IStorageFile file,
      IIterable<string> lines,
      UnicodeEncoding encoding);

    [Overload("AppendLinesAsync")]
    IAsyncAction AppendLinesAsync(IStorageFile file, IIterable<string> lines);

    [Overload("AppendLinesWithEncodingAsync")]
    IAsyncAction AppendLinesAsync(
      IStorageFile file,
      IIterable<string> lines,
      UnicodeEncoding encoding);

    [RemoteAsync]
    IAsyncOperation<IBuffer> ReadBufferAsync(IStorageFile file);

    [RemoteAsync]
    IAsyncAction WriteBufferAsync(IStorageFile file, IBuffer buffer);

    [RemoteAsync]
    IAsyncAction WriteBytesAsync(IStorageFile file, byte[] buffer);
  }
}
