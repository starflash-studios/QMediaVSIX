// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IFileRandomAccessStreamStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage.Streams
{
  [ExclusiveTo(typeof (FileRandomAccessStream))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1934950663, 15191, 19293, 131, 69, 85, 77, 47, 198, 33, 240)]
  internal interface IFileRandomAccessStreamStatics
  {
    [RemoteAsync]
    [Overload("OpenAsync")]
    IAsyncOperation<IRandomAccessStream> OpenAsync(
      string filePath,
      FileAccessMode accessMode);

    [Overload("OpenWithOptionsAsync")]
    [RemoteAsync]
    IAsyncOperation<IRandomAccessStream> OpenAsync(
      string filePath,
      FileAccessMode accessMode,
      StorageOpenOptions sharingOptions,
      FileOpenDisposition openDisposition);

    [Overload("OpenTransactedWriteAsync")]
    [RemoteAsync]
    IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteAsync(
      string filePath);

    [Overload("OpenTransactedWriteWithOptionsAsync")]
    [RemoteAsync]
    IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteAsync(
      string filePath,
      StorageOpenOptions openOptions,
      FileOpenDisposition openDisposition);

    [RemoteAsync]
    [Overload("OpenForUserAsync")]
    IAsyncOperation<IRandomAccessStream> OpenForUserAsync(
      User user,
      string filePath,
      FileAccessMode accessMode);

    [Overload("OpenForUserWithOptionsAsync")]
    [RemoteAsync]
    IAsyncOperation<IRandomAccessStream> OpenForUserAsync(
      User user,
      string filePath,
      FileAccessMode accessMode,
      StorageOpenOptions sharingOptions,
      FileOpenDisposition openDisposition);

    [RemoteAsync]
    [Overload("OpenTransactedWriteForUserAsync")]
    IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteForUserAsync(
      User user,
      string filePath);

    [Overload("OpenTransactedWriteForUserWithOptionsAsync")]
    [RemoteAsync]
    IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteForUserAsync(
      User user,
      string filePath,
      StorageOpenOptions openOptions,
      FileOpenDisposition openDisposition);
  }
}
