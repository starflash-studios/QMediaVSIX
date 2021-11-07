// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IPathIOStatics
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
  [Guid(254752600, 36551, 17281, 146, 43, 143, 108, 7, 210, 136, 243)]
  [ExclusiveTo(typeof (PathIO))]
  internal interface IPathIOStatics
  {
    [RemoteAsync]
    [Overload("ReadTextAsync")]
    IAsyncOperation<string> ReadTextAsync(string absolutePath);

    [RemoteAsync]
    [Overload("ReadTextWithEncodingAsync")]
    IAsyncOperation<string> ReadTextAsync(
      string absolutePath,
      UnicodeEncoding encoding);

    [RemoteAsync]
    [Overload("WriteTextAsync")]
    IAsyncAction WriteTextAsync(string absolutePath, string contents);

    [Overload("WriteTextWithEncodingAsync")]
    [RemoteAsync]
    IAsyncAction WriteTextAsync(
      string absolutePath,
      string contents,
      UnicodeEncoding encoding);

    [Overload("AppendTextAsync")]
    [RemoteAsync]
    IAsyncAction AppendTextAsync(string absolutePath, string contents);

    [RemoteAsync]
    [Overload("AppendTextWithEncodingAsync")]
    IAsyncAction AppendTextAsync(
      string absolutePath,
      string contents,
      UnicodeEncoding encoding);

    [Overload("ReadLinesAsync")]
    [RemoteAsync]
    IAsyncOperation<IVector<string>> ReadLinesAsync(string absolutePath);

    [RemoteAsync]
    [Overload("ReadLinesWithEncodingAsync")]
    IAsyncOperation<IVector<string>> ReadLinesAsync(
      string absolutePath,
      UnicodeEncoding encoding);

    [Overload("WriteLinesAsync")]
    IAsyncAction WriteLinesAsync(string absolutePath, IIterable<string> lines);

    [Overload("WriteLinesWithEncodingAsync")]
    IAsyncAction WriteLinesAsync(
      string absolutePath,
      IIterable<string> lines,
      UnicodeEncoding encoding);

    [Overload("AppendLinesAsync")]
    IAsyncAction AppendLinesAsync(string absolutePath, IIterable<string> lines);

    [Overload("AppendLinesWithEncodingAsync")]
    IAsyncAction AppendLinesAsync(
      string absolutePath,
      IIterable<string> lines,
      UnicodeEncoding encoding);

    [RemoteAsync]
    IAsyncOperation<IBuffer> ReadBufferAsync(string absolutePath);

    [RemoteAsync]
    IAsyncAction WriteBufferAsync(string absolutePath, IBuffer buffer);

    [RemoteAsync]
    IAsyncAction WriteBytesAsync(string absolutePath, byte[] buffer);
  }
}
