// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.ApplicationModel.Appointments
{
  [Guid(976288257, 23616, 18845, 179, 63, 164, 48, 80, 247, 79, 196)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppointmentManager))]
  internal interface IAppointmentManagerStatics
  {
    [Overload("ShowAddAppointmentAsync")]
    [RemoteAsync]
    IAsyncOperation<string> ShowAddAppointmentAsync(
      Appointment appointment,
      Rect selection);

    [RemoteAsync]
    [Overload("ShowAddAppointmentWithPlacementAsync")]
    IAsyncOperation<string> ShowAddAppointmentAsync(
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement);

    [RemoteAsync]
    [Overload("ShowReplaceAppointmentAsync")]
    IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string appointmentId,
      Appointment appointment,
      Rect selection);

    [Overload("ShowReplaceAppointmentWithPlacementAsync")]
    [RemoteAsync]
    IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string appointmentId,
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement);

    [RemoteAsync]
    [Overload("ShowReplaceAppointmentWithPlacementAndDateAsync")]
    IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string appointmentId,
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement,
      DateTime instanceStartDate);

    [Overload("ShowRemoveAppointmentAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string appointmentId,
      Rect selection);

    [Overload("ShowRemoveAppointmentWithPlacementAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string appointmentId,
      Rect selection,
      Placement preferredPlacement);

    [Overload("ShowRemoveAppointmentWithPlacementAndDateAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string appointmentId,
      Rect selection,
      Placement preferredPlacement,
      DateTime instanceStartDate);

    [RemoteAsync]
    IAsyncAction ShowTimeFrameAsync(DateTime timeToShow, TimeSpan duration);
  }
}
