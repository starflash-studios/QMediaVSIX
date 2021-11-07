// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.ApplicationModel.Appointments
{
  [Guid(2757857676, 31303, 19862, 150, 201, 21, 205, 138, 5, 167, 53)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppointmentStore))]
  internal interface IAppointmentStore
  {
    AppointmentStoreChangeTracker ChangeTracker { get; }

    [RemoteAsync]
    IAsyncOperation<AppointmentCalendar> CreateAppointmentCalendarAsync(
      string name);

    [RemoteAsync]
    IAsyncOperation<AppointmentCalendar> GetAppointmentCalendarAsync(
      string calendarId);

    [RemoteAsync]
    IAsyncOperation<Appointment> GetAppointmentAsync(string localId);

    [RemoteAsync]
    IAsyncOperation<Appointment> GetAppointmentInstanceAsync(
      string localId,
      DateTime instanceStartTime);

    [Overload("FindAppointmentCalendarsAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<AppointmentCalendar>> FindAppointmentCalendarsAsync();

    [Overload("FindAppointmentCalendarsAsyncWithOptions")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<AppointmentCalendar>> FindAppointmentCalendarsAsync(
      FindAppointmentCalendarsOptions options);

    [Overload("FindAppointmentsAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<Appointment>> FindAppointmentsAsync(
      DateTime rangeStart,
      TimeSpan rangeLength);

    [Overload("FindAppointmentsAsyncWithOptions")]
    IAsyncOperation<IVectorView<Appointment>> FindAppointmentsAsync(
      DateTime rangeStart,
      TimeSpan rangeLength,
      FindAppointmentsOptions options);

    [Overload("FindConflictAsync")]
    IAsyncOperation<AppointmentConflictResult> FindConflictAsync(
      Appointment appointment);

    [Overload("FindConflictAsyncWithInstanceStart")]
    IAsyncOperation<AppointmentConflictResult> FindConflictAsync(
      Appointment appointment,
      DateTime instanceStartTime);

    IAsyncAction MoveAppointmentAsync(
      Appointment appointment,
      AppointmentCalendar destinationCalendar);

    IAsyncOperation<string> ShowAddAppointmentAsync(
      Appointment appointment,
      Rect selection);

    [Overload("ShowReplaceAppointmentAsync")]
    IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string localId,
      Appointment appointment,
      Rect selection);

    [Overload("ShowReplaceAppointmentWithPlacementAndDateAsync")]
    IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string localId,
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement,
      DateTime instanceStartDate);

    [Overload("ShowRemoveAppointmentAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> ShowRemoveAppointmentAsync(string localId, Rect selection);

    [RemoteAsync]
    [Overload("ShowRemoveAppointmentWithPlacementAndDateAsync")]
    IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string localId,
      Rect selection,
      Placement preferredPlacement,
      DateTime instanceStartDate);

    [Overload("ShowAppointmentDetailsAsync")]
    [RemoteAsync]
    IAsyncAction ShowAppointmentDetailsAsync(string localId);

    [RemoteAsync]
    [Overload("ShowAppointmentDetailsWithDateAsync")]
    IAsyncAction ShowAppointmentDetailsAsync(string localId, DateTime instanceStartDate);

    IAsyncOperation<string> ShowEditNewAppointmentAsync(Appointment appointment);

    [RemoteAsync]
    IAsyncOperation<IVectorView<string>> FindLocalIdsFromRoamingIdAsync(
      string roamingId);
  }
}
