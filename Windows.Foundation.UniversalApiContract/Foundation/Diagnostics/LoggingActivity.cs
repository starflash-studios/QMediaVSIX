// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.LoggingActivity
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  /// <summary>Creates Event Tracing for Windows (ETW) events that mark the start and end of a group of related events.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ILoggingActivityFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class LoggingActivity : 
    ILoggingActivity,
    IClosable,
    ILoggingActivity2,
    ILoggingTarget
  {
    /// <summary>Initializes a new instance of the LoggingActivity class for the specified LoggingChannel in Windows 8.1 compatibility mode.</summary>
    /// <param name="activityName">The name of the logging activity.</param>
    /// <param name="loggingChannel">The logging channel.</param>
    [MethodImpl]
    public extern LoggingActivity(string activityName, ILoggingChannel loggingChannel);

    /// <summary>Initializes a new instance of the LoggingActivity class for the specified LoggingChannel and LoggingLevel in Windows 8.1 compatibility mode.</summary>
    /// <param name="activityName">The name of the logging activity.</param>
    /// <param name="loggingChannel">The logging channel.</param>
    /// <param name="level">The logging level.</param>
    [MethodImpl]
    public extern LoggingActivity(
      string activityName,
      ILoggingChannel loggingChannel,
      LoggingLevel level);

    /// <summary>Gets the name of the current logging activity.</summary>
    /// <returns>The name.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the identifier for the current logging activity.</summary>
    /// <returns>The identifier.</returns>
    public extern Guid Id { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    /// <summary>Returns the channel associated with this activity.</summary>
    /// <returns>The channel associated with this activity.</returns>
    public extern LoggingChannel Channel { [MethodImpl] get; }

    /// <summary>Marks the activity as closed/disposed and generates a stop event with the specified event name.</summary>
    /// <param name="stopEventName">The name for the stop event.</param>
    [Overload("StopActivity")]
    [MethodImpl]
    public extern void StopActivity(string stopEventName);

    /// <summary>Marks the activity as closed/disposed and generates a stop event with the specified event name and fields.</summary>
    /// <param name="stopEventName">The name for this event.</param>
    /// <param name="fields">The fields for this event. May be **null**.</param>
    [Overload("StopActivityWithFields")]
    [MethodImpl]
    public extern void StopActivity(string stopEventName, LoggingFields fields);

    /// <summary>Marks the activity as closed/disposed and generates a stop event with the specified event name, fields, and options.</summary>
    /// <param name="stopEventName">The name for the stop event.</param>
    /// <param name="fields">The fields for this event. May be **null**.</param>
    /// <param name="options">The options for this event. Pass **null** to use the default options. The options are for advanced scenarios. The default values are designed to work well for most events.</param>
    [Overload("StopActivityWithFieldsAndOptions")]
    [MethodImpl]
    public extern void StopActivity(
      string stopEventName,
      LoggingFields fields,
      LoggingOptions options);

    /// <summary>Indicates whether at least one session is listening for events from the channel associated with this activity.</summary>
    /// <returns>Returns **true** if at least one session is listening for events from the channel associated with this activity, and otherwise **false**.</returns>
    [Overload("IsEnabled")]
    [MethodImpl]
    public extern bool IsEnabled();

    /// <summary>Indicates whether at least one session is listening for events with the specified event severity level from the channel associated with this activity.</summary>
    /// <param name="level">The event severity level.</param>
    /// <returns>Returns **true** if at least one session is listening for events with the specified level from the channel associated with this activity, and otherwise **false**.</returns>
    [Overload("IsEnabledWithLevel")]
    [MethodImpl]
    public extern bool IsEnabled(LoggingLevel level);

    /// <summary>Indicates whether at least one session is listening for events with the specified level and keywords from the channel associated with this activity.</summary>
    /// <param name="level">The event severity level.</param>
    /// <param name="keywords">The keywords. Each bit of the keywords value represents an event category.</param>
    /// <returns>Returns **true** if at least one session is listening for events with the specified level and keywords from the channel associated with this activity, and otherwise **false**.</returns>
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
    /// <param name="level">The severity level for this event.</param>
    [Overload("LogEventWithFieldsAndLevel")]
    [MethodImpl]
    public extern void LogEvent(string eventName, LoggingFields fields, LoggingLevel level);

    /// <summary>Logs an event with the specified name, fields, level, and options.</summary>
    /// <param name="eventName">The name for this event.</param>
    /// <param name="fields">The fields for this event. May be **null**.</param>
    /// <param name="level">The severity level for this event.</param>
    /// <param name="options">The options for this event. Pass **null** to use the default options. The options are for advanced scenarios. The default values are designed to work well for most events.</param>
    [Overload("LogEventWithFieldsAndOptions")]
    [MethodImpl]
    public extern void LogEvent(
      string eventName,
      LoggingFields fields,
      LoggingLevel level,
      LoggingOptions options);

    /// <summary>Writes an activity start event and creates a **LoggingActivity** object.</summary>
    /// <param name="startEventName">The name for the start event.</param>
    /// <returns>An object the represents the new activity.</returns>
    [Overload("StartActivity")]
    [MethodImpl]
    public extern LoggingActivity StartActivity(string startEventName);

    /// <summary>Writes an activity start event with fields and creates a **LoggingActivity** object.</summary>
    /// <param name="startEventName">The name for the start event.</param>
    /// <param name="fields">The fields for this event.</param>
    /// <returns>An object that represents the new activity.</returns>
    [Overload("StartActivityWithFields")]
    [MethodImpl]
    public extern LoggingActivity StartActivity(
      string startEventName,
      LoggingFields fields);

    /// <summary>Writes an activity start event with the specified fields and level and creates a **LoggingActivity** object.</summary>
    /// <param name="startEventName">The name for the start event.</param>
    /// <param name="fields">The fields for this event. May be **null **.</param>
    /// <param name="level">The level of detail for this event.</param>
    /// <returns>An object that represents the new activity.</returns>
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
    /// <returns>An object that represents the new activity.</returns>
    [Overload("StartActivityWithFieldsAndOptions")]
    [MethodImpl]
    public extern LoggingActivity StartActivity(
      string startEventName,
      LoggingFields fields,
      LoggingLevel level,
      LoggingOptions options);
  }
}
