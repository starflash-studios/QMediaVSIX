// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentCalendar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Represents a calendar with appointments.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AppointmentCalendar : 
    IAppointmentCalendar,
    IAppointmentCalendar2,
    IAppointmentCalendar3
  {
    /// <summary>Gets the color that the built-in calendar app uses for appointments associated with the calendar.</summary>
    /// <returns>An unsigned integer representing the color that the built-in calendar app uses for appointments associated with the calendar.</returns>
    public extern Color DisplayColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a string representing the display name for the AppointmentCalendar.</summary>
    /// <returns>A string representing the display name for the AppointmentCalendar.</returns>
    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a string that uniquely identifies the appointment calendar on the local device.</summary>
    /// <returns>A string that uniquely identifies the appointment calendar on the local device.</returns>
    public extern string LocalId { [MethodImpl] get; }

    /// <summary>Gets whether the AppointmentCalendar is hidden in the device's built-in calendar UI.</summary>
    /// <returns>A boolean value indicating whether the AppointmentCalendar is hidden in the device's built-in calendar UI.</returns>
    public extern bool IsHidden { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a boolean value indicating whether other apps on the device have read access to the appointment calendar.</summary>
    /// <returns>A boolean value indicating whether other apps on the device have read access to the appointment calendar.</returns>
    public extern AppointmentCalendarOtherAppReadAccess OtherAppReadAccess { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a boolean value indicating whether other apps on the device have write access to the appointment calendar.</summary>
    /// <returns>A boolean value indicating whether other apps on the device have write access to the appointment calendar.</returns>
    public extern AppointmentCalendarOtherAppWriteAccess OtherAppWriteAccess { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a string that describes the provider for the appointment calendar.</summary>
    /// <returns>A string that describes the provider for the appointment calendar.</returns>
    public extern string SourceDisplayName { [MethodImpl] get; }

    /// <summary>Gets or sets how the summary card for the calendar's appointments are displayed.</summary>
    /// <returns>An AppointmentSummaryCardView value indicating how the summary card for the calendar's appointments are displayed.</returns>
    public extern AppointmentSummaryCardView SummaryCardView { [MethodImpl] get; [MethodImpl] set; }

    [RemoteAsync]
    [Overload("FindAppointmentsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<Appointment>> FindAppointmentsAsync(
      DateTime rangeStart,
      TimeSpan rangeLength);

    [Overload("FindAppointmentsAsyncWithOptions")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<Appointment>> FindAppointmentsAsync(
      DateTime rangeStart,
      TimeSpan rangeLength,
      FindAppointmentsOptions options);

    /// <summary>Asynchronously retrieves a list of appointment instances that are exceptions from the specified master appointment.</summary>
    /// <param name="masterLocalId">The LocalId of the master appointment for which exceptional appointment instances are retrieved.</param>
    /// <returns>An asynchronous operation that returns IVectorView on successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppointmentException>> FindExceptionsFromMasterAsync(
      string masterLocalId);

    [RemoteAsync]
    [Overload("FindAllInstancesAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<Appointment>> FindAllInstancesAsync(
      string masterLocalId,
      DateTime rangeStart,
      TimeSpan rangeLength);

    [Overload("FindAllInstancesAsyncWithOptions")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<Appointment>> FindAllInstancesAsync(
      string masterLocalId,
      DateTime rangeStart,
      TimeSpan rangeLength,
      FindAppointmentsOptions pOptions);

    /// <summary>Asynchronously retrieves the Appointment with the specified ID.</summary>
    /// <param name="localId">The LocalId of the appointment to be retrieved.</param>
    /// <returns>An asynchronous operation that returns Appointment on successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Appointment> GetAppointmentAsync(
      string localId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Appointment> GetAppointmentInstanceAsync(
      string localId,
      DateTime instanceStartTime);

    /// <summary>Asynchronously retrieves a list of appointments that meet the specified criteria.</summary>
    /// <returns>An asynchronous operation that returns IVectorView on successful completion.</returns>
    [Overload("FindUnexpandedAppointmentsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<Appointment>> FindUnexpandedAppointmentsAsync();

    /// <summary>Asynchronously retrieves a list of appointments that meet the specified criteria.</summary>
    /// <param name="options">A FindAppointmentsOptions object that is used to specify more options for this operation.</param>
    /// <returns>An asynchronous operation that returns IVectorView on successful completion.</returns>
    [Overload("FindUnexpandedAppointmentsAsyncWithOptions")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<Appointment>> FindUnexpandedAppointmentsAsync(
      FindAppointmentsOptions options);

    /// <summary>Asynchronously deletes the appointment calendar.</summary>
    /// <returns>An asynchrounous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    /// <summary>Asynchronously saves changes to the appointment calendar.</summary>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveAsync();

    /// <summary>Asynchronously deletes the appointment with the specified ID.</summary>
    /// <param name="localId">The LocalId of the appointment to be deleted.</param>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAppointmentAsync(string localId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAppointmentInstanceAsync(
      string localId,
      DateTime instanceStartTime);

    /// <summary>Asynchronously saves the provided appointment to the calendar.</summary>
    /// <param name="pAppointment">The appointment to be saved.</param>
    /// <returns>An asynchronous action.</returns>
    [MethodImpl]
    public extern IAsyncAction SaveAppointmentAsync(Appointment pAppointment);

    /// <summary>Gets the AppointmentCalendarSyncManager which can be used to sync with the remote server.</summary>
    /// <returns>The AppointmentCalendarSyncManager which can be used to sync with the remote server.</returns>
    public extern AppointmentCalendarSyncManager SyncManager { [MethodImpl] get; }

    /// <summary>Gets the remote ID for the AppointmentCalendar.</summary>
    /// <returns>The remote ID for the AppointmentCalendar.</returns>
    public extern string RemoteId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get the identifier of the user account data for the AppointmentCalendar.</summary>
    /// <returns>The identifier of the user account data for the AppointmentCalendar.</returns>
    public extern string UserDataAccountId { [MethodImpl] get; }

    /// <summary>Gets or sets a Boolean value that indicates if the calendar supports creating or updating appointments.</summary>
    /// <returns>Boolean value that indicates if the calendar supports creating or updating appointments.</returns>
    public extern bool CanCreateOrUpdateAppointments { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates if the calendar supports cancelling meetings.</summary>
    /// <returns>Boolean value that indicates if the calendar supports cancelling meetings.</returns>
    public extern bool CanCancelMeetings { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates if the calendar supports forwarding meetings.</summary>
    /// <returns>Boolean value that indicates if the calendar supports forwarding meetings.</returns>
    public extern bool CanForwardMeetings { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates if the calendar supports proposing new meeting times.</summary>
    /// <returns>Boolean value that indicates if the calendar supports proposing new meeting times.</returns>
    public extern bool CanProposeNewTimeForMeetings { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates if the calendar supports updating meeting responses.</summary>
    /// <returns>Boolean value that indicates if the calendar supports updating meeting responses.</returns>
    public extern bool CanUpdateMeetingResponses { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates if the calendar supports notifying attendees.</summary>
    /// <returns>Boolean value that indicates if the calendar supports notifying attendees.</returns>
    public extern bool CanNotifyInvitees { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates if invitees must be sent notifications.</summary>
    /// <returns>A Boolean value that indicates if invitees must be sent notifications.</returns>
    public extern bool MustNofityInvitees { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Asynchronously attempts to create or update a meeting.</summary>
    /// <param name="appointment">The meeting to create or update.</param>
    /// <param name="notifyInvitees">A Boolean value indicating if invitees should be notified.</param>
    /// <returns>A Boolean value indicating if the operation was successful.</returns>
    [MethodImpl]
    public extern IAsyncOperation<bool> TryCreateOrUpdateAppointmentAsync(
      Appointment appointment,
      bool notifyInvitees);

    /// <summary>Asynchronously attempts to cancel a meeting.</summary>
    /// <param name="meeting">The meeting to cancel.</param>
    /// <param name="subject">The subject for the cancellation notification.</param>
    /// <param name="comment">The body of the cancellation notification.</param>
    /// <param name="notifyInvitees">A Boolean value indicating if invitees should be notified.</param>
    /// <returns>A Boolean value indicating if the operation was successful.</returns>
    [MethodImpl]
    public extern IAsyncOperation<bool> TryCancelMeetingAsync(
      Appointment meeting,
      string subject,
      string comment,
      bool notifyInvitees);

    [MethodImpl]
    public extern IAsyncOperation<bool> TryForwardMeetingAsync(
      Appointment meeting,
      IIterable<AppointmentInvitee> invitees,
      string subject,
      string forwardHeader,
      string comment);

    [MethodImpl]
    public extern IAsyncOperation<bool> TryProposeNewTimeForMeetingAsync(
      Appointment meeting,
      DateTime newStartTime,
      TimeSpan newDuration,
      string subject,
      string comment);

    /// <summary>Asynchronously attempts to update the response to a meeting invitation.</summary>
    /// <param name="meeting">The meeting to update.</param>
    /// <param name="response">The response to the meeting invitation, such as accept, tentative or decline.</param>
    /// <param name="subject">The subject of the response.</param>
    /// <param name="comment">The body of the response.</param>
    /// <param name="sendUpdate">A Boolean value indicating whether or not to send the response to the meeting organizer.</param>
    /// <returns>A Boolean value indicating if the operation was successful.</returns>
    [MethodImpl]
    public extern IAsyncOperation<bool> TryUpdateMeetingResponseAsync(
      Appointment meeting,
      AppointmentParticipantResponse response,
      string subject,
      string comment,
      bool sendUpdate);

    /// <summary>Registers the AppointmentCalendar as a sync provider.</summary>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RegisterSyncManagerAsync();
  }
}
