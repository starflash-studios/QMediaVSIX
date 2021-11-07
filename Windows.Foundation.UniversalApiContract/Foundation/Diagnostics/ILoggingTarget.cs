// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingTarget
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  /// <summary>Logs events.</summary>
  [Guid(1710320693, 58248, 20006, 177, 122, 245, 28, 211, 168, 57, 22)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ILoggingTarget
  {
    /// <summary>Indicates whether at least one session is listening for events from the channel.</summary>
    /// <returns>Returns **true** if at least one session is listening for events from the channel, and otherwise **false**.</returns>
    [Overload("IsEnabled")]
    bool IsEnabled();

    /// <summary>Indicates whether at least one session is listening for events with the specified event severity level from the channel.</summary>
    /// <param name="level">The event severity level.</param>
    /// <returns>Returns **true** if at least one session is listening for events with the specified level from the channel, and otherwise **false**.</returns>
    [Overload("IsEnabledWithLevel")]
    bool IsEnabled(LoggingLevel level);

    /// <summary>Indicates whether at least one session is listening for events with the specified level and keywords from this channel.</summary>
    /// <param name="level">The event severity level.</param>
    /// <param name="keywords">The keywords. Each bit of the keywords value represents an event category.</param>
    /// <returns>Returns **true** if at least one session is listening for events with the specified level and keywords from the channel, and otherwise **false**.</returns>
    [Overload("IsEnabledWithLevelAndKeywords")]
    bool IsEnabled(LoggingLevel level, long keywords);

    /// <summary>Logs an event with the specified name.</summary>
    /// <param name="eventName">The name for this event.</param>
    [Overload("LogEvent")]
    void LogEvent(string eventName);

    /// <summary>Logs an event with the specified name and fields.</summary>
    /// <param name="eventName">The name for this event.</param>
    /// <param name="fields">The fields for this event. May be **null**.</param>
    [Overload("LogEventWithFields")]
    void LogEvent(string eventName, LoggingFields fields);

    /// <summary>Logs an event with the specified name, fields, and level.</summary>
    /// <param name="eventName">The name for this event.</param>
    /// <param name="fields">The fields for this event. May be **null**.</param>
    /// <param name="level">The level of detail for this event.</param>
    [Overload("LogEventWithFieldsAndLevel")]
    void LogEvent(string eventName, LoggingFields fields, LoggingLevel level);

    /// <summary>Logs an event with the specified name, fields, level, and options.</summary>
    /// <param name="eventName">The name for this event.</param>
    /// <param name="fields">The fields for this event. May be **null**.</param>
    /// <param name="level">The level of detail for this event.</param>
    /// <param name="options">The options for this event. Pass **null** to use the default options. The options are for advanced scenarios. The default values are designed to work well for most events.</param>
    [Overload("LogEventWithFieldsAndOptions")]
    void LogEvent(
      string eventName,
      LoggingFields fields,
      LoggingLevel level,
      LoggingOptions options);

    /// <summary>Writes an activity start event and creates a **LoggingActivity** object.</summary>
    /// <param name="startEventName">The name for this event.</param>
    /// <returns>An object that represents the new activity.</returns>
    [Overload("StartActivity")]
    LoggingActivity StartActivity(string startEventName);

    /// <summary>Writes an activity start event with fields and creates a **LoggingActivity** object.</summary>
    /// <param name="startEventName">The name for this event.</param>
    /// <param name="fields">The fields for this event.</param>
    /// <returns>An object that represents the new activity.</returns>
    [Overload("StartActivityWithFields")]
    LoggingActivity StartActivity(string startEventName, LoggingFields fields);

    /// <summary>Writes an activity start event with the specified fields and level and creates a **LoggingActivity** object.</summary>
    /// <param name="startEventName">The name for this event.</param>
    /// <param name="fields">The fields for this event. May be **null **.</param>
    /// <param name="level">The level of detail for this event.</param>
    /// <returns>An object that represents the new activity.</returns>
    [Overload("StartActivityWithFieldsAndLevel")]
    LoggingActivity StartActivity(
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
    LoggingActivity StartActivity(
      string startEventName,
      LoggingFields fields,
      LoggingLevel level,
      LoggingOptions options);
  }
}
