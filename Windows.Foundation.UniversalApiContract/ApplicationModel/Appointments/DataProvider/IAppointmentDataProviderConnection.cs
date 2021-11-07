// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.IAppointmentDataProviderConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [Guid(4091387267, 12884, 18015, 171, 219, 146, 128, 70, 85, 44, 244)]
  [ExclusiveTo(typeof (AppointmentDataProviderConnection))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAppointmentDataProviderConnection
  {
    event TypedEventHandler<AppointmentDataProviderConnection, AppointmentCalendarSyncManagerSyncRequestEventArgs> SyncRequested;

    event TypedEventHandler<AppointmentDataProviderConnection, AppointmentCalendarCreateOrUpdateAppointmentRequestEventArgs> CreateOrUpdateAppointmentRequested;

    event TypedEventHandler<AppointmentDataProviderConnection, AppointmentCalendarCancelMeetingRequestEventArgs> CancelMeetingRequested;

    event TypedEventHandler<AppointmentDataProviderConnection, AppointmentCalendarForwardMeetingRequestEventArgs> ForwardMeetingRequested;

    event TypedEventHandler<AppointmentDataProviderConnection, AppointmentCalendarProposeNewTimeForMeetingRequestEventArgs> ProposeNewTimeForMeetingRequested;

    event TypedEventHandler<AppointmentDataProviderConnection, AppointmentCalendarUpdateMeetingResponseRequestEventArgs> UpdateMeetingResponseRequested;

    void Start();
  }
}
