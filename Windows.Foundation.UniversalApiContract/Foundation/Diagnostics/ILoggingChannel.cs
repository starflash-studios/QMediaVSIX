// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingChannel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  /// <summary>Represents a source of log messages.</summary>
  [Guid(3919905603, 4567, 20225, 181, 202, 207, 73, 82, 120, 192, 168)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ILoggingChannel : IClosable
  {
    /// <summary>Gets the name of the current LoggingChannel.</summary>
    /// <returns>The name.</returns>
    string Name { get; }

    /// <summary>Gets a value that indicates whether messages are being logged on the current LoggingChannel.</summary>
    /// <returns>**True** if messages are being logged on the current channel; otherwise, **false**.</returns>
    bool Enabled { get; }

    /// <summary>Gets the level of detail for messages from the current LoggingChannel.</summary>
    /// <returns>The level of detail for messages.</returns>
    LoggingLevel Level { get; }

    /// <summary>Logs a message to the current LoggingChannel.</summary>
    /// <param name="eventString">The message to log.</param>
    [Overload("LogMessage")]
    void LogMessage(string eventString);

    /// <summary>Logs a message to the current LoggingChannel with the specified LoggingLevel.</summary>
    /// <param name="eventString">The message to log.</param>
    /// <param name="level">The logging level.</param>
    [Overload("LogMessageWithLevel")]
    void LogMessage(string eventString, LoggingLevel level);

    /// <summary>Logs data to the current LoggingChannel.</summary>
    /// <param name="value1">The string to associate with *value2*.</param>
    /// <param name="value2">The value to associate with *value1*.</param>
    [Overload("LogValuePair")]
    void LogValuePair(string value1, int value2);

    /// <summary>Logs data to the current LoggingChannel with the specified LoggingLevel.</summary>
    /// <param name="value1">The string to associate with *value2*.</param>
    /// <param name="value2">The value to associate with *value1*.</param>
    /// <param name="level">The logging level.</param>
    [Overload("LogValuePairWithLevel")]
    void LogValuePair(string value1, int value2, LoggingLevel level);

    /// <summary>Raised when the logging channel is attached to a LoggingSession or other event tracing and debugging tools.</summary>
    event TypedEventHandler<ILoggingChannel, object> LoggingEnabled;
  }
}
