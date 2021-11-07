// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentPropertiesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppointmentProperties))]
  [Guid(622075881, 26798, 15022, 133, 95, 188, 68, 65, 202, 162, 52)]
  internal interface IAppointmentPropertiesStatics
  {
    string Subject { get; }

    string Location { get; }

    string StartTime { get; }

    string Duration { get; }

    string Reminder { get; }

    string BusyStatus { get; }

    string Sensitivity { get; }

    string OriginalStartTime { get; }

    string IsResponseRequested { get; }

    string AllowNewTimeProposal { get; }

    string AllDay { get; }

    string Details { get; }

    string OnlineMeetingLink { get; }

    string ReplyTime { get; }

    string Organizer { get; }

    string UserResponse { get; }

    string HasInvitees { get; }

    string IsCanceledMeeting { get; }

    string IsOrganizedByUser { get; }

    string Recurrence { get; }

    string Uri { get; }

    string Invitees { get; }

    IVector<string> DefaultProperties { get; }
  }
}
