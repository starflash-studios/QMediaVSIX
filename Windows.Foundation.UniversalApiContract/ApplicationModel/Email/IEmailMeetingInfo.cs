// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMeetingInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Appointments;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(834682793, 31027, 16735, 162, 117, 209, 101, 186, 7, 2, 107)]
  [ExclusiveTo(typeof (EmailMeetingInfo))]
  internal interface IEmailMeetingInfo
  {
    bool AllowNewTimeProposal { get; set; }

    string AppointmentRoamingId { get; set; }

    IReference<DateTime> AppointmentOriginalStartTime { get; set; }

    TimeSpan Duration { get; set; }

    bool IsAllDay { get; set; }

    bool IsResponseRequested { get; set; }

    string Location { get; set; }

    IReference<DateTime> ProposedStartTime { get; set; }

    IReference<TimeSpan> ProposedDuration { get; set; }

    IReference<DateTime> RecurrenceStartTime { get; set; }

    AppointmentRecurrence Recurrence { get; set; }

    ulong RemoteChangeNumber { get; set; }

    DateTime StartTime { get; set; }
  }
}
