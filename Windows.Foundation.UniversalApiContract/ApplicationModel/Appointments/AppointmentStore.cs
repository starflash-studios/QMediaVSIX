// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Represents a store that contains appointments.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppointmentStore : IAppointmentStore, IAppointmentStore2, IAppointmentStore3
  {
    /// <summary>Returns the AppointmentStoreChangeTracker associated with the appointment store.</summary>
    /// <returns>The AppointmentStoreChangeTracker associated with the appointment store.</returns>
    public extern AppointmentStoreChangeTracker ChangeTracker { [MethodImpl] get; }

    /// <summary>Asynchronously creates a new AppointmentCalendar within the appointment store using the specified parameters.</summary>
    /// <param name="name">The name for the new AppointmentCalendar.</param>
    /// <returns>An async operation that provides access to the newly created AppointmentCalendar.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppointmentCalendar> CreateAppointmentCalendarAsync(
      string name);

    /// <summary>Retrieves the AppointmentCalendar with the specified LocalId.</summary>
    /// <param name="calendarId">The LocalId of the AppointmentCalendar to be retrieved.</param>
    /// <returns>An asynchronous operation that returns an AppointmentCalendar upon successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppointmentCalendar> GetAppointmentCalendarAsync(
      string calendarId);

    /// <summary>Retrieves the Appointment with the specified LocalId.</summary>
    /// <param name="localId">The LocalId of the appointment to be retrieved.</param>
    /// <returns>An asynchronous operation that returns an Appointment upon successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Appointment> GetAppointmentAsync(
      string localId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Appointment> GetAppointmentInstanceAsync(
      string localId,
      DateTime instanceStartTime);

    /// <summary>Retrieves a list of all of the appointment calendars in the appointment store.</summary>
    /// <returns>An asynchronous operation that returns an IVectorView upon successful completion.</returns>
    [RemoteAsync]
    [Overload("FindAppointmentCalendarsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppointmentCalendar>> FindAppointmentCalendarsAsync();

    /// <summary>Retrieves a list of appointment calendars in the appointment store that meet the criteria specified by the supplied FindAppointmentCalendarsOptions object..</summary>
    /// <param name="options">The object that specifies the criteria that determines which appointment calendars are returned.</param>
    /// <returns>An asynchronous operation that returns an IVectorView upon successful completion.</returns>
    [RemoteAsync]
    [Overload("FindAppointmentCalendarsAsyncWithOptions")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppointmentCalendar>> FindAppointmentCalendarsAsync(
      FindAppointmentCalendarsOptions options);

    [Overload("FindAppointmentsAsync")]
    [RemoteAsync]
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

    /// <summary>Returns an AppointmentConflictResult representing a conflict between the specified appointment and an existing appointment in the appointment store.</summary>
    /// <param name="appointment">The appointment for which a conflict is sought.</param>
    /// <returns>An asynchronous operation that returns an AppointmentConflictResult upon successful completion. For conflicts that are in the past, the returned AppointmentConflictResult object will have a Type of AppointmentConflictType.None.</returns>
    [Overload("FindConflictAsync")]
    [MethodImpl]
    public extern IAsyncOperation<AppointmentConflictResult> FindConflictAsync(
      Appointment appointment);

    [Overload("FindConflictAsyncWithInstanceStart")]
    [MethodImpl]
    public extern IAsyncOperation<AppointmentConflictResult> FindConflictAsync(
      Appointment appointment,
      DateTime instanceStartTime);

    /// <summary>Moves the specified Appointment object to the specified AppointmentCalendar.</summary>
    /// <param name="appointment">The appointment to be moved.</param>
    /// <param name="destinationCalendar">The appointment calendar to which the appointment is moved.</param>
    /// <returns>An asynchronous action.</returns>
    [MethodImpl]
    public extern IAsyncAction MoveAppointmentAsync(
      Appointment appointment,
      AppointmentCalendar destinationCalendar);

    /// <summary>Shows the Appointments provider Add Appointment UI, to enable the user to add an appointment.</summary>
    /// <param name="appointment">The object representing the information for the appointment to add.</param>
    /// <param name="selection">The Rect is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the Add Appointment UI, not within that rectangular area. For example, if an app uses a button to show the Rect, pass the Rect of the button so the Add Appointment UI displays around the button, not overlapping it.</param>
    /// <returns>When this method completes, it returns a **String** object that represents the RoamingId of the appointment. If the appointment identifier returned is an empty string, the appointment was not added to the Appointments provider app.</returns>
    [MethodImpl]
    public extern IAsyncOperation<string> ShowAddAppointmentAsync(
      Appointment appointment,
      Rect selection);

    /// <summary>Shows the Appointments provider Replace Appointment UI, to enable the user to replace an appointment.</summary>
    /// <param name="localId">The LocalId of the appointment to be replaced.</param>
    /// <param name="appointment">The object representing the appointment to replace the existing appointment.</param>
    /// <param name="selection">The Rect is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the Replace Appointment UI, not within that rectangular area. For example, if an app uses a button to show the Rect, pass the Rect of the button so the Replace Appointment UI displays around the button, not overlapping it.</param>
    /// <returns>When this method completes, it returns a **String** object that represents the RoamingId of the appointment that replaced the existing appointment.</returns>
    [Overload("ShowReplaceAppointmentAsync")]
    [MethodImpl]
    public extern IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string localId,
      Appointment appointment,
      Rect selection);

    [Overload("ShowReplaceAppointmentWithPlacementAndDateAsync")]
    [MethodImpl]
    public extern IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string localId,
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement,
      DateTime instanceStartDate);

    /// <summary>Shows the Appointments provider Remove Appointment UI, to enable the user to remove an appointment.</summary>
    /// <param name="localId">The LocalId of the appointment to be removed.</param>
    /// <param name="selection">The Rect is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the Remove Appointment UI, not within that rectangular area. For example, if an app uses a button to show the Rect, pass the Rect of the button so the Remove Appointment UI displays around the button, not overlapping it.</param>
    /// <returns>When this method completes, it returns a **Boolean** value that indicates whether the Appointment provider app removed the appointment.</returns>
    [Overload("ShowRemoveAppointmentAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string localId,
      Rect selection);

    [RemoteAsync]
    [Overload("ShowRemoveAppointmentWithPlacementAndDateAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string localId,
      Rect selection,
      Placement preferredPlacement,
      DateTime instanceStartDate);

    /// <summary>Shows the Appointments provider Appointment Details UI, to enable the user to view the specified appointment.</summary>
    /// <param name="localId">The LocalId of the appointment to be displayed.</param>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [Overload("ShowAppointmentDetailsAsync")]
    [MethodImpl]
    public extern IAsyncAction ShowAppointmentDetailsAsync(string localId);

    [Overload("ShowAppointmentDetailsWithDateAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ShowAppointmentDetailsAsync(
      string localId,
      DateTime instanceStartDate);

    /// <summary>Shows the Appointments provider Add Appointment UI including the full edit experience, to enable the user to add an appointment.</summary>
    /// <param name="appointment">The appointment to be added.</param>
    /// <returns>When this method completes, it returns a **String** object that represents the RoamingId of the appointment. If the appointment identifier returned is an empty string, the appointment was not added to the Appointments provider app.</returns>
    [MethodImpl]
    public extern IAsyncOperation<string> ShowEditNewAppointmentAsync(
      Appointment appointment);

    /// <summary>Returns a list of LocalId values for appointment instances with the specified RoamingId value.</summary>
    /// <param name="roamingId">The RoamingId value for which local ID values are sought.</param>
    /// <returns>An asynchronous operation that returns an IVectorView upon successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> FindLocalIdsFromRoamingIdAsync(
      string roamingId);

    /// <summary>Occurs when the AppointmentStore changes.</summary>
    public extern event TypedEventHandler<AppointmentStore, AppointmentStoreChangedEventArgs> StoreChanged;

    /// <summary>Asynchronously creates a new AppointmentCalendar within the appointment store with the specified name and user data account ID.</summary>
    /// <param name="name">The name for the new AppointmentCalendar.</param>
    /// <param name="userDataAccountId">The identifier for the user data account used to create the AppointmentCalendar.</param>
    /// <returns>An async operation that provides access to the newly created AppointmentCalendar.</returns>
    [RemoteAsync]
    [Overload("CreateAppointmentCalendarInAccountAsync")]
    [MethodImpl]
    public extern IAsyncOperation<AppointmentCalendar> CreateAppointmentCalendarAsync(
      string name,
      string userDataAccountId);

    /// <summary>Gets a AppointmentStoreChangeTracker that provides functionality for monitoring changes to Appointment objects in the AppointmentStore.</summary>
    /// <param name="identity">A string that identifies the AppointmentStoreChangeTracker instance in the store.</param>
    /// <returns>A AppointmentStoreChangeTracker that provides functionality for monitoring changes to Appointment objects in the AppointmentStore.</returns>
    [MethodImpl]
    public extern AppointmentStoreChangeTracker GetChangeTracker(
      string identity);
  }
}
