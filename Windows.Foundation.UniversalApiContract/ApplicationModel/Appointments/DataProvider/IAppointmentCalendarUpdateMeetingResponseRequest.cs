// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.IAppointmentCalendarUpdateMeetingResponseRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2741854348, 49821, 19348, 176, 134, 126, 159, 247, 189, 132, 160)]
  [ExclusiveTo(typeof (AppointmentCalendarUpdateMeetingResponseRequest))]
  internal interface IAppointmentCalendarUpdateMeetingResponseRequest
  {
    string AppointmentCalendarLocalId { get; }

    string AppointmentLocalId { get; }

    IReference<DateTime> AppointmentOriginalStartTime { get; }

    AppointmentParticipantResponse Response { get; }

    string Subject { get; }

    string Comment { get; }

    bool SendUpdate { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
