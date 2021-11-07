// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.Appointment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Represents an appointment in a calendar. This class is used when an app is activated using the **AppointmentsProvider** value for ActivationKind, as a value for AppointmentInformation properties.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Appointment : IAppointment, IAppointment2, IAppointment3
  {
    /// <summary>Initializes a new instance of the Appointment class.</summary>
    [MethodImpl]
    public extern Appointment();

    /// <summary>Gets or sets the starting time for the appointment. StartTime is of type DateTime.</summary>
    /// <returns>The date and time to use as the starting time for the appointment.</returns>
    public extern DateTime StartTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a time span that represents the time duration of the appointment. Duration is of type TimeSpan and must be non-negative.</summary>
    /// <returns>A time span that represents the duration of the appointment. The duration can't be a negative value.</returns>
    public extern TimeSpan Duration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a string that communicates the physical location of the appointment. Location is of type String and a maximum of 32,768 characters in length.</summary>
    /// <returns>The location of the appointment.</returns>
    public extern string Location { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a string that communicates the subject of the appointment. Subject is of type String and a maximum of 255 characters in length.</summary>
    /// <returns>The subject of the appointment.</returns>
    public extern string Subject { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a string value. The string contains extended details that describe the appointment. Details is of type String and a maximum of 1,073,741,823 characters in length, which is the maximum length of a JET database string.</summary>
    /// <returns>The extended details that describe the appointment.</returns>
    public extern string Details { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a time span value. The value declares the amount of time to subtract from the StartTime, and that time used as the issue time for a reminder for an appointment. A **null** value indicates that the appointment will not issue a reminder. Reminder is of type IReference(TimeSpan).</summary>
    /// <returns>A time span value, or **null** to issue no reminder.</returns>
    public extern IReference<TimeSpan> Reminder { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the organizer of the appointment. Organizer is of type AppointmentOrganizer. If an organizer is set and invitee length is greater than 0, a call to an AppointmentManager API fails with **E_INVALIDARG**. The number of invitees is unlimited.</summary>
    /// <returns>A AppointmentOrganizer object that indicates the organizer of the appointment.</returns>
    public extern AppointmentOrganizer Organizer { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the list of participants for the appointment. Invitees is of type IVector(AppointmentInvitee). If an organizer is set and invitee length is greater than 0, a call to an AppointmentManager API fails with **E_INVALIDARG**. The number of invitees is unlimited.</summary>
    /// <returns>The list of participants for the appointment.</returns>
    public extern IVector<AppointmentInvitee> Invitees { [MethodImpl] get; }

    /// <summary>Gets or sets the object that describes when and how often the appointment occurs. Recurrence is of type AppointmentRecurrence.</summary>
    /// <returns>A AppointmentRecurrence object that describes when and how often the appointment occurs.</returns>
    public extern AppointmentRecurrence Recurrence { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a AppointmentBusyStatus -typed value that indicates the busy status for a participant of an appointment.</summary>
    /// <returns>A AppointmentBusyStatus -typed value that indicates the busy status for a participant of an appointment.</returns>
    public extern AppointmentBusyStatus BusyStatus { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates whether the appointment will last all day. The default is **FALSE** for won't last all day.</summary>
    /// <returns>A Boolean value that indicates whether the appointment will last all day. **TRUE** indicates that the appointment will last all day; otherwise **FALSE**.</returns>
    public extern bool AllDay { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a AppointmentSensitivity -typed value that indicates the sensitivity of the appointment.</summary>
    /// <returns>A AppointmentSensitivity -typed value that indicates the sensitivity of the appointment.</returns>
    public extern AppointmentSensitivity Sensitivity { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the Uniform Resource Identifier (Uri ) for the appointment. Allows the Calendar app to perform an association launch to go back to the source app or other URI that represents this appointment.</summary>
    /// <returns>The URI for the appointment.</returns>
    public extern Uri Uri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a string that uniquely identifies the appointment on the local device.</summary>
    /// <returns>A string that uniquely identifies the appointment on the local device.</returns>
    public extern string LocalId { [MethodImpl] get; }

    /// <summary>Gets the unique identifier for the calendar associated with the appointment.</summary>
    /// <returns>The unique identifier for the calendar associated with the appointment.</returns>
    public extern string CalendarId { [MethodImpl] get; }

    /// <summary>Gets or sets a string that uniquely identifies an appointment across devices.</summary>
    /// <returns>A string that uniquely identifies an appointment across devices.</returns>
    public extern string RoamingId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the original starting time for a recurring appointment.</summary>
    /// <returns>The original starting time for a recurring appointment..</returns>
    public extern IReference<DateTime> OriginalStartTime { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether a response to the appointment invitation is requested.</summary>
    /// <returns>A Boolean value that indicates whether a response is requested. **TRUE** indicates that a response is requested; otherwise **FALSE**.</returns>
    public extern bool IsResponseRequested { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the appointment will allow users to propose a new time.</summary>
    /// <returns>A Boolean value that indicates whether the appointment will allow users to propose a new time. **TRUE** indicates that the appointment does allow new time proposal; otherwise **FALSE**.</returns>
    public extern bool AllowNewTimeProposal { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a string value that is a URL used to join the online meeting for the appointment.</summary>
    /// <returns>A string value that is a URL used to join the online meeting for the appointment.</returns>
    public extern string OnlineMeetingLink { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the date and time that the user responded to the appointment request.</summary>
    /// <returns>The date and time that the user responded to the appointment request.</returns>
    public extern IReference<DateTime> ReplyTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the user's response to the appointment request.</summary>
    /// <returns>The user's response to the appointment request.</returns>
    public extern AppointmentParticipantResponse UserResponse { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the appointment has invitees.</summary>
    /// <returns>A value that indicates whether the appointment has invitees.</returns>
    public extern bool HasInvitees { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether the appointment has been cancelled.</summary>
    /// <returns>A Boolean value that indicates whether the appointment has been cancelled. **TRUE** indicates that the appointment has been cancelled; otherwise **FALSE**.</returns>
    public extern bool IsCanceledMeeting { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the appointment was organized by the current user.</summary>
    /// <returns>A Boolean value that indicates whether the appointment was organized by the current user **TRUE** indicates that the appointment was organized by the user; otherwise **FALSE**.</returns>
    public extern bool IsOrganizedByUser { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the current change number of the local version of the Appointment.</summary>
    /// <returns>The current change number of the local version of the Appointment.</returns>
    public extern ulong ChangeNumber { [MethodImpl] get; }

    /// <summary>Gets or sets the current change number of the server version of the Appointment.</summary>
    /// <returns>The current change number of the server version of the Appointment.</returns>
    public extern ulong RemoteChangeNumber { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the type of appointment details, plain text or HTML.</summary>
    /// <returns>The type of appointment details.</returns>
    public extern AppointmentDetailsKind DetailsKind { [MethodImpl] get; [MethodImpl] set; }
  }
}
