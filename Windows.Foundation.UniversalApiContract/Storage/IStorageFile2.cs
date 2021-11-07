// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageFile2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage
{
  /// <summary>Represents a file. Provides information about the file and its contents, and ways to manipulate them.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2504936399, 2679, 17147, 183, 119, 194, 237, 88, 165, 46, 68)]
  public interface IStorageFile2
  {
    /// <summary>Opens a random-access stream over the file.</summary>
    /// <param name="accessMode">One of the enumeration values that specifies the type of access to allow.</param>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for opening the stream.</param>
    /// <returns>When this method completes, it returns an IRandomAccessStream that contains the requested random-access stream.</returns>
    [Overload("OpenWithOptionsAsync")]
    [RemoteAsync]
    IAsyncOperation<IRandomAccessStream> OpenAsync(
      FileAccessMode accessMode,
      StorageOpenOptions options);

    /// <summary>Opens a random-access stream to the file that can be used for transacted-write operations with the specified options.</summary>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for opening the stream.</param>
    /// <returns>When this method completes, it returns a StorageStreamTransaction containing the random-access stream and methods that can be used to complete transactions.</returns>
    [RemoteAsync]
    [Overload("OpenTransactedWriteWithOptionsAsync")]
    IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteAsync(
      StorageOpenOptions options);
  }
}
