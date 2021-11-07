// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentCalendar2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.ApplicationModel.Appointments
{
  [ExclusiveTo(typeof (AppointmentCalendar))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(417850402, 9319, 19996, 164, 89, 216, 162, 147, 3, 208, 146)]
  internal interface IAppointmentCalendar2 : IAppointmentCalendar
  {
    AppointmentCalendarSyncManager SyncManager { get; }

    string RemoteId { get; set; }

    new Color DisplayColor { set; }

    new bool IsHidden { set; }

    string UserDataAccountId { get; }

    bool CanCreateOrUpdateAppointments { get; set; }

    bool CanCancelMeetings { get; set; }

    bool CanForwardMeetings { get; set; }

    bool CanProposeNewTimeForMeetings { get; set; }

    bool CanUpdateMeetingResponses { get; set; }

    bool CanNotifyInvitees { get; set; }

    bool MustNofityInvitees { get; set; }

    IAsyncOperation<bool> TryCreateOrUpdateAppointmentAsync(
      Appointment appointment,
      bool notifyInvitees);

    IAsyncOperation<bool> TryCancelMeetingAsync(
      Appointment meeting,
      string subject,
      string comment,
      bool notifyInvitees);

    IAsyncOperation<bool> TryForwardMeetingAsync(
      Appointment meeting,
      IIterable<AppointmentInvitee> invitees,
      string subject,
      string forwardHeader,
      string comment);

    IAsyncOperation<bool> TryProposeNewTimeForMeetingAsync(
      Appointment meeting,
      DateTime newStartTime,
      TimeSpan newDuration,
      string subject,
      string comment);

    IAsyncOperation<bool> TryUpdateMeetingResponseAsync(
      Appointment meeting,
      AppointmentParticipantResponse response,
      string subject,
      string comment,
      bool sendUpdate);
  }
}
