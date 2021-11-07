// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.IAppointmentCalendarProposeNewTimeForMeetingRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AppointmentCalendarProposeNewTimeForMeetingRequest))]
  [Guid(3457967093, 60918, 17347, 130, 183, 190, 107, 54, 140, 105, 0)]
  internal interface IAppointmentCalendarProposeNewTimeForMeetingRequest
  {
    string AppointmentCalendarLocalId { get; }

    string AppointmentLocalId { get; }

    IReference<DateTime> AppointmentOriginalStartTime { get; }

    DateTime NewStartTime { get; }

    TimeSpan NewDuration { get; }

    string Subject { get; }

    string Comment { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
