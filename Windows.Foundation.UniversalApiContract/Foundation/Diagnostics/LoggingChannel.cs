// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.LoggingChannel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  /// <summary>Represents a source of log messages.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ILoggingChannelFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (ILoggingChannelFactory2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class LoggingChannel : ILoggingChannel, IClosable, ILoggingChannel2, ILoggingTarget
  {
    /// <summary>Initializes a new instance of the LoggingChannel class with the specified options.</summary>
    /// <param name="name">The name of the logging channel.</param>
    /// <param name="options">The channel options. Pass **null** to specify the default options.</param>
    [MethodImpl]
    public extern LoggingChannel(string name, LoggingChannelOptions options);

    /// <summary>Initializes a new instance of the LoggingChannel class with the specified options and channel ID.</summary>
    /// <param name="name">The name of the logging channel.</param>
    /// <param name="options">The channel options. Pass **null** to specify the default options.</param>
    /// <param name="id">The channel identifier to use instead of the automatically generated identifier.</param>
    [MethodImpl]
    public extern LoggingChannel(string name, LoggingChannelOptions options, Guid id);

    /// <summary>This constructor creates a **LoggingChannel** in Windows 8.1 compatibility mode.</summary>
    /// <deprecated type="deprecate">This constructor creates a LoggingChannel in Windows 8.1 compatibility mode. Prefer the two-parameter constructor.</deprecated>
    /// <param name="name">The name of the logging channel.</param>
    [Deprecated("This constructor creates a LoggingChannel in Windows 8.1 compatibility mode. Prefer the two-parameter constructor.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern LoggingChannel(string name);

    /// <summary>Gets the name of the current LoggingChannel.</summary>
    /// <returns>The name.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether at least one session is logging events from this channel.</summary>
    /// <returns>Returns **true** if at least one session is listening for events from the channel, and otherwise **false**.</returns>
    public extern bool Enabled { [MethodImpl] get; }

    /// <summary>Gets the minimum level at which any session is listening to events from this channel.</summary>
    /// <returns>The event level required for the session to listen to an event from this channel.</returns>
    public extern LoggingLevel Level { [MethodImpl] get; }

    /// <summary>Logs a message to the current LoggingChannel.</summary>
    /// <param name="eventString">The message to log.</param>
    [Overload("LogMessage")]
    [MethodImpl]
    public extern void LogMessage(string eventString);

    /// <summary>Logs a message to the current LoggingChannel with the specified LoggingLevel.</summary>
    /// <param name="eventString">The message to log.</param>
    /// <param name="level">The logging level.</param>
    [Overload("LogMessageWithLevel")]
    [MethodImpl]
    public extern void LogMessage(string eventString, LoggingLevel level);

    /// <summary>Logs data to the current LoggingChannel.</summary>
    /// <param name="value1">The string to associate with *value2*.</param>
    /// <param name="value2">The value to associate with *value1*.</param>
    [Overload("LogValuePair")]
    [MethodImpl]
    public extern void LogValuePair(string value1, int value2);

    /// <summary>Logs data to the current LoggingChannel with the specified LoggingLevel.</summary>
    /// <param name="value1">The string to associate with *value2*.</param>
    /// <param name="value2">The value to associate with *value1*.</param>
    /// <param name="level">The logging level.</param>
    [Overload("LogValuePairWithLevel")]
    [MethodImpl]
    public extern void LogValuePair(string value1, int value2, LoggingLevel level);

    /// <summary>Raised when the logging channel is attached to a LoggingSession or other event tracing and debugging tools.</summary>
    public extern event TypedEventHandler<ILoggingChannel, object> LoggingEnabled;

    [MethodImpl]
    public extern void Close();

    /// <summary>Returns the provider identifier for this channel.</summary>
    /// <returns>The provider identifier for this channel.</returns>
    public extern Guid Id { [MethodImpl] get; }

    /// <summary>Indicates whether at least one session is listening for events from the channel.</summary>
    /// <returns>Returns **true** if at least one session is listening for events from the channel, and otherwise **false**.</returns>
    [Overload("IsEnabled")]
    [MethodImpl]
    public extern bool IsEnabled();

    /// <summary>Indicates whether at least one session is listening for events with the specified event severity level from the channel.</summary>
    /// <param name="level">The event severity level.</param>
    /// <returns>Returns **true** if at least one session is listening for events with the specified level from the channel, and otherwise **false**.</returns>
    [Overload("IsEnabledWithLevel")]
    [MethodImpl]
    public extern bool IsEnabled(LoggingLevel level);

    /// <summary>Indicates whether at least one session is listening for events with the specified level and keywords from this channel.</summary>
    /// <param name="level">The event severity level.</param>
    /// <param name="keywords">The keywords. Each bit of the keywords value represents an event category.</param>
    /// <returns>Returns **true** if at least one session is listening for events with the specified level and keywords from the channel, and otherwise **false**.</returns>
    [Overload("IsEnabledWithLevelAndKeywords")]
    [MethodImpl]
    public extern bool IsEnabled(LoggingLevel level, long keywords);

    /// <summary>Logs an event with the specified name.</summary>
    /// <param name="eventName">The name for this event.</param>
    [Overload("LogEvent")]
    [MethodImpl]
    public extern void LogEvent(string eventName);

    /// <summary>Logs an event with the specified name and fields.</summary>
    /// <param name="eventName">The name for this event.</param>
    /// <param name="fields">The fields for this event. May be **null**.</param>
    [Overload("LogEventWithFields")]
    [MethodImpl]
    public extern void LogEvent(string eventName, LoggingFields fields);

    /// <summary>Logs an event with the specified name, fields, and level.</summary>
    /// <param name="eventName">The name for this event.</param>
    /// <param name="fields">The fields for this event. May be **null**.</param>
    /// <param name="level">The level of detail for this event.</param>
    [Overload("LogEventWithFieldsAndLevel")]
    [MethodImpl]
    public extern void LogEvent(string eventName, LoggingFields fields, LoggingLevel level);

    /// <summary>Logs an event with the specified name, fields, level, and options.</summary>
    /// <param name="eventName">The name for this event.</param>
    /// <param name="fields">The fields for this event. May be **null**.</param>
    /// <param name="level">The level of detail for this event.</param>
    /// <param name="options">The options for this event. Pass **null** to use the default options. The options are for advanced scenarios. The default values are designed to work well for most events.</param>
    [Overload("LogEventWithFieldsAndOptions")]
    [MethodImpl]
    public extern void LogEvent(
      string eventName,
      LoggingFields fields,
      LoggingLevel level,
      LoggingOptions options);

    /// <summary>Writes an activity start event and creates a **LoggingActivity** object.</summary>
    /// <param name="startEventName">The name for this event.</param>
    /// <returns>Returns an object that represents the new activity.</returns>
    [Overload("StartActivity")]
    [MethodImpl]
    public extern LoggingActivity StartActivity(string startEventName);

    /// <summary>Writes an activity start event with the specified fields and creates a **LoggingActivity** object.</summary>
    /// <param name="startEventName">The name for this event.</param>
    /// <param name="fields">The fields for this event.</param>
    /// <returns>Returns an object that represents the new activity.</returns>
    [Overload("StartActivityWithFields")]
    [MethodImpl]
    public extern LoggingActivity StartActivity(
      string startEventName,
      LoggingFields fields);

    /// <summary>Writes an activity start event with the specified fields and level, and creates a **LoggingActivity** object.</summary>
    /// <param name="startEventName">The name for this event.</param>
    /// <param name="fields">The fields for this event. May be **null **.</param>
    /// <param name="level">The level of detail for this event.</param>
    /// <returns>Returns an object that represents the new activity.</returns>
    [Overload("StartActivityWithFieldsAndLevel")]
    [MethodImpl]
    public extern LoggingActivity StartActivity(
      string startEventName,
      LoggingFields fields,
      LoggingLevel level);

    /// <summary>Writes an activity start event with the specified fields, level, and options, and creates a **LoggingActivity** object.</summary>
    /// <param name="startEventName">The name for this event.</param>
    /// <param name="fields">The fields for this event. May be **null**.</param>
    /// <param name="level">The level of detail for this event.</param>
    /// <param name="options">The options for this event. Pass **null** to use the default options. The options are for advanced scenarios. The default values are designed to work well for most events.</param>
    /// <returns>Returns an object that represents the new activity.</returns>
    [Overload("StartActivityWithFieldsAndOptions")]
    [MethodImpl]
    public extern LoggingActivity StartActivity(
      string startEventName,
      LoggingFields fields,
      LoggingLevel level,
      LoggingOptions options);
  }
}
