// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentCalendar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.ApplicationModel.Appointments
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppointmentCalendar))]
  [Guid(1383301533, 33593, 15695, 160, 47, 100, 8, 68, 82, 187, 93)]
  internal interface IAppointmentCalendar
  {
    Color DisplayColor { get; }

    string DisplayName { get; set; }

    string LocalId { get; }

    bool IsHidden { get; }

    AppointmentCalendarOtherAppReadAccess OtherAppReadAccess { get; set; }

    AppointmentCalendarOtherAppWriteAccess OtherAppWriteAccess { get; set; }

    string SourceDisplayName { get; }

    AppointmentSummaryCardView SummaryCardView { get; set; }

    [Overload("FindAppointmentsAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<Appointment>> FindAppointmentsAsync(
      DateTime rangeStart,
      TimeSpan rangeLength);

    [Overload("FindAppointmentsAsyncWithOptions")]
    IAsyncOperation<IVectorView<Appointment>> FindAppointmentsAsync(
      DateTime rangeStart,
      TimeSpan rangeLength,
      FindAppointmentsOptions options);

    [RemoteAsync]
    IAsyncOperation<IVectorView<AppointmentException>> FindExceptionsFromMasterAsync(
      string masterLocalId);

    [RemoteAsync]
    [Overload("FindAllInstancesAsync")]
    IAsyncOperation<IVectorView<Appointment>> FindAllInstancesAsync(
      string masterLocalId,
      DateTime rangeStart,
      TimeSpan rangeLength);

    [Overload("FindAllInstancesAsyncWithOptions")]
    IAsyncOperation<IVectorView<Appointment>> FindAllInstancesAsync(
      string masterLocalId,
      DateTime rangeStart,
      TimeSpan rangeLength,
      FindAppointmentsOptions pOptions);

    [RemoteAsync]
    IAsyncOperation<Appointment> GetAppointmentAsync(string localId);

    [RemoteAsync]
    IAsyncOperation<Appointment> GetAppointmentInstanceAsync(
      string localId,
      DateTime instanceStartTime);

    [Overload("FindUnexpandedAppointmentsAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<Appointment>> FindUnexpandedAppointmentsAsync();

    [Overload("FindUnexpandedAppointmentsAsyncWithOptions")]
    IAsyncOperation<IVectorView<Appointment>> FindUnexpandedAppointmentsAsync(
      FindAppointmentsOptions options);

    [RemoteAsync]
    IAsyncAction DeleteAsync();

    [RemoteAsync]
    IAsyncAction SaveAsync();

    [RemoteAsync]
    IAsyncAction DeleteAppointmentAsync(string localId);

    [RemoteAsync]
    IAsyncAction DeleteAppointmentInstanceAsync(
      string localId,
      DateTime instanceStartTime);

    IAsyncAction SaveAppointmentAsync(Appointment pAppointment);
  }
}
