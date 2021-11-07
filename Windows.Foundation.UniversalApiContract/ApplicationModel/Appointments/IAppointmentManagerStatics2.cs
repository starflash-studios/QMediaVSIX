// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentManagerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [Guid(176289293, 53327, 16436, 175, 114, 163, 101, 115, 180, 95, 240)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppointmentManager))]
  internal interface IAppointmentManagerStatics2
  {
    [RemoteAsync]
    [Overload("ShowAppointmentDetailsAsync")]
    IAsyncAction ShowAppointmentDetailsAsync(string appointmentId);

    [Overload("ShowAppointmentDetailsWithDateAsync")]
    [RemoteAsync]
    IAsyncAction ShowAppointmentDetailsAsync(
      string appointmentId,
      DateTime instanceStartDate);

    [RemoteAsync]
    IAsyncOperation<string> ShowEditNewAppointmentAsync(Appointment appointment);

    [RemoteAsync]
    IAsyncOperation<AppointmentStore> RequestStoreAsync(
      AppointmentStoreAccessType options);
  }
}
