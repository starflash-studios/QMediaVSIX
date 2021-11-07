// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.IAppointmentCalendarSyncManagerSyncRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [Guid(313210923, 29027, 19030, 154, 78, 114, 35, 168, 74, 223, 70)]
  [ExclusiveTo(typeof (AppointmentCalendarSyncManagerSyncRequest))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAppointmentCalendarSyncManagerSyncRequest
  {
    string AppointmentCalendarLocalId { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
