// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.UserDataTaskRecurrenceProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  /// <summary>Represents when and how often a task occurs.</summary>
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  public sealed class UserDataTaskRecurrenceProperties : IUserDataTaskRecurrenceProperties
  {
    /// <summary>Initializes a new instance of the UserDataTaskRecurrenceProperties class.</summary>
    [MethodImpl]
    public extern UserDataTaskRecurrenceProperties();

    /// <summary>Gets or sets a UserDataTaskRecurrenceUnit -typed value that indicates the frequency for which the task occurs.</summary>
    /// <returns>A UserDataTaskRecurrenceUnit -typed value that indicates the frequency for which the task occurs.</returns>
    public extern UserDataTaskRecurrenceUnit Unit { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the number of times a task recurs. Occurrences is of type IReference(UInt32) and is **NULL** by default. Occurrences is mutually exclusive with Until.</summary>
    /// <returns>The number of times a task recurs.</returns>
    public extern IReference<int> Occurrences { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the date and time until which a task is valid. Until is of type IReference(DateTime) and is **NULL** by default. Until is mutually exclusive with Occurrences.</summary>
    /// <returns>The date and time until which a task is valid.</returns>
    public extern IReference<DateTime> Until { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the interval between occurrences of a task. Interval is of type UInt32 and has a default value of 1. For daily, the interval is the number of days in between, for weekly, the number of weeks, and so on.</summary>
    /// <returns>The interval on which a task occurs.</returns>
    public extern int Interval { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a combination of UserDataTaskDaysOfWeek -typed values for all the days of the week on which a task occurs.</summary>
    /// <returns>A combination of UserDataTaskDaysOfWeek -typed values that are combined by using a bitwise OR operation. The resulting value specifies all the days of the week on which a task occurs.</returns>
    public extern IReference<UserDataTaskDaysOfWeek> DaysOfWeek { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a UserDataTaskWeekOfMonth -typed value that indicates the week of the month for which the task occurs. The first week is the default.</summary>
    /// <returns>
    /// </returns>
    public extern IReference<UserDataTaskWeekOfMonth> WeekOfMonth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the month on which a task occurs. Month is of type UInt32, has a default value of 1, and can be a value from 1 to 12.</summary>
    /// <returns>The month on which a task occurs.</returns>
    public extern IReference<int> Month { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the day on which a task occurs. Day is of type UInt32, has a default value of 1, and can be a value from 1 to 31.</summary>
    /// <returns>The day on which an appointment occurs.</returns>
    public extern IReference<int> Day { [MethodImpl] get; [MethodImpl] set; }
  }
}
