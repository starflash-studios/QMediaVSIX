// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.FileLoggingSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Foundation.Diagnostics
{
  /// <summary>Represents the destination of logged messages from LoggingChannel instances.</summary>
  [Activatable(typeof (IFileLoggingSessionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class FileLoggingSession : IFileLoggingSession, IClosable
  {
    /// <summary>Initializes a new instance of the FileLoggingSession class.</summary>
    /// <param name="name">The name of the logging session.</param>
    [MethodImpl]
    public extern FileLoggingSession(string name);

    /// <summary>Gets the name of the logging session.</summary>
    /// <returns>The session name.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Adds a logging channel to the current logging session.</summary>
    /// <param name="loggingChannel">The logging channel to add.</param>
    [Overload("AddLoggingChannel")]
    [MethodImpl]
    public extern void AddLoggingChannel(ILoggingChannel loggingChannel);

    /// <summary>Adds a logging channel to the current logging session. The logging channel only accepts events that have a logging level at or above the specified logging level.</summary>
    /// <param name="loggingChannel">The logging channel to add.</param>
    /// <param name="maxLevel">The *minimum* logging level that an event must have to be accepted by the session.</param>
    [Overload("AddLoggingChannelWithLevel")]
    [MethodImpl]
    public extern void AddLoggingChannel(ILoggingChannel loggingChannel, LoggingLevel maxLevel);

    /// <summary>Removes the specified logging channel from the current logging session.</summary>
    /// <param name="loggingChannel">The logging channel to remove.</param>
    [MethodImpl]
    public extern void RemoveLoggingChannel(ILoggingChannel loggingChannel);

    /// <summary>Ends the current logging session and saves it to a file.</summary>
    /// <returns>When this method completes, it returns the new file as a StorageFile. Returns **NULL** if there are no events in the session or if logging has just rolled over into a new file that doesn't contain events yet.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> CloseAndSaveToFileAsync();

    /// <summary>Raised when a log file is saved.</summary>
    public extern event TypedEventHandler<IFileLoggingSession, LogFileGeneratedEventArgs> LogFileGenerated;

    [MethodImpl]
    public extern void Close();
  }
}
