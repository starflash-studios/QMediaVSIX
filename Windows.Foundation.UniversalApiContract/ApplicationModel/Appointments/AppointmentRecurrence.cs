// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentRecurrence
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Represents when and how often an appointment occurs.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppointmentRecurrence : 
    IAppointmentRecurrence,
    IAppointmentRecurrence2,
    IAppointmentRecurrence3
  {
    /// <summary>Initializes a new instance of the AppointmentRecurrence class.</summary>
    [MethodImpl]
    public extern AppointmentRecurrence();

    /// <summary>Gets or sets a AppointmentRecurrenceUnit -typed value that indicates the frequency for which the appointment occurs.</summary>
    /// <returns>A AppointmentRecurrenceUnit -typed value that indicates the frequency for which the appointment occurs.</returns>
    public extern AppointmentRecurrenceUnit Unit { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the number of times an appointment recurs. Occurrences is of type IReference(UInt32) and is **NULL** by default. Occurrences is mutually exclusive with Until.</summary>
    /// <returns>The number of times an appointment recurs.</returns>
    public extern IReference<uint> Occurrences { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the date and time until which an appointment is valid. Until is of type IReference(DateTime) and is **NULL** by default. Until is mutually exclusive with Occurrences.</summary>
    /// <returns>The date and time until which an appointment is valid.</returns>
    public extern IReference<DateTime> Until { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the interval between occurrences of an appointment. Interval is of type UInt32 and has a default value of 1. For daily, the interval is the number of days in between, for weekly, the number of weeks, and so on.</summary>
    /// <returns>The interval on which an appointment occurs.</returns>
    public extern uint Interval { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a combination of AppointmentDaysOfWeek -typed values for all the days of the week on which an appointment occurs.</summary>
    /// <returns>A combination of AppointmentDaysOfWeek -typed values that are combined by using a bitwise OR operation. The resulting value specifies all the days of the week on which an appointment occurs.</returns>
    public extern AppointmentDaysOfWeek DaysOfWeek { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a AppointmentWeekOfMonth -typed value that indicates the week of the month for which the appointment occurs. The first week is the default.</summary>
    /// <returns>A AppointmentWeekOfMonth -typed value that indicates the week of the month for which the appointment occurs.</returns>
    public extern AppointmentWeekOfMonth WeekOfMonth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the month on which an appointment occurs. Month is of type UInt32, has a default value of 1, and can be a value from 1 to 12.</summary>
    /// <returns>The month on which an appointment occurs.</returns>
    public extern uint Month { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the day on which an appointment occurs. Day is of type UInt32, has a default value of 1, and can be a value from 1 to 31.</summary>
    /// <returns>The day on which an appointment occurs.</returns>
    public extern uint Day { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value indicating what type of recurrence applies to the associated appointment.</summary>
    /// <returns>A value indicating what type of recurrence applies to the associated appointment.</returns>
    public extern RecurrenceType RecurrenceType { [MethodImpl] get; }

    /// <summary>Gets or sets the time zone for the recurrence.</summary>
    /// <returns>The time zone for the recurrence.</returns>
    public extern string TimeZone { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a string that identifies the type of the calendar as represented by CalendarIdentifiers.</summary>
    /// <returns>A string that identifies the type of the calendar.</returns>
    public extern string CalendarIdentifier { [MethodImpl] get; }
  }
}
