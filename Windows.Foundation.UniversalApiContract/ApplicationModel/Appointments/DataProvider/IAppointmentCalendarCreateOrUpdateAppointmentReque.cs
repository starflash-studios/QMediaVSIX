// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.IAppointmentCalendarCreateOrUpdateAppointmentRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [Guid(778236594, 51862, 18604, 145, 36, 64, 107, 25, 254, 250, 112)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AppointmentCalendarCreateOrUpdateAppointmentRequest))]
  internal interface IAppointmentCalendarCreateOrUpdateAppointmentRequest
  {
    string AppointmentCalendarLocalId { get; }

    Appointment Appointment { get; }

    bool NotifyInvitees { get; }

    IVectorView<string> ChangedProperties { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync(Appointment createdOrUpdatedAppointment);

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
