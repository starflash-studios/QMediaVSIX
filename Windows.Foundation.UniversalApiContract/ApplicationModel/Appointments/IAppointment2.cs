// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointment2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1585813564, 21519, 13394, 155, 92, 13, 215, 173, 76, 101, 162)]
  [ExclusiveTo(typeof (Appointment))]
  internal interface IAppointment2 : IAppointment
  {
    string LocalId { get; }

    string CalendarId { get; }

    string RoamingId { get; set; }

    IReference<DateTime> OriginalStartTime { get; }

    bool IsResponseRequested { get; set; }

    bool AllowNewTimeProposal { get; set; }

    string OnlineMeetingLink { get; set; }

    IReference<DateTime> ReplyTime { get; set; }

    AppointmentParticipantResponse UserResponse { get; set; }

    bool HasInvitees { get; }

    bool IsCanceledMeeting { get; set; }

    bool IsOrganizedByUser { get; set; }
  }
}
