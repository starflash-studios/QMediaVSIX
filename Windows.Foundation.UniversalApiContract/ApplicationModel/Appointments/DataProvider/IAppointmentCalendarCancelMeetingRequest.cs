// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.IAppointmentCalendarCancelMeetingRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [Guid(1229328269, 25652, 16599, 173, 70, 98, 151, 65, 147, 20, 209)]
  [ExclusiveTo(typeof (AppointmentCalendarCancelMeetingRequest))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAppointmentCalendarCancelMeetingRequest
  {
    string AppointmentCalendarLocalId { get; }

    string AppointmentLocalId { get; }

    IReference<DateTime> AppointmentOriginalStartTime { get; }

    string Subject { get; }

    string Comment { get; }

    bool NotifyInvitees { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
