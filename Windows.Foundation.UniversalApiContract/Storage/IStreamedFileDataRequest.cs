// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStreamedFileDataRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Represents a sequential-access output stream that indicates a request for the data stream of a StorageFile that was created by calling CreateStreamedFileAsync or ReplaceWithStreamedFileAsync.</summary>
  [Guid(376700110, 55997, 19792, 190, 238, 24, 11, 138, 129, 145, 182)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IStreamedFileDataRequest
  {
    /// <summary>Indicates that the data can't be streamed and releases system resources that are exposed by the current stream indicating that the data request is complete.</summary>
    /// <param name="failureMode">The enum value that indicates why the data stream can't be accessed.</param>
    void FailAndClose(StreamedFileFailureMode failureMode);
  }
}
