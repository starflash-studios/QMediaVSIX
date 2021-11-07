// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [Guid(3707776815, 11229, 16502, 144, 163, 34, 194, 117, 49, 41, 101)]
  [ExclusiveTo(typeof (Appointment))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppointment
  {
    DateTime StartTime { get; set; }

    TimeSpan Duration { get; set; }

    string Location { get; set; }

    string Subject { get; set; }

    string Details { get; set; }

    IReference<TimeSpan> Reminder { get; set; }

    AppointmentOrganizer Organizer { get; set; }

    IVector<AppointmentInvitee> Invitees { get; }

    AppointmentRecurrence Recurrence { get; set; }

    AppointmentBusyStatus BusyStatus { get; set; }

    bool AllDay { get; set; }

    AppointmentSensitivity Sensitivity { get; set; }

    Uri Uri { get; set; }
  }
}
