// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Foundation.Diagnostics
{
  /// <summary>Represents the destination of logged messages from LoggingChannel instances.</summary>
  [Guid(1646392070, 37760, 19159, 186, 245, 65, 234, 147, 16, 215, 104)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ILoggingSession : IClosable
  {
    /// <summary>Gets the name of the logging session.</summary>
    /// <returns>The session name.</returns>
    string Name { get; }

    /// <summary>Save the current logging session to a file.</summary>
    /// <param name="folder">The folder to save the log file in.</param>
    /// <param name="fileName">The name of the file.</param>
    /// <returns>When this method completes, it returns the new file as a StorageFile.</returns>
    [RemoteAsync]
    IAsyncOperation<StorageFile> SaveToFileAsync(
      IStorageFolder folder,
      string fileName);

    /// <summary>Adds a logging channel to the current logging session.</summary>
    /// <param name="loggingChannel">The logging channel to add.</param>
    [Overload("AddLoggingChannel")]
    void AddLoggingChannel(ILoggingChannel loggingChannel);

    /// <summary>Adds a logging channel with the specified logging level to the current logging session.</summary>
    /// <param name="loggingChannel">The logging channel to add.</param>
    /// <param name="maxLevel">The logging level for *loggingChannel*.</param>
    [Overload("AddLoggingChannelWithLevel")]
    void AddLoggingChannel(ILoggingChannel loggingChannel, LoggingLevel maxLevel);

    /// <summary>Removes the specified logging channel from the current logging session.</summary>
    /// <param name="loggingChannel">The logging channel to remove.</param>
    void RemoveLoggingChannel(ILoggingChannel loggingChannel);
  }
}
