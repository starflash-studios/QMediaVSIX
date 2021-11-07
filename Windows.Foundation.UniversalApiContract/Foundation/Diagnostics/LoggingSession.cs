// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.LoggingSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Foundation.Diagnostics
{
  /// <summary>Represents the destination of logged messages from LoggingChannel instances.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (ILoggingSessionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class LoggingSession : ILoggingSession, IClosable
  {
    /// <summary>Initializes a new instance of the LoggingSession class.</summary>
    /// <param name="name">The name of the logging session.</param>
    [MethodImpl]
    public extern LoggingSession(string name);

    /// <summary>Gets the name of the logging session.</summary>
    /// <returns>The session name.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Saves the current logging session to a file.</summary>
    /// <param name="folder">The folder that contains the log file.</param>
    /// <param name="fileName">The name of the log file.</param>
    /// <returns>When this method completes, it returns the new file as a StorageFile.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> SaveToFileAsync(
      IStorageFolder folder,
      string fileName);

    /// <summary>Adds a logging channel to the current logging session.</summary>
    /// <param name="loggingChannel">The logging channel to add.</param>
    [Overload("AddLoggingChannel")]
    [MethodImpl]
    public extern void AddLoggingChannel(ILoggingChannel loggingChannel);

    /// <summary>Adds a logging channel with the specified logging level to the current logging session.</summary>
    /// <param name="loggingChannel">The logging channel to add.</param>
    /// <param name="maxLevel">The logging level for *loggingChannel*.</param>
    [Overload("AddLoggingChannelWithLevel")]
    [MethodImpl]
    public extern void AddLoggingChannel(ILoggingChannel loggingChannel, LoggingLevel maxLevel);

    /// <summary>Removes the specified logging channel from the current logging session.</summary>
    /// <param name="loggingChannel">The logging channel to remove.</param>
    [MethodImpl]
    public extern void RemoveLoggingChannel(ILoggingChannel loggingChannel);

    [MethodImpl]
    public extern void Close();
  }
}
